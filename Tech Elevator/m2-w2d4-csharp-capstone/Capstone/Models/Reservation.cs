using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int SiteId { get; set; }
        public string Name { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreateDate { get; set; }
        

        public override string ToString()
        {
            return Id.ToString().PadRight(15) + SiteId.ToString().PadRight(15) + Name.PadRight(15) + FromDate.ToShortDateString().PadRight(15) + ToDate.ToShortDateString().PadRight(15) + CreateDate.ToString().PadRight(15);
        }
    }
}
