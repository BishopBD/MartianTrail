using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Crew
{
    public class CrewMember
    {
        public string Name { get; set; }
        public DateTime DoB { get; set; }
        public bool IsDead { get; set; }
        public DateTime ToD { get; set; }
        public string ImgPath { get; set; }

        public CrewMember()
        {
            Name = "Joe Smith";
            DoB = Convert.ToDateTime("01/01/1900");
            ImgPath = "/Content/Images/silhouette.png";
            IsDead = false;
        }
    }
}