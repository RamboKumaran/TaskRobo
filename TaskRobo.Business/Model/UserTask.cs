namespace TaskRobo.Business.Model
{
    public class UserTask
    {
        public int TaskId { get; set; }

        public string TaskTitle { get; set; }

        public string TaskContent { get; set; }

        public string TaskStatus { get; set; }

        public int UserId { get; set; }

        public int CategoryId { get; set; }
    }
}