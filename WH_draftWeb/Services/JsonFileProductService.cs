using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Text.Json;
using WH_draftWeb.Models;
using System.IO;

namespace WH_draftWeb.Services
{
    public class JsonFileProductService
    {
        public IWebHostEnvironment WebHostEnvironment { get; }
        public JsonFileProductService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "products.json"); }
        }
        public IEnumerable<Product> GetProducts()
        {
            using (var fileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Product[]>(fileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {

                        PropertyNameCaseInsensitive = true
                    });
            }
        }
    }
}
