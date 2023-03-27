using ARKanyFryzjerstwa.Data;
using ARKanyFryzjerstwa.Resources;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;
using System.Text;

namespace ARKanyFryzjerstwa.Services
{
    public static class MailService
    {
        /// <summary>
        /// Wysyła maila na określony adres email.
        /// </summary>
        /// <param name="to">Adres odbiorcy.</param>
        /// <param name="subject">Temat.</param>
        /// <param name="body">Wiadomość.</param>
        public static void Send(string to, string subject, string body) => Send(new List<string>() { to }, null, null, subject, body);

        /// <summary>
        /// Wysyła maila do pracownika o utworzeniu mu konta.
        /// </summary>
        /// <param name="user">Pracownik salonu</param>
        /// <param name="password">Hasło do konta</param>
        public static void SendCreationEmployeeAccountMailBody(User user, string appUrl, string resetPswdUrl)
        {
            var body = string.Format(ARKanyResources.CreationEmployeeAccountMailBody,
                user.FirstName, user.LastName, appUrl, 
                user.Email, user.UserName, resetPswdUrl);
            Send(user.Email, ARKanyResources.CreationEmployeeAccountMailSubject, body);
        }

        /// <summary>
        /// Wysyła maila z kodem weryfikacyjnym potrzebnym do zresetowania hasła.
        /// </summary>
        /// <param name="user">Użytkownik</param>
        /// <param name="code">Kod weryfikacyjny</param>
        /// <param name="expirationDate">Data ważności kodu</param>
        /// <param name="url">Adres url prowadzący do strony resetu hasła</param>
        public static void SendResetPasswordVerificationCodeMail(User user, string code, DateTime expirationDate, string url)
        {
            var body = string.Format(ARKanyResources.ResetPasswordVerificationCodeMailBody,
                user.FirstName, user.LastName, code, expirationDate.ToString("g"), url);
            Send(user.Email, ARKanyResources.ResetPasswordVerificationCodeMailSubject, body);
        }

        /// <summary>
        /// Wysyła maila.
        /// </summary>
        /// <param name="to"> Odbiorca.</param>
        /// <param name="cc"> Dodatkowi odbiorcy.</param>
        /// <param name="bcc"> Dodatkowi tajni odbiorcy.</param>
        /// <param name="subject"> Temat.</param>
        /// <param name="body"> Zawartośc maila.</param>
        private static void Send(IList<string> to, IList<string>? cc, IList<string>? bcc, string subject, string body)
        {
            var mail = new MimeMessage();
            mail.From.Add(MailboxAddress.Parse(Program.MailSettings.Mail));
            if(Program.Environment.IsDevelopment())
            {
                mail.To.Add(Program.AppMail);

                var stringBuilder = new StringBuilder();
                stringBuilder.Append(body);
                stringBuilder.Append("<hr><b>Do</b>: ");
                stringBuilder.AppendJoin("; ", to);
                if (cc != null && cc.Any())
                {
                    stringBuilder.Append("<br><b>Dw</b>: ");
                    stringBuilder.AppendJoin("; ", cc);
                }
                if (bcc != null && bcc.Any())
                {
                    stringBuilder.Append("<br><b>Udw</b>: ");
                    stringBuilder.AppendJoin("; ", bcc);
                }

                mail.Subject = $"[DEV] {subject}";
                mail.Body = new TextPart(TextFormat.Html) { Text = stringBuilder.ToString() };
            }
            else
            {
                mail.To.AddRange(to.Select(a => MailboxAddress.Parse(a)));
                if(cc != null && cc.Any())
                {
                    mail.Cc.AddRange(cc.Select(a => MailboxAddress.Parse(a)));
                }
                if (bcc != null && bcc.Any())
                {
                    mail.Bcc.AddRange(bcc.Select(a => MailboxAddress.Parse(a)));
                }
                mail.Subject = subject;
                mail.Body = new TextPart(TextFormat.Html) { Text = body };
            }

            Send(mail);
        }

        /// <summary>
        /// Wysyła maila.
        /// </summary>
        /// <param name="mail"> Mail do wysłania.</param>
        private static void Send(MimeMessage mail)
        {
            var settings = Program.MailSettings;

            using var smtp = new SmtpClient();
            smtp.Connect(settings.Host, settings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(settings.Mail, settings.Password);
            smtp.Send(mail);
            smtp.Disconnect(true);
        }
    }
}
