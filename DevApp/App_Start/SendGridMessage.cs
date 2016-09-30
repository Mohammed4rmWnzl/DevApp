using System;
using System.Net.Mail;

namespace DevApp
{
    internal class SendGridMessage
    {
        internal MailAddress From;

        public SendGridMessage()
        {
        }

        public string Html { get; internal set; }
        public string Subject { get; internal set; }
        public string Text { get; internal set; }

        internal void AddTo(string destination)
        {
            throw new NotImplementedException();
        }
    }
}