using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Bookmaker
    {
        public Bookmaker()
        {
            Bet = new HashSet<Bet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Img { get; set; }

        public ICollection<Bet> Bet { get; set; }
    }
}
