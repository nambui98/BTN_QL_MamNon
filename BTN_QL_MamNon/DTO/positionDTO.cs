using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class positionDTO
    {
        long id;
        string name;

        public positionDTO(long id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
    }
}