using Boeing.Services.Greetings.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Boeing.Services.Greetings.Controllers
{
    [RoutePrefix("api/v2/Greetings")]
    public class GreetingsController : ApiController
    {
        // GET api/Greetings
        [System.Web.Http.Route("")]
        [System.Web.Http.HttpGet]
        public IHttpActionResult GetHelloWorld()
        {
            return Content(HttpStatusCode.OK, "Hello World!");
        }
        //Build Trigger with Failed Scenario
        [System.Web.Http.Route("")]
        [System.Web.Http.HttpPost]
        public IHttpActionResult Post(UserDetailDto userDetail)
        {
           if (ModelState.IsValid && userDetail !=null)
                return Content(HttpStatusCode.Accepted, $"Hello {userDetail.PersonName} World!");
            else
                return Content(HttpStatusCode.BadRequest,ModelState);
        }
    }
}
