using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class lessonDTO
    {
        long id;
        long id_plan;
        long id_staff;
        string name;
        string content;
        string time_start;
        string time_end;

        public lessonDTO(long id, long id_plan, long id_staff, string name, string content, string time_start, string time_end)
        {
            this.id = id;
            this.id_plan = id_plan;
            this.id_staff = id_staff;
            this.name = name;
            this.content = content;
            this.time_start = time_start;
            this.time_end = time_end;
        }

        public long Id { get => id; set => id = value; }
        public long Id_plan { get => id_plan; set => id_plan = value; }
        public long Id_staff { get => id_staff; set => id_staff = value; }
        public string Name { get => name; set => name = value; }
        public string Content { get => content; set => content = value; }
        public string Time_start { get => time_start; set => time_start = value; }
        public string Time_end { get => time_end; set => time_end = value; }
    }
}