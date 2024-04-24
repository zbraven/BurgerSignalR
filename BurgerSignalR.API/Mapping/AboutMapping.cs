using AutoMapper;
using BurgerSignalR.DtoLayer.AboutDto;
using BurgerSignalR.EntityLayer.Entities;

namespace BurgerSignalR.API.Mapping
{
    public class AboutMapping:Profile
    {
        public AboutMapping()
        {
            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About,CreateAboutDto>().ReverseMap();
            CreateMap<About,GetAboutDto>().ReverseMap();
            CreateMap<About,UpdateAboutDto>().ReverseMap();
        }
    }
}
