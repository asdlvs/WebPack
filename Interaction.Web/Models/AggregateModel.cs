using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Interaction.Web.Models
{
    public class AggregateModel : AngularModel
    {
        public AggregateModel()
            : base("aggregate")
        {
            Models = new List<AngularModel>();
        }

        public List<AngularModel> Models { get; set; }

        private const string pattern = @"<script type=""text/javascript"">" + "\n" +
                                            "var {0} = {{ settings: {{}} }}, \n" +
                                            "    mappings = [],\n" +
                                            "    app = angular.module('{0}', ['ngRoute']); \n" +
                                            "angular.module('{0}').factory('serverData', function($cacheFactory) {{\n" +
                                                "var cache = $cacheFactory('{0}');\n" +
                                                "{1}\n" +
                                                "return cache;\n" +
                                            "}});\n" +
                                            "{2}\n" +
                                         "</script>\n";

        private const string cachePattern = "cache.put('{0}', {1});\n";
        private const string debugPattern = "mappings.push('{0}');\n";

        public override string GetModel()
        {
            var caches = new StringBuilder();
            var debugs = new StringBuilder();

            foreach (var model in Models)
            {
                caches.AppendFormat(cachePattern, model.Name, model.GetModel());
                debugs.AppendFormat(debugPattern, model.Name);
            }

            return string.Format(pattern, this.Name, caches, debugs);
        }
    }
}