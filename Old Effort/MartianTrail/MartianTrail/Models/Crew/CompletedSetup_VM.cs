using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianTrail.Models.Crew
{
    public class CompletedSetup_VM
    {
        public CrewMember Pilot{ get; set; }
        public CrewMember DeckHand1 { get; set; }
        public CrewMember DeckHand2 { get; set; }
        public string RocketType { get; set; }

        public CompletedSetup_VM(CrewMember pilot, CrewMember deckHand1, CrewMember deckhand2, string rocket)
        {
            Pilot = pilot;
            DeckHand1 = deckHand1;
            DeckHand2 = deckhand2;
            RocketType = rocket;
        }
        public CompletedSetup_VM()
        {

        }
    }
}