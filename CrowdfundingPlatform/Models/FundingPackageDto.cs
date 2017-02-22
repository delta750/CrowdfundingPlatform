using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class FundingPackageDto
    {
        [Key]
        public long? FundingPackageId { get; set; }

        public long ProjectId { get; set; }

        public long? AttachmentId { get; set; }

        public string Title { get; set; }

        public decimal? PledgeAmount { get; set; }

        public string Description { get; set; }

        public DateTime WhenDateTime { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }
    }
}