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

            Assert.AreEqual(userContext.Read(testingUser.Username).Username, testingUser.Username, "Create method isn't working");
        }

        [Test]
        public void TestReadUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };

            User userFromDB = userContext.Read(testingUser.Username);

            Assert.AreEqual(userFromDB.Username, testingUser.Username, "Read method isn't working");
        }

        [Test]
        public void TestReadAllUser()
        {
            List<User> testUsers = new List<User>();
            List<User> usersFromDb = new List<User>();
            User testingUser1 = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            User testingUser2 = new User("Vasil", "examplePassword") { Username = "Vasil", Password = "examplePassword" };
            User testingUser3 = new User("Denitsa", "examplePassword") { Username = "Denitsa", Password = "examplePassword" };
            testUsers.Add(testingUser1);
            testUsers.Add(testingUser2);
            testUsers.Add(testingUser3);
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            userContext.Create(testingUser1);
            userContext.Create(testingUser2);
            userContext.Create(testingUser3);

            usersFromDb = userContext.ReadAll().ToList();

            Assert.AreEqual(testUsers.Count, usersFromDb.Count, "ReadAll method isn't working");
        }

        [Test]
        public void TestUpdateUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User updatedUser = new User("Atanas", "updatedPasswordAtanas123") { Username = "Atanas", Password = "updatedPasswordAtanas123" };

            userContext.Update(updatedUser);

            Assert.AreEqual(userContext.Read(updatedUser.Username).Password, updatedUser.Password, "Update method isn't working");
        }
        
        [Test]
        public void TestDeleteUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userContext = new UserContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };

            userContext.Delete(testingUser.Username);

            Assert.Null(userContext.Read(testingUser.Username), "Delete method for User isn't working");
        }
    }
}
