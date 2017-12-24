﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Projet_Juju.Services;

namespace Projet_Juju.Services
{
    /// <summary>
    /// 
    /// </summary>
    public static class EmailSenderExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailSender"></param>
        /// <param name="email"></param>
        /// <param name="link"></param>
        /// <returns></returns>
        public static Task SendEmailConfirmationAsync(this IEmailSender emailSender, string email, string link)
        {
            return emailSender.SendEmailAsync(email, "Confirm your email",
                $"Please confirm your account by clicking this link: <a href='{HtmlEncoder.Default.Encode(link)}'>link</a>");
        }
    }
}
