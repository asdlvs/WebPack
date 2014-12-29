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

        private const string pattern = @"<script type=""text/javascript"">" +
                                            "var {0} = {{ settings: {{}} }};" +
                                            "var app = angular.module('{0}', ['ngRoute']);" +
                                            "angular.module('{0}').factory('serverData', function($cacheFactory) {{" +
                                                "var cache = $cacheFactory('{0}');" +
                                                "{1}" +
                                                "return cache;" +
                                            "}});" +
                                         "</script>";

        private const string cachePattern = "cache.put('{0}', {1});\n";

        public override string GetModel()
        {
            var caches = new StringBuilder();

            foreach (var model in Models)
            {
                caches.AppendFormat(cachePattern, model.Name, model.GetModel());
            }

            return string.Format(pattern, this.Name, caches);
        }
    }
}