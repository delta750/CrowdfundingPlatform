using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrowdfundingPlatform.Models;

namespace CrowdfundingPlatform.Views.ViewModels
{
    public class NewProjectViewModel
    {
        public IEnumerable<ProjectCategoryDto> CategoriesDts  { get; set; }
        public ProjectDTO ProjectDTO { get; set; }
    }
}