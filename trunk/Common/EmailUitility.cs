using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;
namespace Com.Todex.OA.Common
{
    public class EmailUitility
    {
        /// <summary>
        /// 所有参数来自Web配置文件AppSettings,如果未配置相关参数，则会报错。参数包括Account(邮箱帐号),
        /// Password(邮箱密码),Smtp(邮件服务器地址),FromAddress(用于发送邮件的邮箱地址)
        /// </summary>
        public EmailUitility()
        {
            toAddress = new HashSet<string>();
            Account = ConfigurationManager.AppSettings["Account"];
            Password=ConfigurationManager.AppSettings["Password"];
            Smtp=ConfigurationManager.AppSettings["Smtp"];
            FromAddress = ConfigurationManager.AppSettings["FromAddress"];
        }

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="EAccount">邮箱帐号</param>
        /// <param name="EPassword">邮箱密码</param>
        /// <param name="ESmtp">邮箱Smtp服务器地址</param>
        /// <param name="EFromAddress">用于发送邮件的邮箱地址</param>
        public EmailUitility(string EAccount,string EPassword,string ESmtp,string EFromAddress)
        {
            toAddress = new HashSet<string>();
            Account = EAccount;
            Password = EPassword;
            Smtp = ESmtp;
            FromAddress = EFromAddress;
        }
        public string Smtp { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string FromAddress { get; set; }

        private HashSet<string> toAddress;

        private HashSet<string> ToAddress
        {
            get { return toAddress; }
            set { toAddress = value; }
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public void Add(string EmailAddress)
        {
            toAddress.Add(EmailAddress);
        }


        private string getAddressCollection()
        {
            string addressCollection = "";
            foreach (object address in toAddress)
            {
                addressCollection += (string)address + ",";
            }
            if (addressCollection != "")
                addressCollection = addressCollection.Substring(0, addressCollection.Length - 1);
            return addressCollection;
        }

        public void SendEmail()
        {
            MailMessage mm = new MailMessage();

            mm.Body = Content;

            mm.BodyEncoding = System.Text.Encoding.UTF8;
            mm.From = new MailAddress(FromAddress);
            mm.IsBodyHtml = true;

            mm.Subject = Title;
            mm.SubjectEncoding = System.Text.Encoding.UTF8;
            mm.To.Add(getAddressCollection());
            mm.Sender = new MailAddress(FromAddress);

            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Host = Smtp;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(Account, Password);
            client.Send(mm);


        }
    }
}
