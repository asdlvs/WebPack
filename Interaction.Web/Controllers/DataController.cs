using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Interaction.Web.Models;

namespace Interaction.Web.Controllers
{
    public class DataController : Controller
    {
        public ActionResult Index()
        {
            var schedule = new ScheduleModel
            {
                Items = GenerateDaySchedule()
            };

            var aggregate = new AggregateModel();
            aggregate.Models.Add(schedule);
            aggregate.Models.Add(new FakeModel());

            return View("Index", aggregate);
        }

        public ActionResult Contacts()
        {
            var aggregate = new AggregateModel();

            var contacts = new ContactsModel
            {
                Items = GenerateContacts()
            };
            aggregate.Models.Add(contacts);
            return View("Index", aggregate);
        }

        private List<ScheduleModel.ScheduleItem> GenerateRandomItems()
        {
            var list = new List<ScheduleModel.ScheduleItem>();

            for (int i = 1; i <= 5; i++)
            {
                var item = new ScheduleModel.ScheduleItem
                {
                    Id = i,
                    Title = Guid.NewGuid().ToString(),
                    Description = string.Format("Some description: {0}", Guid.NewGuid())
                };

                list.Add(item);
            }

            return list;
        }

        private Dictionary<string, List<ScheduleModel.ScheduleItem>> GenerateDaySchedule()
        {
            var schedule = new Dictionary<string, List<ScheduleModel.ScheduleItem>>();

            for (var i = 0; i < 5; i++)
            {
                schedule.Add(DateTime.Now.AddDays(i).ToShortDateString(), GenerateRandomItems());
            }

            return schedule;
        }

        private List<ContactsModel.Contact> GenerateContacts()
        {
            var contacts = new List<ContactsModel.Contact>();

            for (var i = 0; i < 20; i++)
            {
                contacts.Add(new ContactsModel.Contact
                {
                    Id = i,
                    Email = string.Format("user{0}@yandex.ru", i),
                    Name = "Person" + i,
                    Phone = new String(i.ToString()[0], 10)
                });
            }

            return contacts;
        }
    }
}