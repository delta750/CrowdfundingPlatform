using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class ProjectStatsDTO
    {
        public long? Id { get; set; }

        public long ProjectId { get; set; }

        public long BackersNo { get; set; }

        public decimal MoneyPledged { get; set; }

        public int SharesNo { get; set; }

        public int CommentsNo { get; set; }
    }
}