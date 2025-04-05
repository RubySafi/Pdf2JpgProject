using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;

namespace Pdf2JpgGui
{
    public static class AppConfig
    {
        public static string PythonScript { get; set; }
        public static string PopplerPath { get; set; }
        public static string DefaultOutput { get; set; }


        public static void Load()
        {
            string exeDirectory = AsmUtility.GetAssemblyDirectoryName();
            string configPath = Path.Combine(exeDirectory, "config.json");
            string json = File.ReadAllText(configPath);
            var config = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            
            PythonScript = config["PythonScript"];
            PopplerPath = config["PopplerPath"];
            DefaultOutput = config["DefaultOutput"];
        }

    }
}