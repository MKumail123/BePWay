using BEPWay.DataContext;
using BEPWay.Interfaces;
using BEPWay.Models.Domain;
using BEPWay.Models.DTO;

namespace BEPWay.Repositories
{
    public class UserPackageRepository : IUserPackageRepository
    {
        private readonly BEPContext context;

        public UserPackageRepository(BEPContext context)
        {
            this.context = context;
        }

        public async Task<UserPackageResponseDTO> Activate(UserPackageRequestDTO userPackageRequestDTO)
        {
            var userPackage = new UserPackage
            {
                Id = Guid.NewGuid(),
                UserId = userPackageRequestDTO.UserId,
                PackageId = userPackageRequestDTO.PackageId,
                Active = userPackageRequestDTO.Status,
                ImagePath = userPackageRequestDTO.FilePath,
                CreatedAt = System.DateTime.Now,
                CreatedBy = userPackageRequestDTO.UserName,
                UpdatedAt = System.DateTime.Now,
                UpdatedBy = userPackageRequestDTO.UserName,
                TransactionId = userPackageRequestDTO.TransactionId,
            };
            await context.UserPackages.AddAsync(userPackage);
            await context.SaveChangesAsync();

            return  new UserPackageResponseDTO
            {
                Id = userPackage.Id,
                UserId = userPackage.UserId,
            };
        }

        public async Task<UserPackageRequestDTO> Create(UserPackageRequestDTO userPackageRequestDTO)
        {
            var userPackage = new UserPackage
            {
                Id = Guid.NewGuid(),
                UserId = userPackageRequestDTO.UserId,
                PackageId = userPackageRequestDTO.PackageId,
                Active = false,
                ImagePath = userPackageRequestDTO.FilePath,
                CreatedAt = System.DateTime.Now,
                CreatedBy = userPackageRequestDTO.UserName,
                UpdatedAt = System.DateTime.Now,
                UpdatedBy = userPackageRequestDTO.UserName,
                TransactionId = userPackageRequestDTO.TransactionId,
            };
            await context.UserPackages.AddAsync(userPackage);
            await context.SaveChangesAsync();

            return userPackageRequestDTO;
        }

        public List<UserPackageResponseDTO> GetInActiveUsers()
        {
            var userPackages = context.UserPackages.Where(x=>x.Active == false).ToList().Select(userPackage => new UserPackageResponseDTO
            {
                Id = Guid.NewGuid(),
                UserId = userPackage.UserId,
                PackageId = userPackage.PackageId,
                Status = false,
                ImageUrl = userPackage.ImagePath,
                TransactionId = userPackage.TransactionId,
                PackagePoints = context.Packages.Where(x => x.Id == userPackage.PackageId).FirstOrDefault().Points,
                PackageName = context.Packages.Where(x=>x.Id == userPackage.PackageId).FirstOrDefault().Name,
                UserName = context.Users.Where(x => x.Id == userPackage.UserId).FirstOrDefault().UserName,
            });

            return userPackages.ToList();
        }
    }
}
