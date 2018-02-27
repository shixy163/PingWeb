using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class IPAddress
    {
        public string address { get; set; }
        public string name { get; set; }
        public string replyAddress { get; set; }
        public long roundtripTime { get; set; }
        public IPStatus status { get; set; }
    }
}
