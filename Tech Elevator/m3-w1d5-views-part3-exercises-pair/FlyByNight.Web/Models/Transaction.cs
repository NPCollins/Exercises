using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FlyByNight.Web.Models
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public DollarAmount Amount { get; set; }
        public string Description { get; set; }
    }
}