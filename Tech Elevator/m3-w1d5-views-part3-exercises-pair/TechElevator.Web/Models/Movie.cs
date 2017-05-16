using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TechElevator.Web.Models
{
    public class Movie
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public string Description { get; set; }
        public int RunningTime { get; set; }
        public int YearReleased { get; set; }

        public List<ShowTime> ShowTimes { get; set; } = new List<ShowTime>();
        public List<string> Cast { get; set; } = new List<string>();
    }
}