using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class MailHelper
    {
        /// <summary>  
        /// 发送邮件,成功返回true,否则false  
        /// </summary>  
        /// <param name="to">收件人</param>  
        /// <param name="body">内容</param>  
        /// <param name="title">标题</param>  
        /// <returns>结果</returns>  
        public static bool SentMail(string to, string body, string title)
        {
            var emailAcount = ConfigurationManager.AppSettings["EMailAddress"].ToString();
            var emailPassword = ConfigurationManager.AppSettings["EMailPWD"].ToString();
            var reciver = to;
            var content = body;
            try
            {
                MailMessage message = new MailMessage();
                //设置发件人,发件人需要与设置的邮件发送服务器的邮箱一致
                MailAddress fromAddr = new MailAddress(emailAcount);
                message.From = fromAddr;
                //设置收件人,可添加多个,添加方法与下面的一样
                message.To.Add(reciver);
                //设置抄送人
                //message.CC.Add("qwe123@163.com");
                //设置邮件标题
                message.Subject = title;
                //设置邮件内容
                message.Body = content;
                //设置邮件发送服务器,服务器根据你使用的邮箱而不同,可以到相应的 邮箱管理后台查看,下面是QQ的
                SmtpClient client = new SmtpClient("smtp.qq.com", 25);
                //设置发送人的邮箱账号和密码
                client.Credentials = new NetworkCredential(emailAcount, emailPassword);
                //启用ssl,也就是安全发送
                client.EnableSsl = true;
                //发送邮件
                client.Send(message);
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                return false;
            }
            
            return true;
        }
    }
}
