using Common;
using SensorDatabseWithScanner.Models;
using SensorDatabseWithScanner.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensorDatabseWithScanner.Database
{
    public class ExtendedInfoOfSensorDatabase
    {
        public IEnumerable<ModelOfSensorInformations> InformationsOfSensorList { get; private set; }
        public void ReadFromFile(string filename)
        {
            InformationsOfSensorList = new List<ModelOfSensorInformations>();
            string fullPath = FilePath.PathToFile(filename);
            InformationsOfSensorList = InfoFormExtendedCsvToSensorList.ReadExtendedSensorsInfoFromCsv(fullPath, filename);
        }
    }
}
