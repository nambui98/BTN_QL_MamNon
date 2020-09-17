using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class kitchen_providerDTO
    {
        long id;
        long id_kitchen;
        long id_provider;

        public kitchen_providerDTO(long id, long id_kitchen, long id_provider)
        {
            this.id = id;
            this.id_kitchen = id_kitchen;
            this.id_provider = id_provider;
        }

        public long Id { get => id; set => id = value; }
        public long Id_kitchen { get => id_kitchen; set => id_kitchen = value; }
        public long Id_provider { get => id_provider; set => id_provider = value; }
    }
}