using Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public string ErrorList()
        {
            return JsonConvert.SerializeObject(new {
                time = PingHelper.checkTime.ToString("yyyy-MM-dd HH:mm:ss")
                ,successCount = PingHelper.successList.Count
                ,list = PingHelper.errorList
                 });
        }

        public string test()
        {
            return MailHelper.SentMail("shixy@pharmadl.com", "测试一个邮件\r\n这是一行内容！", "来自测试的邮件！").ToString();
        }

        
    }
}