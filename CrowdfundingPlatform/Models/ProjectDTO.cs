using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectDTO
    {
        [Key]
        public long? ProjectId { get; set; }

        public long Id { get; set; } //User Asp.net Id

        public long CategoryId { get; set; }
        [Display(Name= "Category")]
        public string ProjectCategoryDesc { get; set; }

        public long? AttachmentId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public DateTime FundingEndDate { get; set; }

        public decimal FundingGoal { get; set; }

        public string Status { get; set; }

        public string OwnerName { get; set; }

        public long? OwnerId { get; set; }

        public string MainPhoto { get; set; }
       
        
 
    }
}