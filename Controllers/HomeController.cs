using Microsoft.AspNetCore.Mvc;
using Triangle.Models;
using System;

namespace Triangle.Controllers
{
  public class HomeController : Controller
  {
    // [Route("/")]
    // public ActionResult Funny()
    // {
    //
    // }
    [Route("/form")]
    public ActionResult Form()
    {
      return View();
    }

    [Route("/your_triangle")]
    public ActionResult Triangle()
    {
      TriangleVariables triangleVariables = new TriangleVariables();
      triangleVariables.SetSide1(int.Parse(Request.Query["side1"]));
      triangleVariables.SetSide2(int.Parse(Request.Query["side2"]));      triangleVariables.SetSide3(int.Parse(Request.Query["side3"]));
      return View("triangle", triangleVariables);
    }

    // [Route("/mad_libs")]
    // public ActionResult MadLibs()
    // {
    //   MadLibsVariables myMadLibsVariables = new MadLibsVariables();
    //   myMadLibsVariables.SetVerb1(Request.Query["verb1"]);
    //   myMadLibsVariables.SetVerb2(Request.Query["verb2"]);
    //   myMadLibsVariables.SetVerb3(Request.Query["verb3"]);
    //   myMadLibsVariables.SetVerb4(Request.Query["verb4"]);
    //
    //   return View("Funny", myMadLibsVariables);
    // }
  }
}
