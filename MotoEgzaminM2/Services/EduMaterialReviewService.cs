using MotoEgzaminM2.Data;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services
{
    public class EduMaterialReviewService : IEduMaterialReviewService
    {

        private readonly IUnitOfWork _unitOfWork;

        public EduMaterialReviewService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}
