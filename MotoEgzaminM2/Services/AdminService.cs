using MotoEgzaminM2.Data;
using MotoEgzaminM2.Data.Entities;
using MotoEgzaminM2.DTO.Admin;
using MotoEgzaminM2.Services.Interfaces;

namespace MotoEgzaminM2.Services;

public class AdminService : IAdminService
{
    private readonly IUnitOfWork _unitOfWork;

    public AdminService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<UserId> AddNewAdmin(AdminCreateDTO request)
    {
        var user = new User() { Username = request.Username, Role = "Admin" };

        _unitOfWork.Users.AddAsync(user);

        var id = new UserId() { id = user.UserId };
        return Task.FromResult(id);
    }
}