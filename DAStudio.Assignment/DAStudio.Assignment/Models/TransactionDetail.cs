﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAStudio.Assignment.Models
{

    public class TransactionDetail
    {
        [JsonProperty("createdAt")]
        public int CreatedAt { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("bank_name")]
        public string BankName { get; set; }

        [JsonProperty("transfer_type")]
        public string TransferType { get; set; }

        [JsonProperty("receiving_amount")]
        public int ReceivingAmount { get; set; }

        [JsonProperty("status")]
        public bool Status { get; set; }

        [JsonProperty("reference_number")]
        public string ReferenceNumber { get; set; }

        [JsonProperty("cf_number")]
        public string CfNumber { get; set; }

        [JsonProperty("payout_location")]
        public string PayoutLocation { get; set; }

        [JsonProperty("account_number")]
        public string AccountNumber { get; set; }

        [JsonProperty("paid_amount")]
        public int PaidAmount { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        public DateTime CreatedAtDateTime
        {
            get
            {
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                return epoch.Add(TimeSpan.FromSeconds(CreatedAt)).ToLocalTime();
            }
        }
    }

}
