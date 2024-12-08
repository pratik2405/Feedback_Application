using CodingRound.Controllers;
using CodingRound.Models;

namespace CodingRound.Repo
{
    public class UserRepo : IUserrepo
    {
        private readonly ApplicationContext db;
        public UserRepo(ApplicationContext db)
        {
            this.db = db;
        }
        public User Login(User user)
        {
            return db.Users?.Where(x => x.Email == user.Email && x.PasswordHash == user.PasswordHash).FirstOrDefault();
        }

        public int Registration(User user)
        {
            int result = 0;
            db.Users.Add(user);
            result = db.SaveChanges();
            return result;
        }
    }
}
