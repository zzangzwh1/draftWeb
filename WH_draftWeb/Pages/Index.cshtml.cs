using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WH_draftWeb.Models;
using WH_draftWeb.Services;

namespace WH_draftWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductService _jsonFileProductService;
        public IEnumerable<Product> products { get; private set; }

        public IndexModel(ILogger<IndexModel> logger,JsonFileProductService productService)
        {
            _logger = logger;
            _jsonFileProductService = productService;
        }

        public void OnGet()
        {
            products = _jsonFileProductService.GetProducts();
        }
    }
}
