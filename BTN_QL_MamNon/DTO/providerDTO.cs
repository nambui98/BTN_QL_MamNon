using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class providerDTO
    {
        long id;
        string name;
        string address;
        string phone;

        public providerDTO(long id, string name, string address, string phone)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}