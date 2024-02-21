using AutoMapper;
using DemoDotNet8AutoMapperAndDTOs.DTOs;
using DemoDotNet8AutoMapperAndDTOs.Models;

namespace DemoDotNet8AutoMapperAndDTOs.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
                       // source   // Destination
            CreateMap<RequestDTO, Book>().ReverseMap();

            CreateMap<Book, ResponseDTO>()
                .ForMember(dest => dest.TitleAndYear,
                opt => opt.MapFrom(src => $"{src.Title} {src.Year}"));
        }
    }
}
