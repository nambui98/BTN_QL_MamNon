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
    public class KitchenProviderController : ApiController
    {
        // GET: api/KitchenProvider
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.kitchen_provider;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/KitchenProvider/5

        public kitchen_providerDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                kitchen_provider s = db.kitchen_provider.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new kitchen_providerDTO(s.id,Convert.ToInt64(s.id_kitchen),Convert.ToInt64( s.id_provider));
                }
                else
                {
                    return null;
                }
            }
        }
        // POST: api/KitchenProvider
        public HttpResponseMessage Post([FromBody] kitchen_provider obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.kitchen_provider.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/KitchenProvider/5
        public HttpResponseMessage Put(int id, [FromBody] kitchen_provider value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    kitchen_provider s = db.kitchen_provider.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.id_kitchen = value.id_kitchen;
                        s.id_provider = value.id_provider;
                        return Request.CreateResponse(HttpStatusCode.OK, new kitchen_providerDTO(s.id, Convert.ToInt64(s.id_kitchen), Convert.ToInt64(s.id_provider)));
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

        // DELETE: api/KitchenProvider/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    kitchen_provider s = db.kitchen_provider.SingleOrDefault(x => x.id == id);
                    db.kitchen_provider.Remove(s);
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
