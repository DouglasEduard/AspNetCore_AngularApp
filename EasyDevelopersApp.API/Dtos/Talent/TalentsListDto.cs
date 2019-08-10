using System;

namespace EasyDevelopersApp.API.Dtos
{
    public class TalentsListDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

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

        public double HourlySalaryRequirements { get; set; }    

        public string PhotoUrl { get; set; }            
    }
}