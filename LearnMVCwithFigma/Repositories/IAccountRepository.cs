using LearnMVCwithFigma.ViewModels;

namespace LearnMVCwithFigma.Repositories
{
    public interface IAccountRepository
    {
        Task AddAccount(AddAccountViewModel obj);
    }
}
