//using System.Net;
//using System.Net.Mail;
//using EmailFeature.Core;

//namespace EmailFeature.Service
//{
//  public class Emailer
//  {
//    public static string EmailFeedbackMessage { get; set; }

//    public string From { get; set; }
//    public string UserName { get; set; }
//    public string To { get; set; }

//    //public string RecipientEmail { get; set; }
//    public string Subject { get; set; }
//    public string Body { get; set; }

//    public void SendEmail()
//    {
//      var message = new MailMessage();

//      message.From = new MailAddress(this.From);

//      message.To.Add(EmailInMemeryConfigData.RecipientEmailOwner);

//      message.Subject = this.Subject;

//      message.Body = this.Body;

//      using(var smtpClient = new SmtpClient())
//      {
//        smtpClient.UseDefaultCredentials = false;

//        smtpClient.Host = EmailInMemeryConfigData.EmailServerHost;

//        smtpClient.Port = EmailInMemeryConfigData.SmtpPort;

//        smtpClient.EnableSsl = EmailInMemeryConfigData.IsSSL;

//        smtpClient.Send(message);
//      }

//      EmailFeedbackMessage = this.GetEmailFeedbackMessage("(Production Mode)");
//    }

//    public void SendEmailDevModeRealDeployed()
//    {
//      var message = new MailMessage();

//      message.From = new MailAddress(this.From);

//      message.To.Add(EmailInMemeryConfigData.RecipientEmailDeveloper);

//      message.Subject = this.Subject;

//      message.Body = this.Body;

//      using(var smtpClient = new SmtpClient())
//      {
//        smtpClient.UseDefaultCredentials = false;

//        smtpClient.Host = EmailInMemeryConfigData.EmailServerHost;

//        smtpClient.Port = EmailInMemeryConfigData.SmtpPort;

//        smtpClient.EnableSsl = EmailInMemeryConfigData.IsSSL;

//        smtpClient.Send(message);
//      }

//      EmailFeedbackMessage = this.GetEmailFeedbackMessage("(Dev Mode Real Deployed)");
//    }

//    public void SendEmailDevModeReal()
//    {
//      var message = new MailMessage();

//      message.From = new MailAddress(this.From);

//      message.To.Add(EmailInMemeryConfigData.RecipientEmailDeveloper);

//      message.Subject = this.Subject;

//      message.Body = this.Body;

//      using(var smtpClient = new SmtpClient())
//      {
//        smtpClient.UseDefaultCredentials = false;

//        smtpClient.Host = EmailInMemeryConfigData.EmailServerHostDevelopment;

//        smtpClient.Port = EmailInMemeryConfigData.SmtpPort;

//        smtpClient.EnableSsl = EmailInMemeryConfigData.IsSSLDevelopment;

//        smtpClient.Credentials = new NetworkCredential(EmailInMemeryConfigData.EmailServerHostAdminUserName, EmailInMemeryConfigData.EmailServerHostAdminPassword);

//        smtpClient.Send(message);
//      }

//      EmailFeedbackMessage = this.GetEmailFeedbackMessage("(Dev Mode Real)");
//    }

//    private string GetEmailFeedbackMessage(string appMode) => $" Success: {appMode} - message sent from {this.From} - {this.Subject} - {this.Body}";

//    public void SendEmailDevModeFake()
//    {
//      EmailFeedbackMessage = this.GetEmailFeedbackMessage("(Dev Mode Fake)");
//    }
//  }
//}
