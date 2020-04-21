namespace App {
    public class Task {
        private string description { get; set; }
        private ApplicationTime date { get; set; }
        private TaskState state { get; set; }

        public Task(string description, ApplicationTime date = ApplicationTime.Now, TaskState state = TaskState.TODO){
            this.description = description;
            this.date = date;
            this.state = state;
        }

        public Task(string description){
            this.description = description;
            this.date = ApplicationTime.Now;
            this.state = TaskState.TODO;
        }
    }
}