using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ViewModels.ManageViewModels
{
    /// <summary>
    /// 
    /// </summary>
    public class RemoveLoginViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string LoginProvider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProviderKey { get; set; }
    }
}
