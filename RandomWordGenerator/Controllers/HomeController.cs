using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RandomWordGenerator.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {

            // Part 1
            List<string> partOne = new List<string>(); // I lost because...
            partOne.Add("They only won because");
            partOne.Add("I only lost because");
            //partOne.Add("");
                        
            // Part 2
            List<string> partTwo = new List<string>();
            partTwo.Add("Leffen was");
            partTwo.Add("Project M is");
            partTwo.Add("my skills were");
            partTwo.Add("their controller was");
            partTwo.Add("the commentators were");
            partTwo.Add("Madigascar was");
            partTwo.Add("I was");
            partTwo.Add("my mothers basement is");
            partTwo.Add("my mother is ");
            partTwo.Add("Nintendo was");
            partTwo.Add("Sakurai was");
            partTwo.Add("the crowd was");
            partTwo.Add("the TOs were");
            partTwo.Add("Jigglypuff was");
            partTwo.Add("my foot is");
            partTwo.Add("the venue is");
            partTwo.Add("my opponent was");
            partTwo.Add("ChuDat was");
            partTwo.Add("MetaKnight is");
            partTwo.Add("the USA is");
            partTwo.Add("my eyes are");
            partTwo.Add("Roy's wavedash is");
            partTwo.Add("the sun was");
            partTwo.Add("my dog was");
            partTwo.Add("");
            partTwo.Add("");
            //partTwo.Add("");          

            // Part 3
            List<string> partThree = new List<string>();
            partThree.Add("my B.");
            partThree.Add("really annoying.");
            partThree.Add("wobbling.");
            partThree.Add("cheating.");
            partThree.Add("rolling.");
            partThree.Add("Reggie Fils-Aime.");
            partThree.Add("really annoying.");
            partThree.Add("pausing mid-match.");
            partThree.Add("laggy.");
            partThree.Add("tangling my controller cable.");
            partThree.Add("really hard to remember.");
            partThree.Add("way better than my character.");
            partThree.Add("unnecessarilly bloodthirsty.");
            partThree.Add("ravenously hungry.");
            partThree.Add("sitting slightly closer to the screen.");
            partThree.Add("hacked.");
            partThree.Add("overpowered.");
            partThree.Add("too hard to reach.");
            partThree.Add("using motion controlls.");
            partThree.Add("sleeping.");
            partThree.Add("ethically superior to me.");
            partThree.Add("broken.");
            partThree.Add("playing Sheik.");
            partThree.Add("making excuses.");
            partThree.Add("too rad.");
            partThree.Add("my controller.");
            partThree.Add("in my eyes.");
            partThree.Add("");
            partThree.Add("");
            //partThree.Add("");

            Random rnd = new Random();
            int num1 = rnd.Next(0, partOne.Count);
            int num2 = rnd.Next(0, partTwo.Count);
            int num3 = rnd.Next(0, partThree.Count);            

            string conCat = partOne.ElementAt(num1) + " " + partTwo.ElementAt(num2) + " " + partThree.ElementAt(num3);
            ViewBag.thing = conCat;

            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}