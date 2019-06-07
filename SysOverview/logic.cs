using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.IO;

namespace SysOverview
{
    class Logic
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
        public static string GetPhysicalMemory()
        {
            ManagementScope oMs = new ManagementScope();
            ObjectQuery oQuery = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            // In case more than one Memory sticks are installed
            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + "MB";
        }

        public static void Writer(StringBuilder str)
        {
   
           string path =  @"C:\SysInfo\SysInfo.txt";

           StreamWriter sw = new StreamWriter(path, false);
           sw.Write(str);
           sw.Close();

            
        }
    }

}
