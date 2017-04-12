using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullObjectPattern
{
    [TestClass]
    public class MyTestClass
    {
        private ICollection<User> users = new List<User> {
                    new User(1,"A"),
                    new User(2,"B"),
                    new User(3,"C")
         };

        [TestMethod]
        public void GetById_Id_1_Name_A()
        {
            IUserRepoository target = new UserRepoository(users);
            var user = target.GetById(1);
            var actual = user.Name;
            var expected = "A";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetById_Id_1_IsNull_false()
        {
            IUserRepoository target = new UserRepoository(users);
            var user = target.GetById(1);
            var actual = user.IsNull;
            var expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetById_Id_4_Name_unknown()
        {
            IUserRepoository target = new UserRepoository(users);
            var user = target.GetById(4);
            var actual = user.Name;
            var expected = "unknown";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetById_Id_4_IsNull_true()
        {
            IUserRepoository target = new UserRepoository(users);
            var user = target.GetById(4);
            var actual = user.IsNull;
            var expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
