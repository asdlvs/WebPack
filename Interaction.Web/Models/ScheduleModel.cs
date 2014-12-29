using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interaction.Web.Models
{
    public class ScheduleModel : AngularModel
    {
        public Dictionary<string, List<ScheduleItem>> Items { get; set; }
        
        public ScheduleModel() : base("schedule")
        {
            this.Items = new Dictionary<string, List<ScheduleItem>>();
        }

        public class ScheduleItem
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Description { get; set; }
        }
    }
}