using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PROG2400A1NathanSaccon.Models;

namespace PROG2400A1NathanSaccon.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(InputData model, string modificationOption, string inputArea)
        {
            if (modificationOption == "green")
            {
                model.Input = "<p id='text' style='color:green'>" + inputArea + "</p>";
            }else if (modificationOption == "reverse")
            {
                model.Input = "<p id='text'>" + InputData.Reverse(inputArea) + "</p>";
            }
            else if (modificationOption == "bold")
            {
                model.Input = "<b id='text'>" + inputArea + "</b>";
            }
            else if (modificationOption == "italic")
            {
                model.Input = "<i id='text'>" + inputArea + "</i>";
            }
            else if (modificationOption == "D2B")
            {
                model.Input = "<p id='text'>" + InputData.D2B(inputArea) + "</p>";
            }

            return View(model);
        }
    }
}
