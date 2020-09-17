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
    public class positon_roleController : ApiController
    {
        // GET: api/positon_role
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.position_role;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Customer/5
        public positon_roleDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                position_role s = db.position_role.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new positon_roleDTO(s.id, Convert.ToInt64(s.id_position),Convert.ToInt64(s.id_role));
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody] position_role obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.position_role.Add(obj);
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
        public HttpResponseMessage Put(int id, [FromBody] position_role value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    position_role s = db.position_role.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                      
                        s.id_position = value.id_position;
                        s.id_role = value.id_role;
                       
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new positon_roleDTO(s.id,Convert.ToInt32(s.id_position), Convert.ToInt32(s.id_role)));
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
                    position_role s = db.position_role.SingleOrDefault(x => x.id == id);
                    db.position_role.Remove(s);
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
