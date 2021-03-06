﻿using Bab_1.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bab_1.GUI
{
    class DBGUIHandler
    {

        public static string GetConnectionStatus()
        {
            if (DBHandler.CreateDatabaseConnection())
            {
                return "Connected to Database";
            }
            else
            {
                return "Connection to Database failed Try to reconecting...";
            }
        }

        public static bool LoginDataCorrect(String username, String password)
        {
            DBHandler.checkLogin(username, password);
            return true;
        }
    }
}