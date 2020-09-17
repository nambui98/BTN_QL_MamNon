using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class roleDTO
    {
        long id;
        string name;
        string address;

        public roleDTO(long id, string name, string address)
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