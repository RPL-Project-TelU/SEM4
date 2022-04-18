using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MenuMaster_WinFormsApp
{
    public class ReadWrite_JSON
    {
        public void WriteJson(JSON_Config data)
        {
            string file = JsonConvert.SerializeObject(data);
            File.WriteAllText(@"D:\Programs\Universitas\semester_4\Praktikum_KPL\Model_2\NewMenumaster\SEM4\MenuMaster_WinFormsApp\MenuMaster_WinFormsApp\Config.json", file);
        }
        public JSON_Config ReadJson()
        {
            dynamic data = File.ReadAllText(@"D:\Programs\Universitas\semester_4\Praktikum_KPL\Model_2\NewMenumaster\SEM4\MenuMaster_WinFormsApp\MenuMaster_WinFormsApp\Config.json");
            JSON_Config config = JsonConvert.DeserializeObject<JSON_Config>(data);
            return config;
        }
    }
}
