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
    public class KitchenController : ApiController
    {
        // GET: api/Kitchen
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.kitchens;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Kitchen/5
        public kitchenDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                kitchen s = db.kitchens.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new kitchenDTO(s.id, s.name, s.address);
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Kitchen
        public HttpResponseMessage Post([FromBody] kitchen obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.kitchens.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Kitchen/5
        public HttpResponseMessage Put(int id, [FromBody] kitchen value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    kitchen s = db.kitchens.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.address = value.address;
                        return Request.CreateResponse(HttpStatusCode.OK, new kitchenDTO(s.id, s.name, s.address));
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

        // DELETE: api/Kitchen/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    kitchen s = db.kitchens.SingleOrDefault(x => x.id == id);
                    db.kitchens.Remove(s);
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
