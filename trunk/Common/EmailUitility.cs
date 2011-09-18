using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Mail;
using System.Configuration;
namespace Common
{
    public class EmailUitility
    {
        /// <summary>
        /// 所有参数来自Web配置文件AppSettings,如果未配置相关参数，则会报错。参数包括Account(邮箱帐号),
        /// Password(邮箱密码),Smtp(邮件服务器地址),FromAddress(用于发送邮件的邮箱地址)
        /// </summary>
        public EmailUitility()
        {

            Account =  Common.Constant.WebConfig("EAccount");
            Password= Common.Constant.WebConfig("EPassword");
            Smtp= Common.Constant.WebConfig("ESmtp");
            FromAddress = Common.Constant.WebConfig("EFromAddress");
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
           
            Account = EAccount;
            Password = EPassword;
            Smtp = ESmtp;
            FromAddress = EFromAddress;
        }
        public string Smtp { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string FromAddress { get; set; }

        private HashSet<string> _ToAddress=new HashSet<string>();

        public string Title { get; set; }

        public string Content { get; set; }

        public void AddEmailAddress(string EmailAddress)
        {
            foreach (string s in EmailAddress.Split(';'))
            {
                _ToAddress.Add(s);
            }
        }


        private string getAddressCollection()
        {
            string addressCollection = "";
            foreach (object address in _ToAddress)
            {
                addressCollection += (string)address + ",";
            }
            return addressCollection.TrimEnd(',');
        }

        private int _Port = 587;
        public int Port { get { return _Port; } set { _Port = value; } }
        private bool _Ssl = true;
        public bool Ssl { get { return _Ssl; } set { _Ssl = value; } }

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
            client.Port = _Port;
            client.EnableSsl = _Ssl;
            client.UseDefaultCredentials = true;
            client.Credentials = new System.Net.NetworkCredential(Account, Password);
            client.Send(mm);
        }
    }

}
