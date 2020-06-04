using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebLab4.Models;
using System.ComponentModel.DataAnnotations;

namespace WebLab4.Controllers
{
    public class AutheficationController : Controller
    {
        [HttpGet]
        public IActionResult Auth()
        {
            User model = new User();
            model.UserInfoModel = new UserInfo();
            ViewBag.Private = "none";
            return View(model);
        }
        [HttpPost]
        public IActionResult Auth(User model, string action)
        {
            List<ValidationResult> validationResults = new List<ValidationResult>();
            if (action == "SignUp")
            {
                Validator.TryValidateObject(model.UserInfoModel, new ValidationContext(model.UserInfoModel), validationResults, true);
                if (validationResults.Count() == 0)
                {

                    ViewBag.Public = "none";
                    ModelState.Clear();
                    return View(model);
                }
                else
                {
                    ViewBag.Private = "none";
                    return View(model);
                }

            }
            else
            {
                validationResults.Clear();
                Validator.TryValidateObject(model.PrivateUserInfoModel, new ValidationContext(model.PrivateUserInfoModel), validationResults, true);
                if (validationResults.Count() == 0)
                {

                    return View("AuthComplete", model);
                }
                else
                {
                    ViewBag.Public = "none";
                    return View(model);
                }
            }
        }

        public IActionResult AuthComplete()
        {
            return View();
        }
    }
}