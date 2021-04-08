using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]// istegi yaparken insanlar nasıl ulaşsın
    [ApiController] //ATTRIBUTE DENİR BUNA. CLASS İLE İLGİLİ BİLGİ VERME.BU CLASS BİR CONTROLLER.
    public class ProductsController : ControllerBase
    {

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public List<Product> Get()
        {

             var result = _productService.GetAll();
             return result.Data;
             
        }
    }
}
