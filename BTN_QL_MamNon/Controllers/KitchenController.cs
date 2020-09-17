using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BTN_QL_MamNon.Controllers
{
    public class KitchenController : ApiController
    {
        // GET: api/Kitchen
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Kitchen/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Kitchen
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Kitchen/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Kitchen/5
        public void Delete(int id)
        {
        }
    }
}
