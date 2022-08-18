using Common;
using Common.Modeles;
using SensorDatabseWithScanner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.Database
{
    public class BasicInfoOfSensorDatabase
    {
        public List<SensorModel> SensorList { private set; get; }
        public void ReadFromFile(string filename)
        {
            SensorList = new List<SensorModel>();
            string fullPath = FilePath.PathToFile(filename);
            SensorList = InfoFromBasicCsvToSensorList.ReadBasicSensorsInfoFromCsv(fullPath);//this sepccific line open csv file and phrase it in list with have 2 spaces like this <##,##>;
        }
    }
}
