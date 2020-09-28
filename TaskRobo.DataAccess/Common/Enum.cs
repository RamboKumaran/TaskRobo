using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskRobo.DataAccess.Common
{
    public class Enum
    {
        public enum TaskStatus
        {
            [Display(Name = "To Do")]
            ToDo,

            [Display(Name = "In Progress")]
            InProgress,

            [Display(Name = "Unit Testing")]
            UnitTesting,

            [Display(Name = "Testing")]
            Testing,

            [Display(Name = "Closed")]
            Closed
        }
    }
}
