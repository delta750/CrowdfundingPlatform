using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectUpdateDto
    {
        [Key]
        public long ProjectUpdateId { get; set; }
        public bool IsDeleted { get; set; }
        public long ProjectId { get; set; }
        public Nullable<long> AttachmentId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime WhenDateTime { get; set; }


    }
}