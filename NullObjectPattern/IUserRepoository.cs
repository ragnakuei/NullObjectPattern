using System;
using System.Collections.Generic;
using System.Linq;

namespace NullObjectPattern
{
    public interface IUserRepoository
    {
        IUser GetById(Guid newGuid);
    }

    public class UserRepoository : IUserRepoository
    {
        private readonly ICollection<User> _users;

        public UserRepoository()
        {
            _users = new List<User>()
            {
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
                new User(Guid.NewGuid()),
            };

        }

        public IUser GetById(Guid userId)
        {
            var userFound = _users.SingleOrDefault(user => user.Id == userId) ?? (IUser)new NullUser();
            return userFound;
        }
    }

}
