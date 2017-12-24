using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projet_Juju.Services
{
    /// <summary>
    /// 
    /// </summary>
    public class EmailSender : IEmailSender
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="email"></param>
        /// <param name="subject"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        public Task SendEmailAsync(string email, string subject, string message)
        {
            return Task.CompletedTask;
        }
    }
}
