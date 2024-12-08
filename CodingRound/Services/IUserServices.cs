using CodingRound.Models;

namespace CodingRound.Services
{
    public interface IUserServices
    {
        public int Registration(User user);

        public User Login(User user);
    }
}
