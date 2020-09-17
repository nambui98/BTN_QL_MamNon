using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class revenue_expenditureDTO
    {
        long id;
        string name;
        float pay;
        int pay_tyoe;
        int status;
        long id_staff;

        public revenue_expenditureDTO(long id, string name, float pay, int pay_tyoe, int status, long id_staff)
        {
            this.id = id;
            this.name = name;
            this.pay = pay;
            this.pay_tyoe = pay_tyoe;
            this.status = status;
            this.id_staff = id_staff;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Pay { get => pay; set => pay = value; }
        public int Pay_tyoe { get => pay_tyoe; set => pay_tyoe = value; }
        public int Status { get => status; set => status = value; }
        public long Id_staff { get => id_staff; set => id_staff = value; }
    }
}