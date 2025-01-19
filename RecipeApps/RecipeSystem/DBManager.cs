﻿using CPUFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeSystem
{
    public class DBManager
    {
        public static void SetConnectionString(String connectionstring, bool tryopen, string userid = "", string password = "")
        {
            SqlUtility.SetConnectionString(connectionstring, tryopen, userid, password);
        }
    }
}
