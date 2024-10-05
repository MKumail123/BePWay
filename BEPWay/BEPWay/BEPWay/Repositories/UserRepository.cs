using BEPWay.DataContext;
using BEPWay.Interfaces;
using BEPWay.Models.Domain;
using BEPWay.Models.DTO;
using Microsoft.EntityFrameworkCore;

namespace BEPWay.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly BEPContext context;

        public UserRepository(BEPContext context)
        {
            this.context = context;
        }
        public async Task<User> AddAsync(User user)
        {
            user.CreatedAt = System.DateTime.Now;
            user.CreatedBy = user.Name;
            user.Active = true;
            user.UpdatedAt = System.DateTime.Now;
            user.UpdatedBy = user.Name;
            await context.Users.AddAsync(user);
            await context.SaveChangesAsync();

            UserRole userRole = new UserRole()
            {
                Id = Guid.NewGuid(),
                CreatedAt = System.DateTime.Now,
                CreatedBy = user.Name,
                Active = true,
                UpdatedAt = System.DateTime.Now,
                UpdatedBy = user.Name,
                UserId = user.Id,
                RoleId = Guid.Parse("a5bc3de4-862e-475a-897c-67edfdd6b20e"),
            };

            await context.UserRoles.AddAsync(userRole);
            await context.SaveChangesAsync();

            return user;
        }

        public async Task<UserDTO> LoginAsync(User user)
        {
            var userRole = new UserRole();
            var userData = await context.Users.Include(x=>x.UserRole.Role).FirstOrDefaultAsync(x => x.UserName == user.UserName && x.Password == user.Password);
            //if (userData != null)
            //{
            //    userRole = await context.UserRoles.Where(x => x.UserId == userData.Id).FirstOrDefaultAsync();
            //}
            if (userData == null)
            {
                return null;
            }
            UserDTO role = new UserDTO
            {
                Id = userData.Id,
                UserName = userData.UserName,
                Role= userData.UserRole == null ? "customer" : userData.UserRole.Role.Name
            };
            
            return role;
        }
    }
}
