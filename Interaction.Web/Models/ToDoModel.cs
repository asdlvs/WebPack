using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interaction.Web.Models
{
    public class ToDoModel : AngularModel
    {
        public SortedList<DateTime, string> Items { get; set; }

        public ToDoModel() : base("todo")
        {
            this.Items = new SortedList<DateTime, string>();
        }
    }
}