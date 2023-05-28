using LearnMVCwithFigma.Models;
using LearnMVCwithFigma.Ultilities;
using LearnMVCwithFigma.ViewModels;
using System.Security.Cryptography.X509Certificates;

namespace LearnMVCwithFigma.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        public static List<Account> Accounts = new List<Account>()
        {
            new Account()
            {
                Id=1001,Email="tungtd@gmai.com",Name="Tạ Duy Tùng",PassWord = "123456".ToHash256()
            }
        };
        public async Task AddAccount(AddAccountViewModel obj)
        {
            var acc = new Account()
            {
                Id = (Accounts.Last().Id + 1),
                Email = obj.Email,
                Name = obj.Name,
                PassWord = obj.PassWord.ToHash256()
            };
            Accounts.Add(acc);
        }
    }
}
