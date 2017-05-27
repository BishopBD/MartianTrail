using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Rockets
{
    public class RocketChoice_VM
    {
        public List<Rocket> Rockets { get; set; }

        public RocketChoice_VM()
        {
            Rockets = new List<Rocket>() {
                new Rocket("SpaceX"),
                new Rocket("Blue Origin"),
                new Rocket("NASA"),
                new Rocket("Foreign")
            };
        }

    }
}