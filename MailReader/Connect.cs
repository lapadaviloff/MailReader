using System;
using GmailReadImapEmail;
using ActiveUp.Net.Mail;

namespace MailReader
{
    class Connect
    {
        private MailRepository _mailRepository;
        public Connect(String imap, int port, bool ssl, String login, String password)
        {

            _mailRepository = null;
            try
            {
                _mailRepository = new MailRepository(
                                imap,
                                port,
                                ssl,
                                login,
                                password
                            );

            }
            catch (Exception e)
            {
                FormError err = new FormError();
                err.errorText(e.Message);
                //err.Show();
                //System.Environment.Exit(-1);
                err.ShowDialog();
            }
        }
         
            public String Content() {
             var emailList = _mailRepository.GetUnreadMails("inbox");//выбор входящих непрочитанных сообщений
            string content = "";
             var flags = new FlagCollection { "Seen" };
            foreach (Message email in emailList)
            {

                content += " " + " " + email.From + " " + email.Subject + " " + " " + Environment.NewLine + Environment.NewLine;
                _mailRepository.Mails.RemoveFlagsSilent(email.Id, flags);//снятие флага seen с сообщения

            }

            return content;
            }        
    }
}
