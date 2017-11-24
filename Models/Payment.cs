using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Payment
    {
        public Payment()
        {
            Paid = new HashSet<Paid>();
        }

        public int Id { get; set; }
        public DateTime PaymentDate { get; set; }

        public ICollection<Paid> Paid { get; set; }
    }
}
