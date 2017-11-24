using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class BetType
    {
        public BetType()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Bet> Bet { get; set; }
    }
}
