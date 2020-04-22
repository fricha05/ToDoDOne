namespace App {

    public enum CommandName
    {
        ADD,
        SHOW,
        DONE,
        REMOVE 
    }
    public class Command {
        // Lib add name description  add name description remove blabla
        // Lib remove description
        // Lib show 

        public CommandName command;
        public string taskName;
        public string taskDescription;

        public Command(CommandName command, string taskName, string taskDescription){
            this.command = command;
            this.taskName = taskName;
            this.taskDescription = taskDescription;
        }

    }
}