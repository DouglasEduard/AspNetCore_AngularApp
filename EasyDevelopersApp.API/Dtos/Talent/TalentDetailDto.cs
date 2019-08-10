using System;
using System.Collections.Generic;
using EasyDevelopersApp.API.Models;

namespace EasyDevelopersApp.API.Dtos
{
    public class TalentDetailDto
    {
         public int Id { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Skype { get; set; }

        public string Phone { get; set; }

        public string eMail { get; set; }

        public string LinkedIn { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Portifolio { get; set; }

        public int WillingnessToWork { get; set; }

        public DateTime BestTimeToWork { get; set; }

        public double HourlySalaryRequirements { get; set; }

        public string PhotoUrl { get; set; }

        public ICollection<PhotoDetailDto> Photos { get; set; }
    }
}