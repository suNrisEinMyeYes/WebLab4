using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebLab4.Models;

namespace WebLab4.Controllers
{
    public class ResetPassController : Controller
    {
        [HttpGet]
        public IActionResult Reset()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Reset(ResetRequiredInfo model, string submit)
        {
            if (submit == "send" || submit == "have")
            {
                if (!ModelState.IsValid)
                    return View();

                SecretCode modelCode = new SecretCode();
                modelCode.code = modelCode.GetCode(5);
                return View("Code", modelCode);
            }

            return View();
        }

        public IActionResult Verify(SecretCode model)
        {
            if (!TryValidateModel(model, nameof(model)))
            {
                return View("Code", model);
            }
            return View("Done");
        }
    }
}