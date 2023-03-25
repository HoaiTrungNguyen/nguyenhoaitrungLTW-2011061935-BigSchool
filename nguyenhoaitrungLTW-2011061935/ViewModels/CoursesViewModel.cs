using nguyenhoaitrungLTW_2011061935.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace nguyenhoaitrungLTW_2011061935.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
     }
}