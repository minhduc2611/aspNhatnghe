using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace demo.Models
{
    public class MyTool
    {
        public static string GetConnectionString(string key)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("wwwroot/configure.json");
            var config = builder.Build(); // lay json co connectionstrings 

            return config.GetConnectionString(key); // 
        }
    }
}
