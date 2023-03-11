using nguyenhoaitrungLTW_2011061935.Models;
using nguyenhoaitrungLTW_2011061935.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace nguyenhoaitrungLTW_2011061935.Controllers
{
    public class CoursesController : Controller
    {   
        private readonly ApplicationDbContext _dbContext;
        public CoursesController() { 
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories= _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}