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
            
            this.StartPosition = FormStartPosition.Manual;

            var wArea = Screen.PrimaryScreen.WorkingArea;
            this.Left = wArea.Width + wArea.Left - this.Width;
            this.Top = wArea.Height + wArea.Top - this.Height;
            
            var mailRepository = new MailRepository(
                                "imap.gmail.com",
                                993,
                                true,
                                "miam.devsoft@gmail.com",
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
