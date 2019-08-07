using System;

namespace EasyDevelopersApp.API.Models
{
    public class User
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Name { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string eMail { get; set; }

        public string LinkedIn { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portifolio { get; set; }

        public int WillingnessToWork { get; set; }

        public DateTime BestTimeToWork { get; set; }
    }
}