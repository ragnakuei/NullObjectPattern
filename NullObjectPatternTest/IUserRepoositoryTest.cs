using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NullObjectPattern
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void GetById()
        {
            IUserRepoository target = new UserRepoository();
            var user = target.GetById(Guid.NewGuid());
            var actual = user.Name;
            var expected = "unknown";

            Assert.AreEqual(expected, actual);
        }
    }
}
