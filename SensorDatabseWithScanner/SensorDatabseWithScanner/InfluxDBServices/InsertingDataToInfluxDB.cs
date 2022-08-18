using Common;
using Common.Modeles;
using SensorDatabseWithScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.InfluxDBServices
{
    public class InsertingDataToInfluxDB
    {
        public static void InsertSensorToInfluxDB(List<SensorModel> list)
        {
            string DatabaseName = NameOfUseDatabase.GetDatabaseName();
            foreach(var val in list)
            {
                LinuxCommand.InfluxCommandVoid($"INSERT INTO {DatabaseName}.autogen {val.Mac},SerialNumber={val.SerialNumber}");
            }
        }
        public static void InsertSensorInfoToInfluxDB(List<ModelOfSensorInformations> list)
        {
            string DatabaseName = NameOfUseDatabase.GetDatabaseName();
            foreach (var val in list)
            {
                string output = val.MainInfo;
                foreach (var tmp in val.Informations)
                    output += "," + tmp;
                LinuxCommand.InfluxCommandVoid($"INSERT INTO {DatabaseName}.autogen {val.MAC},Info={output}");
            }
        }
    }
}
