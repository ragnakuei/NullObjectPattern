using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern
{
    public interface IUserRepoository
    {
        IUser GetById(int newGuid);
    }

    public class UserRepoository : IUserRepoository
    {
        private readonly ICollection<User> _users;

        public UserRepoository()
        {
            _users = new List<User>()
            {
                new User(1,"A"),
                new User(2,"B"),
                new User(3,"C"),
                new User(4,"D"),
                new User(5,"E"),
            };
        }

        public UserRepoository(ICollection<User> users)
        {
            _users = users;
        }

        public IUser GetById(int userId)
        {
            var userFound = _users.SingleOrDefault(user => user.Id == userId) ?? (IUser)new NullUser();
            return userFound;
        }
    }

}
