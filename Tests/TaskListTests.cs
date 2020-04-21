using System;
using Xunit;

namespace Tests
{
    public class TaskListTests
    {
        [Fact]
        public void AddTask_should_add_task_to_task_list()
        {
            Task task = new Task("Acheter du papier toilettes");
            TaskList list = new TaskList();
            list.addTask(task);
            CollectionAssert.Contains(list, task);
        }
    }
}

