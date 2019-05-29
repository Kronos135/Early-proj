using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace SysOverview
{
    class logic
    {
        public static string GetComponent(string hwclass, string syntax)
        {

            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            if (mos == null)
                return "-1";
            foreach (ManagementObject item in mos.Get())
            {
                return Convert.ToString(item[syntax]);
            }
            return "";
        }
    }
}
