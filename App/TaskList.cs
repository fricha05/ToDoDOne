using System;
using System.Collections.Generic;

using DateLib;

namespace App {
    public class TaskList {

        public List<Task> tasks { get; set; }
        public TaskList(){
            this.tasks = new List<Task>();
        }

        public void AddTask(Task task){
            if(!this.ContainsTask(task)){
                this.tasks.Add(task);
            }else{
                throw new ArgumentException("Task with this name already exist");
            }
        }

        public void RemoveTask(Task task){
            this.tasks.Remove(task);
        }

        public Task FindTask(string taskName){
            return this.tasks.Find(x => x.name.Equals(taskName));
        }
        public bool ContainsTask(Task task){
            return this.tasks.Contains(task);
        }

        public void SetTaskToDone(Task task){
            this.FindTask(task.name).state = TaskState.DONE;
        }

        public void OrderTaskList(){
            this.tasks.Sort((x, y) => x.date.CompareTo(y.date));
        }

        public override String ToString(){
            string res = String.Empty;
            foreach(Task t in this.tasks)
            {
                TimeSpan timeSpan = DateUtils.intervalBetweenDateTime(t.date, ApplicationTime.Now);
                string dateString = DateUtils.formatWords(timeSpan);
                res += "[" + dateString + "] " + t.name + " : " + t.description + " - " + t.state + "\n";
            }
            return res;
        }
    }
}