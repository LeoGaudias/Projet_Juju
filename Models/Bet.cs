using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Bet
    {
        public int Id { get; set; }
        public float? Bet1 { get; set; }
        public float? Profit { get; set; }
        public float? Benefit { get; set; }
        public bool? Win { get; set; }
        public DateTime BetDate { get; set; }
        public string Description { get; set; }
        public int IdUser { get; set; }
        public int IdMatch { get; set; }
        public int? IdBetType { get; set; }
        public int IdBookmaker { get; set; }
        public short? ScoreTeam1 { get; set; }
        public short? ScoreTeam2 { get; set; }
        public int IdTeam { get; set; }

        public BetType IdBetTypeNavigation { get; set; }
        public Bookmaker IdBookmakerNavigation { get; set; }
        public Match IdMatchNavigation { get; set; }
        public Team IdTeamNavigation { get; set; }
        public Users IdUserNavigation { get; set; }
    }
}
