using MotoEgzaminM2.Data;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialService : IEduMaterialService
    {
        private readonly IUnitOfWork _unitOfWork;

        public EduMaterialService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
