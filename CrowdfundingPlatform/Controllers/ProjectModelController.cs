using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrowdfundingPlatform.Models;

namespace CrowdfundingPlatform.Controllers
{
    public class ProjectModelController : Controller
    {
        // GET: ProjectModel
        public ActionResult ProjectModel()
        {
            var newproject = new ProjectModelDTO()
            {

                
            };

            return View(newproject);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        public ActionResult Action()
        {
            return View();
        }
    }
}