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
    public class PaymentController : ApiController
    {
        // GET: api/Payment
        public HttpResponseMessage Get()
        {
            QLMamNonEntities db = new QLMamNonEntities();
            var result = db.payments;
            return Request.CreateResponse(HttpStatusCode.OK, result.ToList());
          
        }

        // GET: api/Payment/5
        public PaymentDTO Get(int id)
        {
            using(QLMamNonEntities db=new QLMamNonEntities())
            {
                payment s = db.payments.SingleOrDefault(x => x.id == id);
                if (s != null)
                {
                    return new PaymentDTO(s.id,Convert.ToInt64( s.id_customer), Convert.ToInt64(s.id_child), (int)(s.quantity_months),Convert.ToInt64(s.tuition_fees), s.payment_date.ToString(), s.expiration_date.ToString()
                        ,(int)(s.status));
                }
                else
                {
                    return null;
                }
            }    
            
        }

        // POST: api/Payment
        public HttpResponseMessage Post([FromBody]payment obj)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    db.payments.Add(obj);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.Created, obj);
                }
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        // PUT: api/Payment/5
        public HttpResponseMessage Put(int id,[FromBody] payment value)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    payment s = db.payments.SingleOrDefault(b => b.id == id);
                    if (s != null)
                    {
                        s.quantity_months = value.quantity_months;
                        s.tuition_fees = value.tuition_fees;
                        s.payment_date = value.payment_date;
                        s.expiration_date = value.expiration_date;
                        s.status = value.status;

                        db.SaveChanges();

                        return Request.CreateResponse(HttpStatusCode.OK, new PaymentDTO(s.id, Convert.ToInt64(s.id_customer), Convert.ToInt64(s.id_child), (int)(s.quantity_months), Convert.ToInt64(s.tuition_fees), s.payment_date.ToString(), s.expiration_date.ToString()
                        , (int)(s.status)));
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

            // DELETE: api/Payment/5
            public HttpResponseMessage Delete(int id)
        {
            try
            {
                using (QLMamNonEntities db = new QLMamNonEntities())
                {
                    payment s = db.payments.SingleOrDefault(x => x.id == id);
                    db.payments.Remove(s);
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
