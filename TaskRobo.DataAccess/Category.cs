using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TaskRobo.DataAccess
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryTitle { get; set; }

        public int UserId { get; set; }
    }
}