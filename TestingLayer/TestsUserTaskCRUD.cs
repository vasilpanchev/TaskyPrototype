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
        public void TestCreateTask()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            userTaskContext.Create(testingUser, testingTask);

            Assert.That(testingTask.Title, Is.EqualTo(userTaskContext.Read(testingTask.TaskId).Title), "Create method for Task isn't working");
        }

        [Test]
        public void TestReadTask()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };

            userTaskContext.Create(testingUser, testingTask);
            UserTask taskFromDB = userTaskContext.Read(testingTask.TaskId);

            Assert.That(testingTask.Title, Is.EqualTo(taskFromDB.Title), "Read method for Task isn't working");
        }

        [Test]

        public void TestReadAllTask()
        {
            List<UserTask> testTasks = new List<UserTask>();
            List<UserTask> tasksFromDb = new List<UserTask>();
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            UserTask testingTask1 = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };
            UserTask testingTask2 = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };
            UserTask testingTask3 = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };
            testTasks.Add(testingTask1);
            testTasks.Add(testingTask2);
            testTasks.Add(testingTask3);
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            userTaskContext.Create(testingUser, testingTask1);
            userTaskContext.Create(testingUser, testingTask2);
            userTaskContext.Create(testingUser, testingTask3);

            tasksFromDb = userTaskContext.ReadAll();

            Assert.That(testTasks.Count, Is.EqualTo(tasksFromDb.Count), "ReadAll method for Task didn't work");
        }

        [Test]
        public void TestUpdateTask()
        {
            string oldTitle;
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            User testingUser = new User("Atanas", "examplePassword") { Username = "Atanas", Password = "examplePassword" };
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { Title = "Testing Task" };
            oldTitle = testingTask.Title;
            userTaskContext.Create(testingUser, testingTask);
            UserTask updatedTask = new UserTask("Updated Task", "", DateTime.Now, DateTime.Now, "Atanas") { TaskId = userTaskContext.Read(testingTask.TaskId).TaskId, Title = "Updated Task" };

            userTaskContext.Update(updatedTask);

            Assert.That(oldTitle, Is.Not.EqualTo(userTaskContext.Read(updatedTask.TaskId).Title), "Update method for Task isn't working");
        }

        [Test]
        public void TestDeleteTask()
        {
            TaskyPrototypeContext taskyPrototypeContext = new TaskyPrototypeContext();
            userTaskContext = new UserTaskContext(taskyPrototypeContext);
            UserTask testingTask = new UserTask("Testing Task", "", DateTime.Now, DateTime.Now, "Atanas") { TaskId = 9, Title = "Testing Task" };

            userTaskContext.Delete(testingTask.TaskId);

            Assert.Null(userTaskContext.Read(testingTask.TaskId), "Delete method for User isn't working");
        }
    }
}
