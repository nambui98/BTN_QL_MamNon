using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class staff_teacherDTO
    {
        long id;
        string name;
        string phone;
        string username;
        string password;
        string address;
        string avatar;

        public staff_teacherDTO(long id, string name, string phone, string username, string password, string address, string avatar)
        {
            this.id = id;
            this.name = name;
            this.phone = phone;
            this.username = username;
            this.password = password;
            this.address = address;
            this.avatar = avatar;
        }

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Address { get => address; set => address = value; }
        public string Avatar { get => avatar; set => avatar = value; }
    }
}