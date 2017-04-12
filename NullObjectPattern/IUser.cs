using System;

namespace NullObjectPattern
{
    public interface IUser
    {
        void IncrementSessionTicket();

        bool IsNull { get; }
        string Name { get; }
    }

    public class User : IUser
    {
        public User(Guid guid)
        {
            Id = guid;
        }

        public void IncrementSessionTicket()
        {

        }

        public bool IsNull => false;
        public string Name { get; set; }
        public Guid Id { get; }
    }

    public class NullUser : IUser
    {
        public void IncrementSessionTicket()
        {

        }

        public bool IsNull => true;
        public string Name => "unknown";
    }
}
