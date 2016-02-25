using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json.Linq;

namespace ElasticSQLQueryParser.Controllers
{
    public class QueryParserController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Check()
        {
            return new JSONNetResult(JObject.Parse(Util.ElasticCall("http://localhost:9200/", "GET", "")));
        }
        [HttpPost]
        public ActionResult Explain(string Query)
        {
            return new JSONNetResult(JObject.Parse(Util.ElasticCall("http://localhost:9200/_sql/_explain", "POST", Query)));
        }
        [HttpPost]
        public ActionResult Sql(string Query)
        {
            return new JSONNetResult(JObject.Parse(Util.ElasticCall("http://localhost:9200/_sql/", "POST", Query)));
        }
        [HttpGet]
        public ActionResult Node(string Query)
        {
            return new JSONNetResult(JObject.Parse(Util.ElasticCall("http://localhost:9200/_nodes/" + Query, "GET", "")));
        }
    }
}
