using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNight.Web.Models
{

    public class BankAccount
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string AccountType { get; set; }
        public string AccountNickname { get; set; }
        public DollarAmount Balance { get; set; }
        public List<Transaction> Transactions { get; set; } = new List<Transaction>();
    }
}