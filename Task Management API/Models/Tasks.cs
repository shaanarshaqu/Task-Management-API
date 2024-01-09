namespace Task_Management_API.Models
{
    public class Tasks : ITasks
    {
        public int Task_Id { get; set; }
        public string Task_Title { get; set; }
        public string Task_Description { get; set; }
        public string Task_status { get; set; }


        List<Tasks> tasks = new List<Tasks>
        {
            new Tasks {Task_Id=1, Task_Title="Learn HTML",Task_Description="introduction to html",Task_status="not completed"},
            new Tasks {Task_Id=1, Task_Title="Learn CSS",Task_Description="introduction to CSS",Task_status="not completed"},
            new Tasks {Task_Id=1, Task_Title="Learn Redux",Task_Description="introduction to Redux",Task_status="not completed"},
            new Tasks {Task_Id=1, Task_Title="Learn JS",Task_Description="introduction to JS",Task_status="not completed"},
        };
        public List<Tasks> GetTasks() {
        
            return 
        }
    }
}
