using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaskRobo.DataAccess
{
    public class UserTask
    {
        [Key]
        public int TaskId { get; set; }

        public string TaskTitle { get; set; }

        public string TaskContent { get; set; }

        public string TaskStatus { get; set; }

        //[ForeignKey("User_Id")]
        public AppUser User { get; set; }

        //[ForeignKey("Category_CategoryId")]
        public Category Category { get; set; }
    }
}