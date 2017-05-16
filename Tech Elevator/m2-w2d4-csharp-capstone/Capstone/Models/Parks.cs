using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Parks
    {
        public int Id { get; set; }
        public int CampgroundId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int Area { get; set; }
        public int Visitors { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return Id.ToString().PadRight(5) + Name.PadRight(20) + Location.PadRight(7) + EstablishmentDate.ToShortDateString().PadRight(7) + Area.ToString().PadRight(7) + Visitors.ToString().PadRight(10) + Description.PadRight(10).PadLeft(10);
        }



    }
}
