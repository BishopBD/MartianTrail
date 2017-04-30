using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Rockets
{
    public class Rocket
    {
        public string name { get; set; }
        public Rocket(string name)
        {
            this.name = name;
        }
    }
}