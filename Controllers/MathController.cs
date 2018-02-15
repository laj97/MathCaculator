using Microsoft.AspNetCore.Mvc;
using System;

namespace MathProgram1.Controllers
{
    public class MathController : Controller
    {
        public IActionResult Add(double left, double right)
        {

            double sum = left + right;

            ViewData["Message"] = $"{left} plus {right} equals {sum}";

            return View();
        }

        public IActionResult Subtract(double left, double right)
        {

            double sum = left - right;

            if (right == 0)
            {
                ViewData["Message"] = $"{left} minus {right} equals {sum}";
            }

            return View();
        }

        public IActionResult Multiply(double left, double right)
        {

            double sum = left * right;

            if (right == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't multiply by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} minus {right} equals {sum}";
            }

            return View();
        }

        public IActionResult Divide(double left, double right)
        {

            double sum = left - right;

            if (right == 0)
            {
                //string path = @"C:\Temp\files";
                ViewData["Message"] = @"You can't divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} divided by {right} equals {sum}";
            }

            return View();
        }

        public IActionResult Modulus(Double left, Double right)
        {
            double remain = left % right;

            if (right == 0)
            {
                ViewData["Message"] = @"You can't divide by zero";
            }
            else
            {
                ViewData["Message"] = $"{left} divided by {right} remains {remain}";
            }

            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

    }
}