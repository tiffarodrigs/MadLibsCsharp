using Microsoft.AspNetCore.Mvc;
using System;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/main")]
    public ActionResult Main() { return View(); }
    
      [Route("/adventureMadLib")]
      public ActionResult AdventureMadLib(string verb, string adjective, string noun, string noun2, int number)
      {
        MadlibVariable myMadlibVariable = new MadlibVariable();
        myMadlibVariable.Verb = verb;
        myMadlibVariable.Noun = noun;
        myMadlibVariable.Noun2 = noun2;
        myMadlibVariable.Adjective = adjective;
        myMadlibVariable.Number = number;
        return View(myMadlibVariable);
      }
      [Route("/adventureForm")]
      public ActionResult AdventureForm()
      {
        return View("AdventureForm"); 
      }
 
      [Route("/dreamMadLib")]
      public ActionResult DreamMadLib(string verb, string adjective, string noun, string noun2, int number)
      {
       MadlibVariable myMadlibVariableDream = new MadlibVariable();
        myMadlibVariableDream.Verb = verb;
        myMadlibVariableDream.Noun = noun;
        myMadlibVariableDream.Noun2 = noun2;
        myMadlibVariableDream.Adjective = adjective;
        myMadlibVariableDream.Number = number;
        return View(myMadlibVariableDream);
      }
      [Route("/dreamForm")]
      public ActionResult DreamForm()
      {
        return View("DreamForm"); 
      }
  }
} 