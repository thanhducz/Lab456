using LeThanhDuc_lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LeThanhDuc_lab456.Controllers
{
    public class AttendaneesController : ApiController
    {
       
            private ApplicationDbContext _dbContext;
            public AttendancesController()
            {
                _dbContext = new ApplicationDbContext();
            }
            [HttpPost]
            public IHttpActionResult Attend([frombody] int courseId)
            {
               
                var attendance = new Attendance
                {
                    CourseID =courseId,
                    AttendeeId = user.Identy.GetUserId()
                };

                _dbContext.Ateendances.Add(attendance);
                _dbContext.SaveChanges();
                return Ok();
            }
        }
}
