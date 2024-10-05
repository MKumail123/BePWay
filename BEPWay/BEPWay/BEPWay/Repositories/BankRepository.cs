using BEPWay.DataContext;
using BEPWay.Interfaces;
using BEPWay.Models.DTO;

namespace BEPWay.Repositories
{
    public class BankRepository : IBankRepository
    {
        private readonly BEPContext context;

        public BankRepository(BEPContext _context)
        {
            context = _context;
        }
        public List<BankReponseDTO> GetAll()
        {
            var response = context.Banks.ToList().Select(bank => new BankReponseDTO()
            {
                BankId = bank.Id,
                AccountNo = bank.AccountNo,
                AccountTitle = bank.AccountTitle,
                BankName = bank.BankName,
            }).ToList();
            return response;
        }

        public BankReponseDTO GetById(Guid Id)
        {
            var response = context.Banks.Where(x=>x.Id == Id).Select(bank => new BankReponseDTO()
            {
                BankId = bank.Id,
                AccountNo = bank.AccountNo,
                AccountTitle = bank.AccountTitle,
                BankName = bank.BankName,
            }).FirstOrDefault();
            if(response == null)
            {
                return null;
            }
            return response;
        }
    }
}
