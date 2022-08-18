using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.InfluxDBServices
{
    public class InfluxDBCommands
    {
        public void CreateDB(string nameOfDB)
        {
            Console.WriteLine(LinuxCommand.InfluxCommand($"CREATE DATABASE{nameOfDB}"));
        }
        public void UseDB(string nameOfDB)
        {
            NameOfUseDatabase.SetDatabaseName(nameOfDB);
        }
        public void ShowDB()
        {
            Console.WriteLine(LinuxCommand.InfluxCommand("SHOW databases"));
        }
        public void ShowMeasurments()
        {
            string DatabaseName = NameOfUseDatabase.GetDatabaseName();
            Console.WriteLine(LinuxCommand.InfluxCommand($"SHOW measurements on {DatabaseName}"));
        }
        public void ShowSensorInfo(string mac)
        {
            string DatabaseName = NameOfUseDatabase.GetDatabaseName();
            Console.WriteLine(LinuxCommand.InfluxCommand($"SELECT * FROM {DatabaseName}.autogen.{mac}"));
        }
    }
}
