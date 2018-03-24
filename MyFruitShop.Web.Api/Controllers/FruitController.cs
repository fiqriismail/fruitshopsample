using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyFruitShop.Web.Api.BL;
using MyFruitShop.Web.Api.Models.Mappers;

namespace MyFruitShop.Web.Api.Controllers
{
    public class FruitController : ApiController
    {
        FruitService service = new FruitService();

        [HttpPost]
        public IHttpActionResult PostFruit(FruitMapper newFruit)
        {
            var result = service.SaveFruit(newFruit);
            return Ok<int>(result);
        }
    }
}
