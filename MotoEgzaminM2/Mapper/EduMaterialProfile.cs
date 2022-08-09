using AutoMapper;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterial;

namespace MotoEgzaminM2.Mapper
{
    public class EduMaterialProfile : Profile
    {
        public EduMaterialProfile()
        {
            CreateMap<EduMaterial, EduMaterialWithRatedAuthorReadDTO>()
                .ForMember(x => x.AuthorName, opt => opt.MapFrom(x => x.Author.AuthorName));
            CreateMap<EduMaterial, EduMaterialReadDTO>()
                .ForMember(x => x.TypeName, opt => opt.MapFrom(x => x.Type.Name))
                .ForMember(x => x.AuthorName, opt => opt.MapFrom(x => x.Author.AuthorName));

        }
    }
}
