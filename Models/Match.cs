using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Match
    {
        public Match()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public DateTime MatchDate { get; set; }
        public short ScoreTeam1 { get; set; }
        public short ScoreTeam2 { get; set; }
        public float Odds { get; set; }
        public string League { get; set; }
        public int IdTeam { get; set; }
        public int IdTeam1 { get; set; }
        public int IdSeason { get; set; }
        public short? ScoreTeam1Prognosis { get; set; }
        public short? ScoreTeam2Prognosis { get; set; }
        public int IdTeam2 { get; set; }

        public Season IdSeasonNavigation { get; set; }
        public Team IdTeam1Navigation { get; set; }
        public Team IdTeam2Navigation { get; set; }
        public Team IdTeamNavigation { get; set; }
        public ICollection<Bet> Bet { get; set; }
    }
}
