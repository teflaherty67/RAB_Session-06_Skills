using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace RAB_Session_06_Skills
{
    internal static class Utils
    {
        internal static string GetAssemblyName()
        {
            string assemblyName = Assembly.GetExecutingAssembly().Location;
            return assemblyName;
        }        
    }
}
