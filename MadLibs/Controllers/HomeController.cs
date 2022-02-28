using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/madlib")]
    public ActionResult MadLibs(string verb, string adjective, string noun, string noun2, int number)
    {
      MadlibVariable myMadlibVariable = new MadlibVariable();
      myMadlibVariable.Verb = verb;
      myMadlibVariable.Noun = noun;
      myMadlibVariable.Noun2 = noun2;
      myMadlibVariable.Adjective = adjective;
      myMadlibVariable.Number = number;
      return View(myMadlibVariable);
    }
  }
} 