using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.DAL.Entities
{
    public class CourseTeacher : BaseEntity
    {
        public Course Course { get; set; }
        public Teacher Teacher { get; set; }
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int SortOrder { get; set; }
    }

}
