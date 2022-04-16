using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MenuMaster_WinFormsApp
{
    public class Config
    {
        public JSON_Config ReadConfig()
        {
            ReadWrite_JSON control = new ReadWrite_JSON();
            return control.ReadJson();
        }
        public void WriteConfig()
        {
            JSON_Config model = new JSON_Config()
            {
                Lang = "en"
            };
            ReadWrite_JSON control = new ReadWrite_JSON();
            control.WriteJson(model);

            string defaultvalue = JsonConvert.SerializeObject(model,Formatting.Indented);
        }
    }
}
