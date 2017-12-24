using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Juju.Models.AccountViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class ForgotPasswordViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
