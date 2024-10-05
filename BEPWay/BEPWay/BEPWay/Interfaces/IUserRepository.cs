using BEPWay.Models.Domain;
using BEPWay.Models.DTO;

namespace BEPWay.Interfaces
{
    public interface IUserRepository
    {
        Task<User> AddAsync(User user);
        Task<UserDTO> LoginAsync(User user);
    }
}
