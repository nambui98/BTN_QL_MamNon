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
    public class revenue_expenditureController : ApiController
    {
        // GET: api/revenue_expenditure
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.revenue_expenditure;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
        }

        // GET: api/Customer/5
        public revenue_expenditureDTO Get(int id)
        {
            using (QLMamNonEntities db = new QLMamNonEntities())
            {
                revenue_expenditure s = db.revenue_expenditure.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new revenue_expenditureDTO(s.id, s.name, Convert.ToInt64(s.pay), (int)(s.pay_type), (int)(s.status),Convert.ToInt64(s.id_staff));
                }
                else
                {
                    return null;
                }
            }
        }

        // POST: api/Customer
        public HttpResponseMessage Post([FromBody] revenue_expenditure obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.revenue_expenditure.Add(obj);
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
        public HttpResponseMessage Put(int id, [FromBody] revenue_expenditure value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    revenue_expenditure s = db.revenue_expenditure.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.name = value.name;
                        s.pay = value.pay;
                        s.pay_type = value.pay_type;
                        s.status = value.status;
                        s.id_staff = value.id_staff;
                        
                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new revenue_expenditureDTO(s.id, s.name, Convert.ToInt64(s.pay), (int)(s.pay_type), (int)(s.status), Convert.ToInt64(s.id_staff))) ;
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
                    revenue_expenditure s = db.revenue_expenditure.SingleOrDefault(x => x.id == id);
                    db.revenue_expenditure.Remove(s);
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
