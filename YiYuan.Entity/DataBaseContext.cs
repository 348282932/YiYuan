﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YiYuan.Entity
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext()
            : base("YiYuanConnection")
        {
        }
    }
}
