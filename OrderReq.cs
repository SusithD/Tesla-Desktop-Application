using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace porches
{
    class OrderReq
    {
        public void SendOrderRequestEmail(string buyerEmail, string orderID)
        {
            try
            {
                // Replace "smtp.example.com" with your SMTP server address
                using (SmtpClient smtpClient = new SmtpClient("smtp.gmail.com"))
                {
                    // Replace port number and SSL settings as needed
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;

                    // Replace "your_username" and "your_password" with your email login credentials
                    smtpClient.Credentials = new System.Net.NetworkCredential("teslaorderrequest@gmail.com", "wnfwdmhqiuofrret");

                    using (MailMessage mail = new MailMessage())
                    {
                        // Replace "your_email@example.com" with your email address
                        mail.From = new MailAddress("teslaorderrequest@gmail.com");
                        mail.To.Add(buyerEmail);
                        mail.Subject = "Order Request - Please Wait for Approval";
                        mail.Body = $"Dear Customer,\n\nThank you for placing an order request with Tesla. Please wait until a Tesla Employee approves or disapproves your order. Your decision will take under 7 days.\n\nOrder ID: {orderID}\n\nBest regards,\nTesla Team";

                        smtpClient.Send(mail);
                    }
                }

                MessageBox.Show("Order request email sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending the order request email: " + ex.Message);
            }
        }
    }
}
