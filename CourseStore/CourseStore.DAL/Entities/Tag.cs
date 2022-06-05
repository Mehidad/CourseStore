using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.DAL.Entities
{
    public class Tag : BaseEntity
    {
        public string TagName { get; set; }
        public List<Course> Courses { get; set; }
    }

}
