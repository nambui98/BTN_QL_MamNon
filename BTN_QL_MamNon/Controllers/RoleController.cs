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
    public class RoleController : ApiController
    {
        // GET: api/Role
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.roles;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Customer/5
        public roleDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                role s = db.roles.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new roleDTO(s.id, s.name, s.address);
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody] role obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.roles.Add(obj);
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
        public HttpResponseMessage Put(int id, [FromBody] role value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    role s = db.roles.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.address = value.address;
                       
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new roleDTO(s.id, s.name, s.address));
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
                    role s = db.roles.SingleOrDefault(x => x.id == id);
                    db.roles.Remove(s);
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
