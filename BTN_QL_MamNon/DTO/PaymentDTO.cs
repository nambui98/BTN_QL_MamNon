using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class PaymentDTO
    {
        long id;
        long id_customer;
        long id_child;
        int quantity_months;
        float tuition_fees;
        string payment_date;
        string expiration_date;
        int status;

        public PaymentDTO(long id, long id_customer, long id_child, int quantity_months, float tuition_fees, string payment_date, string expiration_date, int status)
        {
            this.id = id;
            this.id_customer = id_customer;
            this.id_child = id_child;
            this.quantity_months = quantity_months;
            this.tuition_fees = tuition_fees;
            this.payment_date = payment_date;
            this.expiration_date = expiration_date;
            this.status = status;
        }


        public long Id_child { get => id_child; set => id_child = value; }
        public long Id { get => id; set => id = value; }
        public long Id_customer { get => id_customer; set => id_customer = value; }
        public int Quantity_months { get => quantity_months; set => quantity_months = value; }
        public float Tuition_fees { get => tuition_fees; set => tuition_fees = value; }
        public string Payment_date { get => payment_date; set => payment_date = value; }
        public string Expiration_date { get => expiration_date; set => expiration_date = value; }
        public int Status { get => status; set => status = value; }
    }
}