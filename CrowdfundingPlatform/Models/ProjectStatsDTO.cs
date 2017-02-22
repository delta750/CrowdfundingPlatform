using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectStatsDto
    {
        [Key]
        public long? ProjectStatsId { get; set; }

        public long ProjectId { get; set; }

        public long BackersNo { get; set; }

        public decimal MoneyPledged { get; set; }

        public int SharesNo { get; set; }

        public int CommentsNo { get; set; }
    }
}