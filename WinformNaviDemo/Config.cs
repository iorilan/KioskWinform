using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformNaviDemo
{
   public static class Config
    {
        public static string SettingFile()
        {
            return ConfigurationManager.AppSettings["SettingFile"];
        }
    }
}
