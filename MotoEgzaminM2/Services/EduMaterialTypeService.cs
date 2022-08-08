using MotoEgzaminM2.Data;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialTypeService : IEduMaterialTypeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EduMaterialTypeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
