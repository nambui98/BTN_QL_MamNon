using BTN_QL_MamNon.DTO;
using BTN_QL_MamNon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace BTN_QL_MamNon.Controllers
{
    public class ChildController : ApiController
    {
        // GET: api/Child
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.children;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Child/5
        public childDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                child s = db.children.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new childDTO(s.id, s.name,s.birthday.ToString(),(int)(s.gender), (int)(s.status), Convert.ToInt64(s.id_customer));
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Fixture
        public HttpResponseMessage Post([FromBody] child obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.children.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Child/5
        public HttpResponseMessage Put(int id, [FromBody] child value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    child s = db.children.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.birthday = value.birthday;
                        s.gender = value.gender;
                        s.status = value.status;
                        s.id_customer = value.id_customer;
                        db.SaveChanges();
                        return Request.CreateResponse(HttpStatusCode.OK, new childDTO(s.id, s.name, s.birthday.ToString(),(int)(s.gender), (int)(s.status), Convert.ToInt64(s.id_customer)));
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

        // DELETE: api/Child/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    child s = db.children.SingleOrDefault(x => x.id == id);
                    db.children.Remove(s);
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
