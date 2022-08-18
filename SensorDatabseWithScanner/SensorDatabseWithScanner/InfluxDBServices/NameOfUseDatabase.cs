using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.InfluxDBServices
{
    static class NameOfUseDatabase
    {
        static string DatabaseName;
        static NameOfUseDatabase()
        {
            DatabaseName = "";
        }
        public static void SetDatabaseName(string name)
        {
            DatabaseName = name;
        }
        public static string GetDatabaseName()
        {
            return DatabaseName;
        }
    }
}
