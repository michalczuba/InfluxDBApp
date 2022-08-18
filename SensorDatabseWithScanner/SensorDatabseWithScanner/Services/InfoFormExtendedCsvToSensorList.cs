using Common;
using SensorDatabseWithScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.Services
{
    public class InfoFormExtendedCsvToSensorList
    {
        public static List<ModelOfSensorInformations> ReadExtendedSensorsInfoFromCsv(string fullPath,string Info)
        {
            var sensorList = new List<ModelOfSensorInformations>();
            using (var reader = new StreamReader(fullPath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var splited = line.Split(";");
                    var SplitedMacCorrection = System.Text.RegularExpressions.Regex.Replace(splited[0], @"\s+", "");
                    StringIsMac check = new StringIsMac();
                    //Console.WriteLine(SplitedMacCorrection);
                    if (SplitedMacCorrection.Equals("mac", StringComparison.OrdinalIgnoreCase) || SplitedMacCorrection.Equals("serialnumber", StringComparison.OrdinalIgnoreCase) || SplitedMacCorrection.Equals("sn", StringComparison.OrdinalIgnoreCase))
                        continue;
                    bool MacCheck = check.IsMacBool(SplitedMacCorrection);
                    List<string> TmpList = new List<string>();
                    for(int i=2;i<splited.Length;i++)
                    {
                        TmpList.Add(splited[i]);
                    }
                    ModelOfSensorInformations tmp;
                    if (MacCheck)
                    {
                        tmp = new ModelOfSensorInformations(splited[0], splited[1],Info,TmpList);
                    }
                    else
                    {
                        tmp = new ModelOfSensorInformations(splited[1], splited[0],Info,TmpList);
                    }
                    sensorList.Add(tmp);
                }
            }
            return sensorList;
        }
    }
}
