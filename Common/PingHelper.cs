using Models;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Common
{
    public class PingHelper
    {
        /// <summary>
        /// 需要检查的ip地址列表
        /// </summary>
        public static Dictionary<IPAddress, bool> ipTable { get; set; }
        /// <summary>
        /// 发现无法连接的错误列表
        /// </summary>
        public static BlockingCollection<IPAddress> errorList = new BlockingCollection<IPAddress>();
        public static BlockingCollection<IPAddress> successList = new BlockingCollection<IPAddress>();
        /// <summary>
        /// 检查时间
        /// </summary>
        public static DateTime checkTime { get; set; }

        

        
        public static void ping()
        {
            checkTime = DateTime.Now;
            errorList = new BlockingCollection<IPAddress>();
            successList = new BlockingCollection<IPAddress>();
            foreach (IPAddress ip in ipTable.Keys)
            {
                ping(ip, 100);
            }
        }

        public static bool ping(IPAddress ip, int timeout)
        {
            Ping p = new Ping();
            p.PingCompleted += P_PingCompleted;
            p.SendAsync(ip.address, timeout, ip);
            return true;
        }

        private static void P_PingCompleted(object sender, PingCompletedEventArgs e)
        {
            PingReply reply = e.Reply;
            IPAddress ip = e.UserState as IPAddress;
            ip.replyAddress = e.Reply.Address.ToString();
            ip.roundtripTime = e.Reply.RoundtripTime;
            ip.status = e.Reply.Status;
            if (reply.Status != IPStatus.Success)
            {
                errorList.Add(ip);
            }
            else
            {
                successList.Add(ip);
            }
        }

        /// <summary>
        /// 针对错误列表，再测试一次
        /// </summary>
        public static void Reping()
        {
            if (errorList != null && errorList.Count > 0)
            {
                BlockingCollection<IPAddress> repingList = errorList;
                errorList = new BlockingCollection<IPAddress>();
                foreach (IPAddress ip in repingList)
                {
                    ping(ip, 100);
                }
            }
            
        }
    }
}
