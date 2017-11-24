using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Season
    {
        public Season()
        {
            Match = new HashSet<Match>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Match> Match { get; set; }
    }
}
