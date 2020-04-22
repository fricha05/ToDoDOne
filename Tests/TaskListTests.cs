using System;
using Xunit;
using App;

namespace Tests
{
    public class TaskListTests
    {
        [Fact]
        public void AddTask_should_add_task_to_task_list()
        {

            Task task = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task);            
            Assert.Contains(task, list.tasks);
        }

        [Fact]
        public void RemoveTask_should_remove_task_from_task_list()
        {
            Task task = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task);
            list.RemoveTask(task);        
            Assert.DoesNotContain(task, list.tasks);
        }


        
        [Fact]
        public void AddTask_should_not_add_task_with_same_name()
        {
            Task task = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task);
            ArgumentException exception = Assert.Throws<ArgumentException>(() => list.AddTask(task));
            Assert.Equal("Task with this name already exist", exception.Message);
        }

        [Fact]
        public void FindTask_should_return_task_from_task_list()
        {
            Task task1 = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            Task task2 = new Task("PAIN","Manger du pain", ApplicationTime.Now, TaskState.TODO);
            Task task3 = new Task("ECOLE","Rendre le projet à l'heure", ApplicationTime.Now, TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task1);
            list.AddTask(task2);
            list.AddTask(task3);
            Assert.Equal(list.FindTask(task3.name), task3);        
        }

        [Fact]
        public void SetTaskToDone_should_set_task_to_done()
        {
            Task task1 = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            Task task2 = new Task("PAIN","Manger du pain", ApplicationTime.Now, TaskState.TODO);
            Task task3 = new Task("ECOLE","Rendre le projet à l'heure", ApplicationTime.Now, TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task1);
            list.AddTask(task2);
            list.AddTask(task3);
            list.SetTaskToDone(task3);
            Assert.Equal(TaskState.DONE, list.FindTask(task3.name).state);        
        }

         [Fact]
        public void orderTaskList_should_order_task()
        {
            Task task1 = new Task("WC","Acheter du papier toilettes", ApplicationTime.Now, TaskState.TODO);
            Task task2 = new Task("PAIN","Manger du pain", ApplicationTime.Now.AddDays(1), TaskState.TODO);
            Task task3 = new Task("ECOLE","Rendre le projet à l'heure", ApplicationTime.Now.AddDays(-2), TaskState.TODO);
            TaskList list = new TaskList();
            list.AddTask(task1);
            list.AddTask(task2);
            list.AddTask(task3);
            list.OrderTaskList();
            Assert.Equal(list.tasks[0], task3);        
        }


    }
}

