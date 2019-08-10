using System;

namespace EasyDevelopersApp.API.Dtos
{
    public class PhotoDetailDto
    {
        public int id { get; set; }

        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool isMain { get; set; }       
    }
}