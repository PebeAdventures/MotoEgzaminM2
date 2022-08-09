using AutoMapper;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.EduMaterialType;

namespace MotoEgzaminM2.Mapper;

public class EduMaterialTypeProfile : Profile
{
    public EduMaterialTypeProfile()
    {
        CreateMap<EduMaterialType, EduMaterialTypeDTO>();
    }
}