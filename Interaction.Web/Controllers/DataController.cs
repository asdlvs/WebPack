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
                Items = GenerateDaySchedule()
            };

            var aggregate = new AggregateModel();
            aggregate.Models.Add(schedule);

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
                    Title = Guid.NewGuid().ToString() ,
                    Description = string.Format("Some description: {0}", Guid.NewGuid())
                };

                list.Add(item);
            }

            return list;
        }

        private Dictionary<string, List<ScheduleModel.ScheduleItem>> GenerateDaySchedule()
        {
            var schedule = new Dictionary<string, List<ScheduleModel.ScheduleItem>>();

            for(var i = 0; i < 5; i++)
            {
                schedule.Add(DateTime.Now.AddDays(4).ToShortDateString(), GenerateRandomItems());
            }

            return schedule;
        }
    }
}