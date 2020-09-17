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
    public class LessonController : ApiController
    {
        // GET: api/Lesson
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.lessons;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Lesson/5
        public lessonDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                lesson s = db.lessons.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new lessonDTO(s.id, Convert.ToInt64(s.id_plan), Convert.ToInt64(s.id_staff), s.name, s.content, s.time_start.ToString(), s.time_end.ToString());
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Lesson
        public HttpResponseMessage Post([FromBody] lesson obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.lessons.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Lesson/5
        public HttpResponseMessage Put(int id, [FromBody] lesson value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    lesson s = db.lessons.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.id_plan = value.id_plan;
                        s.id_staff = value.id_staff;
                        s.name = value.name;
                        s.content = value.content;
                        s.time_start = value.time_start;
                        s.time_end = value.time_end;
                        return Request.CreateResponse(HttpStatusCode.OK, new lessonDTO(s.id, Convert.ToInt64(s.id_plan), Convert.ToInt64(s.id_staff), s.name, s.content, s.time_start.ToString(), s.time_end.ToString()));
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

        // DELETE: api/Lesson/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    lesson s = db.lessons.SingleOrDefault(x => x.id == id);
                    db.lessons.Remove(s);
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
