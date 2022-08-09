using AutoMapper;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterialReview;

namespace MotoEgzaminM2.Mapper
{
    public class EduMaterialReviewProfile : Profile
    {
        public EduMaterialReviewProfile()
        {
            CreateMap<EduMaterialReview, EduMaterialReviewReadDTO>()
                .ForMember(x => x.ReviewedMaterialName, opt => opt.MapFrom(x => x.EduMaterial.Title));


        }
    }
}
