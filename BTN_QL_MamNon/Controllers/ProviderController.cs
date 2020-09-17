using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BTN_QL_MamNon.Models;
using BTN_QL_MamNon.DTO;

namespace BTN_QL_MamNon.Controllers
{
    public class ProviderController : ApiController
    {
        // GET: api/Provider
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.providers;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Customer/5
        public providerDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                provider s = db.providers .SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new providerDTO(s.id, s.name, s.phone, s.address);
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody] provider obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.providers.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Customer/5
        public HttpResponseMessage Put(int id, [FromBody] provider value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    provider s = db.providers.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.phone = value.phone;
                        s.address = value.name;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, new providerDTO(s.id, s.name, s.phone, s.address));
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

        // DELETE: api/Customer/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    provider s = db.providers.SingleOrDefault(x => x.id == id);
                    db.providers.Remove(s);
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
