using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    internal class TestsUserTaskCRUD
    {
        UserTaskContext userTaskContext;

        [Test]
        public void TestCreateUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            userTaskContext.Create(testingUser, testingTask);

            Assert.That(testingTask, Is.EqualTo(userTaskContext.Read(testingTask.TaskId)), "Create method for Task isn't working");
        }

        [Test]
        public void TestReadUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            UserTask taskFromDB = userTaskContext.Read(testingTask.TaskId);

            Assert.That(testingTask, Is.EqualTo(taskFromDB), "Read method for Task isn't working");
        }

        [Test]
        public void TestUpdateUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            UserTask updatedTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            userTaskContext.Update(updatedTask);

            Assert.That(updatedTask, Is.EqualTo(userTaskContext.Read(updatedTask.TaskId)), "Update method for Task isn't working");
        }

        [Test]
        public void TestDeleteUser()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            userTaskContext.Delete(testingTask.TaskId);

            Assert.Throws<Exception>(() => userTaskContext.Read(testingTask.TaskId));
        }
    }
}
