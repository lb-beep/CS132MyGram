using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CS132MyGram.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CS132MyGram.Controllers
{
    public class SignUpController : Controller
    {
        private object firstName;
        private object lastName;
        private object dateOfBirth;
        private object gender;

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp([FromForm]SignUp signUp)
        {
            string result = $"The user name is: {firstName} {lastName}" +
                $"they were born on: {dateOfBirth}" +
                $"the gender is {gender}"; 

            return Content(result);
        }

    }
}

