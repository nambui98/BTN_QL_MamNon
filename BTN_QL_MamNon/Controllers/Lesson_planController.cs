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
    public class Lesson_planController : ApiController
    {
        // GET: api/Lesson_plan
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.lesson_plan;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Lesson_plan/5
        public lesson_planDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                lesson_plan s = db.lesson_plan.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new lesson_planDTO(s.id, s.date.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Lesson_plan
        public HttpResponseMessage Post([FromBody] lesson_plan obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.lesson_plan.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Lesson_plan/5
        public HttpResponseMessage Put(int id, [FromBody] lesson_plan value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    lesson_plan s = db.lesson_plan.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.date = value.date;
                        return Request.CreateResponse(HttpStatusCode.OK, new lesson_planDTO(s.id, s.date.ToString()));
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

        // DELETE: api/Lesson_plan/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    lesson_plan s = db.lesson_plan.SingleOrDefault(x => x.id == id);
                    db.lesson_plan.Remove(s);
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
