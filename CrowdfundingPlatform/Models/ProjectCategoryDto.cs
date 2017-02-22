using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectCategoryDto
    {   [Key]
        public long CategoryId { get; set; }

        public string Name { get; set; }
    }
}