using Microsoft.AspNetCore.Mvc;
using Madlibs.Models;

namespace Madlibs.Controllers
{
    public class HomeController : Controller
    {
        [Route("/result")]
        public ActionResult Result(string person1, string person2, string animal, string exclamation, string verb, string noun)
        {
            MadlibsVariable myMadlibsVariable = new MadlibsVariable();
            myMadlibsVariable.SetPerson1(person1);
            myMadlibsVariable.SetPerson2(person2);
            myMadlibsVariable.SetAnimal(animal);
            myMadlibsVariable.SetExclamation(exclamation);
            myMadlibsVariable.SetVerb(verb);
            myMadlibsVariable.SetNoun(noun);
            return View(myMadlibsVariable);
        }

        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}