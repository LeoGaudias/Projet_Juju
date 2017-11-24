using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class SignUpPrice
    {
        public SignUpPrice()
        {
            Paid = new HashSet<Paid>();
        }

        public int Id { get; set; }
        public float Amount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Paid> Paid { get; set; }
    }
}
