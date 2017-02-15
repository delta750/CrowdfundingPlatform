using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class UserFundingDTO
    {
        public long? Id { get; set; }

        public long FundingPackageId { get; set; }

        public long UserId { get; set; }

        public string Username { get; set; }

        public DateTime WhenDateTime { get; set; }

        public decimal AmountPaid { get; set; }

        public string TransactionId { get; set; }
    }
}