
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class positon_roleDTO
    {
        long id;
        long id_position;
        long id_role;

        public positon_roleDTO(long id, long id_position, long id_role)
        {
            this.id = id;
            this.id_position = id_position;
            this.id_role = id_role;
        }

        public long Id { get => id; set => id = value; }
        public long Id_position { get => id_position; set => id_position = value; }
        public long Id_role { get => id_role; set => id_role = value; }
    }
}