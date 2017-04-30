using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Rockets
{
    public class Rocket
    {
        public string Name { get; set; }

        public Rocket(string name)
        {
            this.Name = name;
        }
    }
}