using Common;
using Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Threading;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool isSend = MailHelper.SentMail("shixy@pharmadl.com","测试一个邮件\r\n这是一行内容！","来自测试的邮件！");
            //Console.WriteLine(isSend);
   //         string str = "";
   //         string jsonFormat = "{"
			//+"\"Name\": \"{0}\","
   //         + "\"Addr\": \"{1}\","
   //         + "\"Type\": \"C\","
   //         + "\"Thdchecksec\": 900,"
   //         + "\"Thdoccnum\": 3,"
   //         + "\"Thdavgdelay\": 200,"
			//+ "\"Thdloss\": 30"
   //         + "},";
   //         int ipd = 0;
   //         int ipc = 0;
   //         for (int i = 0; i < 3000; i++)
   //         {
   //             string ipStr = string.Format("192.168.{0}.{1}", ipc, ipd);
   //             str = str + jsonFormat.Replace("{0}", ipStr).Replace("{1}", "name" + i) + "\r\n";
   //             if (ipd == 255)
   //             {
   //                 ipc++;
   //                 ipd = 0;
   //             }
   //             else
   //             {
   //                 ipd++;
   //             }
   //         }
   //         Debug.WriteLine(str);
            //PingHelper.ipTable = new Dictionary<IPAddress, bool>();
            //int ipd = 0;
            //int ipc = 0;
            //for (int i = 0; i < 3000; i++)
            //{
            //    string ipStr = string.Format("192.168.{0}.{1}",ipc,ipd);

            //    if (ipd == 255)
            //    {
            //        ipc++;
            //        ipd = 0;
            //    }
            //    else
            //    {
            //        ipd++;
            //    }
            //    PingHelper.ipTable.Add(new IPAddress() { address = ipStr, name = "ipAddress" + i },false);

            //}

            //PingHelper ph = new PingHelper();
            //while (true)
            //{
            //    string time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //    Console.WriteLine(time + "开始检测");
            //    PingHelper.ping();
            //    Thread.Sleep(1000 * 60);
            //    Console.Clear();
            //    Console.WriteLine("总计" + PingHelper.errorList.Count + "条未ping通；");
            //    //foreach (var ip in PingHelper.errorList)
            //    //{
            //    //    Console.WriteLine(time + "：" + ip.address + "|" + ip.name + "未联通");
            //    //}
            //    Thread.Sleep(1000 * 60 * 5);

            //}


            Console.ReadLine();
            
        }
    }
}
