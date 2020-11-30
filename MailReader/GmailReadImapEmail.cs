using ActiveUp.Net.Mail;
using System.Collections.Generic;
using System.Linq;

namespace GmailReadImapEmail
{
    public class MailRepository
    {
        private Imap4Client client;
        private Mailbox mails;

        public MailRepository(string mailServer, int port, bool ssl, string login, string password)
        {
            if (ssl)
                Client.ConnectSsl(mailServer, port);
            else
                Client.Connect(mailServer, port);
            Client.Login(login, password);
        }

        public IEnumerable<Message> GetAllMails(string mailBox)
        {
            return GetMails(mailBox, "ALL");
        }

        public IEnumerable<Message> GetUnreadMails(string mailBox)
        {
            return GetMails(mailBox, "UNSEEN");
        }

        protected Imap4Client Client
        {
            get { return client ?? (client = new Imap4Client()); }
        }
        public Mailbox Mails
        {
            get
            {
                return mails;
            }

            set { mails = value; }
        }

        private IEnumerable<Message> GetMails(string mailBox, string searchPhrase)
        {
            int count = 1;
             mails = Client.SelectMailbox(mailBox);
            var Messages = mails.SearchParse(searchPhrase).Cast<Message>();
            var messagesAll = mails.SearchParse("ALL").Cast<Message>();
           
            foreach (Message Email in Messages) {
                foreach (Message EmailAll in messagesAll) {
                    if (EmailAll.MessageId == Email.MessageId) Email.Id = count;
                    count++;
                }
                count = 1;
            }


                return Messages;
        }
    }
}