using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveUp.Net.Mail;
using GmailReadImapEmail;
using Message = ActiveUp.Net.Mail.Message;


namespace MailReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var mailRepository = new MailRepository(
                                "imap.gmail.com",
                                993,
                                true,
                                "email",
                                "password"
                            );
            var flags = new FlagCollection { "Seen" };
            var emailList = mailRepository.GetUnreadMails("inbox");
            string content = "";
         
            foreach (Message email in emailList)
            {

                content += " " + " " + email.From +" " + email.Subject + " " + " " + Environment.NewLine + Environment.NewLine;
                mailRepository.Mails.RemoveFlagsSilent(email.Id, flags);

            }

            display.Text = content;

        }

    }
}
