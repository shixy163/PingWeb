using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Common;
using Models;

namespace WebSite.Biz
{
    public class ExcelTargetBll : ITargetBll
    {
        public Dictionary<IPAddress, bool> GetTargetIPList()
        {
            Dictionary<IPAddress, bool> list = new Dictionary<IPAddress, bool>();
            string path = System.AppDomain.CurrentDomain.BaseDirectory + ConfigurationManager.AppSettings["IPExcelPath"].ToString();
            DataTable dt = ExcelHelper.ExcelToDatatalbe(path);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                list.Add(new IPAddress() { address = dt.Rows[i]["ip"].ToString(), name = dt.Rows[i]["name"].ToString() }, false);
            }
            return list;
        }
    }
}