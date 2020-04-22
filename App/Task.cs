using System;

namespace App {
    public class Task {
        public string name {get;set;}
        public string description { get; set; }
        public DateTime date { get; set; }
        public TaskState state { get; set; }

        public Task(string name,string description, DateTime date, TaskState state){
            this.name =name;
            this.description = description;
            this.date = date;
            this.state = state;
        }

        public Task(){
            
        }

    }
}