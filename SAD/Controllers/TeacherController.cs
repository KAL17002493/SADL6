﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SAD.Data;
using SAD.Models;

namespace SAD.Controllers
{
    [Authorize(Roles = "Tutor, Admin")]
    public class TeacherController : Controller
    {
        private readonly UserManager<CustomUserModel> _userManager;
        //private readonly ApplicationDbContext dbContext;
        public TeacherController(UserManager<CustomUserModel> userManager/*, ApplicationDbContext dbContext*/)
        {
            _userManager = userManager;
            //_dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> TeacherProfile()
        {
            //Get current user
            var user = await _userManager.GetUserAsync(User);

            //Check if current user exists
            if (user == null) 
            {
                return NotFound();
            }

            //Create new instance TeacherModel
            //var teacherModel = new TeacherModel
            //{
            //    User = user,
            //    Available = true,
            //    About = "I am an experienced teacher with 10 years of experience in teaching Math and Science.",
            //    teacherCode = "ABC123"
            //};

            //Pass the TeacherModel instance to the view
            return View(user);
        }

    }
}
