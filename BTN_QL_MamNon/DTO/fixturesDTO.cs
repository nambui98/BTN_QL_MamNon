using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class fixturesDTO
    {
        long id;
        long id_category_fixtures;
        string name;
        int remain_quantity;
        int lose_quantity;

        public fixturesDTO(long id, long id_category_fixtures, string name, int remain_quantity, int lose_quantity)
        {
            this.id = id;
            this.id_category_fixtures = id_category_fixtures;
            this.name = name;
            this.remain_quantity = remain_quantity;
            this.lose_quantity = lose_quantity;
        }

        public long Id { get => id; set => id = value; }
        public long Id_category_fixtures { get => id_category_fixtures; set => id_category_fixtures = value; }
        public string Name { get => name; set => name = value; }
        public int Remain_quantity { get => remain_quantity; set => remain_quantity = value; }
        public int Lose_quantity { get => lose_quantity; set => lose_quantity = value; }
    }
}