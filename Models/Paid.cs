using System;
using System.Collections.Generic;

namespace Projet_Juju.Models
{
    public partial class Paid
    {
        public int Id { get; set; }
        public int IdPayment { get; set; }
        public int IdSignUpPrice { get; set; }

        public Users IdNavigation { get; set; }
        public Payment IdPaymentNavigation { get; set; }
        public SignUpPrice IdSignUpPriceNavigation { get; set; }
    }
}
