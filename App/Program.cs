using System;
using System.IO;

using Persistence;


namespace App
{
    class Program
    {
        static void Main(string[] args)
        {

            TaskList taskList = new TaskList();
            string taskListFile = "taskList.json";
            
            if(File.Exists(taskListFile))
            {
                taskList = JsonPersistence.ReadAll<TaskList>(taskListFile);
            }
            
            IOutput output = new ConsoleOutput();
            
            // EXMPLE NE PAS DECOMMENTER
    
            // List<Task> listT = Persistance.ReadAll<List<Task>>(filename);
            
            //Persistence 
            CommandName result;
            Enum.TryParse(args[0].ToUpper(), out result);
            switch (result)
            {
                case CommandName.ADD:
                    taskList.AddTask(new Task(args[1], args[2], DateTime.Now, TaskState.TODO));
                    JsonPersistence.Write<TaskList>(taskList, taskListFile);
                    break;
                case CommandName.REMOVE:
                    taskList.RemoveTask(taskList.FindTask(args[1]));
                    JsonPersistence.Write<TaskList>(taskList, taskListFile);
                    break;
                case CommandName.SHOW:
                    output.Send(taskList.ToString());
                    break;
                case CommandName.DONE:
                    Task task = taskList.FindTask(args[1]);
                    task.state = TaskState.DONE;
                    JsonPersistence.Write<TaskList>(taskList, taskListFile);
                    break;
                default:
                    output.Send("Commande invalide ex : add nom description | remove nom | done nom | show ");
                    break;
            }

           
        }
    }
}
