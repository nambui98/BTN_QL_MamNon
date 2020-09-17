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
    public class Staff_teacherController : ApiController
    {
        // GET: api/Staff_teacher
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.staff_teacher;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }
        // GET: api/Staff_teacher/5
        public staff_teacherDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                staff_teacher s = db.staff_teacher.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new staff_teacherDTO(s.id, s.name, s.address, s.avatar, s.username, s.password, s.phone);
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Staff_teacher
        public HttpResponseMessage Post([FromBody] staff_teacher obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.staff_teacher.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }

        // PUT: api/Staff_teacher/5
        public HttpResponseMessage Put(int id, [FromBody] staff_teacher value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    staff_teacher s = db.staff_teacher.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.address = value.address;
                        s.avatar = value.avatar;
                        s.phone = value.phone;
                        s.username = value.username;
                        s.password = value.password;
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new staff_teacherDTO(s.id, s.name, s.address, s.avatar, s.username,s.password,s.phone));
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

        // DELETE: api/Staff_teacher/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    staff_teacher s = db.staff_teacher.SingleOrDefault(x => x.id == id);
                    db.staff_teacher.Remove(s);
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
