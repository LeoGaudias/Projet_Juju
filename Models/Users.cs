using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Users
    {
        public Users()
        {
            Bet = new HashSet<Bet>();
            Paid = new HashSet<Paid>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsVip { get; set; }

        public ICollection<Bet> Bet { get; set; }
        public ICollection<Paid> Paid { get; set; }
    }
}
