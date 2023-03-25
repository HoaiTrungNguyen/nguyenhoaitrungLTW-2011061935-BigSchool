using Microsoft.AspNet.Identity;
using nguyenhoaitrungLTW_2011061935.DTOs;
using nguyenhoaitrungLTW_2011061935.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace nguyenhoaitrungLTW_2011061935.Controllers
{
    public class AttendancesController : ApiController
    {
        private ApplicationDbContext _dbContext;
     private AttendancesController() 
        {
            _dbContext = new ApplicationDbContext(); 
        }
        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendances.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exits!");

            var attendance = new Attendance
            {
                CourseId =  attendanceDto.CourseId,
                AttendeeId = userId
            };
            _dbContext.Attendances.Add(attendance);
            _dbContext.SaveChanges();
            return Ok();
        }
    }
}
