using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace Interaction.Web.Models
{
    public abstract class AngularModel
    {
        public string Name { get; private set; }

        protected AngularModel(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) { throw new ArgumentNullException("name"); }

            this.Name = name;
        }

        public virtual string GetModel()
        {
            var result = new StringBuilder();
            new JavaScriptSerializer().Serialize(this, result);
            return result.ToString();
        }
    }
}