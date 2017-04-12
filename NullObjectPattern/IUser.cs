using System;

namespace NullObjectPattern
{
    public interface IUser
    {
        bool IsNull { get; }
        string Name { get; }
    }

    public class User : IUser
    {
        public User(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public bool IsNull => false;
        public string Name { get; }
        public int Id { get; }
    }

    public class NullUser : IUser
    {
        public bool IsNull => true;
        public string Name => "unknown";
    }
}
