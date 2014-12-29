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
        public ActionResult Page()
        {
            var schedule = new ScheduleModel
            {
                Items = new Dictionary<string, List<ScheduleModel.ScheduleItem>>
                {
                    { DateTime.Now.AddDays(1).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(2).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(3).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(4).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(5).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(6).ToShortDateString(), GenerateRandomItems() },
                    { DateTime.Now.AddDays(7).ToShortDateString(), GenerateRandomItems() }
                }
            };

            var aggregate = new AggregateModel();
            aggregate.Models.Add(schedule);

            return View("Index", aggregate);
        }

        public ActionResult AnotherPage()
        {
            var aggregate = new AggregateModel();

            return View(aggregate);
        }

        private List<ScheduleModel.ScheduleItem> GenerateRandomItems()
        {
            var linkedList = new List<ScheduleModel.ScheduleItem>();
            
            for (int i = 1; i <= 5; i++)
            {
                var item = new ScheduleModel.ScheduleItem
                {
                    Id = i,
                    Title = Guid.NewGuid().ToString() ,
                    Description = string.Format("Some description: {0}", Guid.NewGuid())
                };

                linkedList.Add(item);
            }

            return linkedList;
        }
    }
}