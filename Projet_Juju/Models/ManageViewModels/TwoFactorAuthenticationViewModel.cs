using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Juju.Models.ManageViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class TwoFactorAuthenticationViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public bool HasAuthenticator { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int RecoveryCodesLeft { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Is2faEnabled { get; set; }
    }
}
