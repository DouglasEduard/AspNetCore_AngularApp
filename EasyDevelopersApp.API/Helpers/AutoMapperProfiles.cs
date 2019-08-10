using System.Linq;
using AutoMapper;
using EasyDevelopersApp.API.Dtos;
using EasyDevelopersApp.API.Models;

namespace EasyDevelopersApp.API.Helpers
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<User, TalentDetailDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.isMain).Url);
                });    
            CreateMap<User, TalentsListDto>()
                .ForMember(dest => dest.PhotoUrl, opt => {
                    opt.MapFrom(src => src.Photos.FirstOrDefault(p => p.isMain).Url);
                });            
            CreateMap<Photo, PhotoDetailDto>();
        }
    }
}