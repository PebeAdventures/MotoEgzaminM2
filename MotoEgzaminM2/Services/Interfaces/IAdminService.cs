using MotoEgzaminM2.DTO.Admin;

namespace MotoEgzaminM2.Services.Interfaces;

public interface IAdminService
{
    Task<UserId> AddNewAdmin(AdminCreateDTO request);
}