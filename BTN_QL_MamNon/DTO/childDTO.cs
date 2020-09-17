using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class childDTO
    {
        long id;
        string name;
        string birthday;
        int gender;
        int status;
        long id_customer;

        public childDTO(long id, string name, string birthday, int gender, int status, long id_customer)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
            this.gender = gender;
            this.status = status;
            this.id_customer = id_customer;
        }
        public string Name { get => name; set => name = value; }
        public long Id1 { get => id; set => id = value; }
        public string Name1 { get => name; set => name = value; }
        public string Birthday { get => birthday; set => birthday = value; }
        public int Gender { get => gender; set => gender = value; }
        public int Status { get => status; set => status = value; }
        public long Id_customer { get => id_customer; set => id_customer = value; }
    }
}