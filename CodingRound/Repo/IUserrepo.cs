using CodingRound.Models;

namespace CodingRound.Repo
{
    public interface IUserrepo
    {

        public int Registration(User user);

        public User Login(User user);
    }
}
