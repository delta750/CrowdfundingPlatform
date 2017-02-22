using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CrowdfundingPlatform.Models;
using System.Data.Entity;
using CrowdfundingPlatform.Views.ViewModels;

namespace CrowdfundingPlatform.Controllers
{
    public class ProjectModelController : Controller
    {
        private ApplicationDbContext _context;

        public ProjectModelController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: ProjectModel
        public ActionResult NewProjectModel()
        {
            var categoriesofProjects = _context.Categories.ToList();
            var viewModel = new NewProjectViewModel()
            {
                CategoriesDts= categoriesofProjects
            };

           

            return View(viewModel);
        }

       
           public ViewResult Index()
        {
            return View();
        }
    

        // [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")]
        [HttpPost]
        public ActionResult Create(ProjectDTO newproject)
        {
            _context.Project.Add(newproject);
            _context.SaveChanges();
            return RedirectToAction("Index", "ProjectModel");
        }
    }
}