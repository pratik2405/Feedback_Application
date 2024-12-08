using CodingRound.Models;
using CodingRound.Repo;

namespace CodingRound.Services
{
    public class UserServices : IUserServices
    {
        private readonly IUserrepo repo;
        public UserServices(IUserrepo repo)
        {
            this.repo = repo;
        }
        public User Login(User user)
        {
           return repo.Login(user);
        }

        public int Registration(User user)
        {
            return repo.Registration(user);
        }
    }
}
