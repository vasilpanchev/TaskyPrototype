using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer;

namespace TestingLayer
{
    public class TestsUserCRUD
    {
        UserContext userContext;

        [Test]
        public void TestCreateUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };

            userContext.Create(testingUser);

            //Assert.AreEqual(userContext.Read(testingUser.Username), testingUser, "Create method isn't working");
            Assert.That(testingUser, Is.EqualTo(userContext.Read(testingUser.Username)), "Create method for User isn't working");
        }

        [Test]
        public void TestReadUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);

            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };

            User userFromDB = userContext.Read(testingUser.Username);

            //Assert.AreEqual(userFromDB, testingUser, "Read method isn't working");
            Assert.That(testingUser, Is.EqualTo(userFromDB), "Read method for User isn't working");
        }

        [Test]
        public void TestUpdateUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User updatedUser = new User("Atanas", "updatedPasswordAtanas123") { Username = "Atanas", Password = "updatedPasswordAtanas123" };

            userContext.Update(updatedUser);

            //Assert.AreEqual(userContext.Read(updatedUser.Username, updatedUser, "Read method isn't working");
            Assert.That(updatedUser, Is.EqualTo(userContext.Read(updatedUser.Username)), "Update method for User isn't working");
        }
        
        [Test]
        public void TestDeleteUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "updatedPasswordAtanas123") { Username = "Atanas", Password = "updatedPasswordAtanas123" };

            userContext.Delete(testingUser.Username);

            Assert.Throws<Exception>(() => userContext.Read(testingUser.Username));
        }
    }
}
