using BEPWay.Models.DTO;
using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace BEPWay.Interfaces
{
    public interface IUserPackageRepository
    {
        Task<UserPackageResponseDTO> Activate(UserPackageRequestDTO userPackageRequestDTO);
        List<UserPackageResponseDTO> GetInActiveUsers();
        Task<UserPackageRequestDTO> Create(UserPackageRequestDTO userPackageRequestDTO);
    }
}
