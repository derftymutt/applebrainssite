using AppleBrainsSite.Models.Responses;
using AppleBrainsSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AppleBrainsSite.Controllers.ApiControllers
{
    [RoutePrefix("api/uploads")]
    public class LocalUploadsApiController : ApiController
    {
        private IUploadsService _uploadsService;

        public LocalUploadsApiController(IUploadsService uploadsService)
        {
            _uploadsService = uploadsService;
        }

        [Route][HttpPost]
        public HttpResponseMessage Upload()
        {
            if (HttpContext.Current.Request.Files.Count == 0)
            {
                ErrorResponse error = new ErrorResponse("No file was uploaded");
                return Request.CreateResponse(HttpStatusCode.BadRequest, error);
            }

            HttpPostedFile file = HttpContext.Current.Request.Files[0];
            string uploadUrl = _uploadsService.Upload(file);

            ItemResponse<string> responseData = new ItemResponse<string>();
            responseData.Item = uploadUrl;
            return Request.CreateResponse(HttpStatusCode.OK, responseData);
        }
    }
}
