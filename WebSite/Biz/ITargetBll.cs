﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSite.Biz
{
    interface ITargetBll
    {
        Dictionary<IPAddress, bool> GetTargetIPList();
    }
}
