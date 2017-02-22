using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class AttachmentDto
    {
        [Key]
        public long? AttachmentId { get; set; }

        public DateTime? CreatedAt { get; set; }

        public string FilePath { get; set; }

        public string Name { get; set; }

        public string HtmlCode { get; set; }

        public int OrderNo { get; set; }
    }
}