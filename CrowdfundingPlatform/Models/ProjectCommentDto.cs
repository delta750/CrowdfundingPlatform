using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectCommentDto
    {
        [Key]
        public long? CommentId { get; set; }

        public long ProjectId { get; set; }

        public string Name { get; set; }

        public long Id { get; set; } //User Asp.net Id

        public long? AttachmentSetId { get; set; }

        public DateTime WhenDateTime { get; set; }

        public string Description { get; set; }
    }
}