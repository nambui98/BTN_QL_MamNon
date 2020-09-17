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
    public class CustomerController : ApiController
    {
        // GET: api/Customer
        //jjjjádfasdf
        //ADSadsÁDD
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.customers;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Customer/5
        public customerDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                customer s = db.customers.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new customerDTO(s.id, s.name, s.phone,s.username, s.avatar, s.address, s.account_number);
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody] customer obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.customers.Add(obj);
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
        public HttpResponseMessage Put(int id, [FromBody] customer value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    customer s = db.customers.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.phone = value.phone;
                        s.username = value.username;
                        s.password = value.password;
                        s.address = value.address;
                        s.account_number = value.account_number;
                        s.avatar = value.avatar;
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new customerDTO(s.id, s.name, s.phone, s.username, s.avatar, s.address, s.account_number));
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
                    customer s = db.customers.SingleOrDefault(x => x.id == id);
                    db.customers.Remove(s);
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
