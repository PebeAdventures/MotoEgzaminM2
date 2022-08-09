using AutoMapper;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.Author;

namespace MotoEgzaminM2.Mapper
{
    public class AuthorProfile : Profile
    {
        public AuthorProfile()
        {
            CreateMap<Author, AuthorReadDTO>()
                .ForMember(x => x.Materials, opt => opt.MapFrom(x => x.Materials.Select(x => x.Title)));
        }



    }
}
