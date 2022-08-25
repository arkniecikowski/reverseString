using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AppSolbeg.Models;

namespace AppSolbeg.Controllers;

public class HomeController : Controller
{
    public string ReverseString(string t)
    {
        if (t == null || t.Length <= 1) 
            return t;

        return ReverseString(t.Substring(1)) + t[0];
    }

    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(string Text)
    {
        String reversedText = ReverseString(Text);

        return Content(reversedText);
    }

}

