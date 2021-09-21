namespace TaskManager.Models 
{
    public class Task
    {
        public int Id {get; set;}

        public string Title {get; set;}

        public string Description {get; set;}

        public bool Important {get; set;}

        public string DueDate {get; set;}

        public int AlertText {get; set;}

        public string Location {get; set;}

        public int Status {get; set;}

        public string User {get; set;}


    }
}
