using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTN_QL_MamNon.DTO
{
    public class customerDTO
    {
        long id;
        string phone;
        string username;

        string address;
        string account_number;
        string avatar;
        string name;
        public customerDTO(long id, string phone, string username, string address, string account_number, string avatar, string name)
        {
            this.id = id;
            this.phone = phone;
            this.username = username;
            this.address = address;
            this.account_number = account_number;
            this.avatar = avatar;
            this.name = name;
        }

        public long Id { get => id; set => id = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Username { get => username; set => username = value; }

        public string Address { get => address; set => address = value; }
        public string Account_number { get => account_number; set => account_number = value; }
        public string Avatar { get => avatar; set => avatar = value; }
        public string Name { get => name; set => name = value; }
    }
}