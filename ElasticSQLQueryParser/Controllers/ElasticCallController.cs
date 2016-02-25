using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElasticSQLQueryParser.Controllers
{
    public class ElasticCallController : ApiController
    {
        // GET api/queryparser
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/queryparser/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/queryparser
        public void Post([FromBody]string value)
        {
        }

        // PUT api/queryparser/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/queryparser/5
        public void Delete(int id)
        {
        }
    }
}
