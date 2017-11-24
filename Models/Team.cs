using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Team
    {
        public Team()
        {
            Bet = new HashSet<Bet>();
            MatchIdTeam1Navigation = new HashSet<Match>();
            MatchIdTeam2Navigation = new HashSet<Match>();
            MatchIdTeamNavigation = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string Trigram { get; set; }

        public ICollection<Bet> Bet { get; set; }
        public ICollection<Match> MatchIdTeam1Navigation { get; set; }
        public ICollection<Match> MatchIdTeam2Navigation { get; set; }
        public ICollection<Match> MatchIdTeamNavigation { get; set; }
    }
}
