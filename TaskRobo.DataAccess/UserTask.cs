using System.ComponentModel.DataAnnotations;

namespace TaskRobo.DataAccess
{
    public class UserTask
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskTitle { get; set; }

        public string TaskContent { get; set; }

        public string TaskStatus { get; set; }

        public AppUser User { get; set; }

        public Category Category { get; set; }
    }
}