﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrowdfundingPlatform.Models
{
    public class UserFundingDTO
    {
        [Key]
        public long? UserFundingId { get; set; }

        public long FundingPackageId { get; set; }

        public long Id { get; set; } //User Asp.net Id

        public string Username { get; set; }

        public DateTime WhenDateTime { get; set; }

        public decimal AmountPaid { get; set; }

        public string TransactionId { get; set; }
    }
}