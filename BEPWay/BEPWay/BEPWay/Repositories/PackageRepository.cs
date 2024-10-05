using BEPWay.DataContext;
using BEPWay.Interfaces;
using BEPWay.Models.DTO;

namespace BEPWay.Repositories
{
    public class PackageRepository : IPackageRepository
    {
        private readonly BEPContext dbContext;

        public PackageRepository(BEPContext dbContext) 
        {
            this.dbContext = dbContext;
        }
        public List<PackageResponseDTO> GetAll()
        {
            var response = dbContext.Packages.ToList().Select(package => new PackageResponseDTO()
            {
                PackageId = package.Id,
                Name = package.Name,
                Value = package.Value,
                Amount = package.Amount,
                Points = package.Points,
            }).ToList();
            return response;
        }

        public PackageResponseDTO GetById(Guid id)
        {
            var response = dbContext.Packages.Where(x=>x.Id == id).Select(package => new PackageResponseDTO()
            {
                PackageId = package.Id,
                Name = package.Name,
                Value = package.Value,
                Amount = package.Amount,
                Points = package.Points,
            }).FirstOrDefault();
            if(response == null)
            {
                return null;
            }
            return response;
        }
    }
}
