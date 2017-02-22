using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class TransactionResultDto
    {
        public int ErrorCode { get; set; }
        public string ErrorText { get; set; }
        public decimal Amount { get; set; }
        public Guid TransactionId { get; set; }
    }
}