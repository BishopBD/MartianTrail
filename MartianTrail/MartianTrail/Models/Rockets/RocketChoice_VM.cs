using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Rockets
{
    public class RocketChoice_VM
    {
        public List<Rocket> rockets { get; set; }

        public RocketChoice_VM()
        {
            rockets = new List<Rocket>() {
                new Rocket("SpaceX"),
                new Rocket("Blue Origin"),
                new Rocket("NASA"),
                new Rocket("Foreign")
            };
        }

    }
}