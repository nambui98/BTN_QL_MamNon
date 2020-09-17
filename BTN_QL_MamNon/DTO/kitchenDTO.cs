using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class kitchenDTO
    {
        long id;
        string name;
        string address;

        public kitchenDTO(long id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
    }
}