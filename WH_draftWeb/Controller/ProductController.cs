using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WH_draftWeb.Models;
using WH_draftWeb.Services;

namespace WH_draftWeb.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public JsonFileProductService _ProductService { get; }

        public ProductController(JsonFileProductService productService)
        {
            this._ProductService = productService;
        }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _ProductService.GetProducts();
        }
    }
}
