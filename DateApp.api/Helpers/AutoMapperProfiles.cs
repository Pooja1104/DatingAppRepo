using System.Linq;
using AutoMapper;
using DateApp.api.Dtos;
using DateApp.api.Models;

namespace DateApp.api.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            //it knows that UserName property of User class matches the UserName property of UserForListDTO class
            // and so on , no need to specify extra configuration to map each property
            CreateMap<User,UserForListDTO>()
            .ForMember(dest=>
            dest.PhotoUrl,opt=>
            opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain==true).Url))
            .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.DateOfBirth.CalculateAge()));

            CreateMap<User,UserForDetailedDTO>()
              .ForMember(dest=>
            dest.PhotoUrl,opt=>
            opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain==true).Url))
             .ForMember(dest=>dest.Age,opt=>opt.MapFrom(src=>src.DateOfBirth.CalculateAge()));
            CreateMap<Photo,PhotosForDetailedDTO>();
        }
    }
}