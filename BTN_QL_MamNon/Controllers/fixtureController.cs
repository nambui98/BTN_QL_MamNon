using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BTN_QL_MamNon.DTO;
using BTN_QL_MamNon.Models;

namespace BTN_QL_MamNon.Controllers
{
    public class fixtureController : ApiController
    {
        // GET: api/Fixture
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.fixtures;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Fixture/5
        public fixturesDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                fixture s = db.fixtures.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new fixturesDTO(s.id, Convert.ToInt64(s.id_category_fixtures),s.name, (int)(s.remain_quantity), (int)(s.lose_quantity));
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Fixture
        public HttpResponseMessage Post([FromBody] fixture obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.fixtures.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Fixture/5
        public HttpResponseMessage Put(int id, [FromBody] fixture value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    fixture s = db.fixtures.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.id_category_fixtures = value.id_category_fixtures;
                        s.name = value.name;
                        s.remain_quantity = value.remain_quantity;
                        s.lose_quantity = value.lose_quantity;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, new fixturesDTO(s.id, Convert.ToInt64(s.id_category_fixtures), s.name, (int)(s.remain_quantity), (int)(s.lose_quantity)));
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // DELETE: api/Fixture/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    fixture s = db.fixtures.SingleOrDefault(x => x.id == id);
                    db.fixtures.Remove(s);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}
