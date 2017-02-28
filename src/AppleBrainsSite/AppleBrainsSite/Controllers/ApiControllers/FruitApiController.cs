using AppleBrainsSite.Domain;
using AppleBrainsSite.Models.Requests;
using AppleBrainsSite.Models.Responses;
using AppleBrainsSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppleBrainsSite.Controllers.ApiControllers
{

    [RoutePrefix("api/fruit")]
    public class FruitApiController : BaseApiController
    {
        private IFruitService _fruitService;

        public FruitApiController (IFruitService fruitService)
        {
            _fruitService = fruitService;
        }


        [Route("create")][HttpPost]
        public HttpResponseMessage Create(FruitCreateRequest model)
        {
            if (!IsValidRequest(model))
            {
                return GetErrorResponse("The model cannot be empty");
            }

            int id = _fruitService.Create(model);
            ItemResponse<int> responseData = new ItemResponse<int>();
            responseData.Item = id;

            return Request.CreateResponse(HttpStatusCode.OK, responseData);
        }

        [Route]
        [HttpGet]
        public HttpResponseMessage GetAll(Fruit model)
        {
         
            ItemsResponse<Fruit> responseData = new ItemsResponse<Fruit>();
            responseData.Items = _fruitService.GetAll();

            return Request.CreateResponse(HttpStatusCode.OK, responseData);
        }
    }
}
