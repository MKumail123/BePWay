using BEPWay.Models.Domain;
using BEPWay.Models.DTO;

namespace BEPWay.Interfaces
{
    public interface IBankRepository
    {
        List<BankReponseDTO> GetAll();
        BankReponseDTO GetById(Guid Id);
    }
}
