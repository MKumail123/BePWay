using BEPWay.Models.DTO;

namespace BEPWay.Interfaces
{
    public interface IPackageRepository
    {
        List<PackageResponseDTO> GetAll();
        PackageResponseDTO GetById(Guid id);
    }
}
