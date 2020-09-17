using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class lesson_planDTO
    {
        long id;
        string date;

        public lesson_planDTO(long id, string date)
        {
            this.id = id;
            this.date = date;
        }

        public long Id { get => id; set => id = value; }
        public string Date { get => date; set => date = value; }
    }
}