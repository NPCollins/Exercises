using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone.Models
{
    public class Site
    {
        public int Id { get; set; }
        public int CampgroundId { get; set; }
        public int SiteNumber { get; set; }
        public int MaxOccupancy { get; set; }
        public byte Accessible { get; set; }
        public int MaxRvLength { get; set; }
        public byte Utilities { get; set; }

        public override string ToString()
        {
            string maxOcc = ChangeToNA(MaxOccupancy);
            string acc = ChangeToNA(Accessible);
            string maxRV = ChangeToNA(MaxRvLength);
            string util = ChangeIntToYesOrNo(Utilities);

            return SiteNumber.ToString().PadRight(15) + maxOcc.ToString().PadRight(15) + acc.ToString().PadRight(15) + maxRV.ToString().PadRight(15) + util.ToString();
        }

        public string ChangeToNA(int zerovalue)
        {
            string NA = "";

            if(zerovalue == 0)
            {
                NA = "N/A";
                return NA;
            }
            return NA;
        }
        public string ChangeIntToYesOrNo(int value)
        {
            string NA = "";

            if (value == 0)
            {
                NA = "No";
                return NA;
            }
            if (value == 1)
            {
                NA = "YES";
                return NA;
            }
            return NA;
        }

    }
}
