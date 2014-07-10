using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestForWebApi.Controllers
{
    public class TestParams
    {
        public long ContactID { get; set; }
        public string Name { get; set; }
    }

    public class ValuesController : ApiController
    {
        [HttpPost]
        //Simple type parameters must be passed in url, like: /testpost?p1=1.
        public HttpResponseMessage TestPost(int p1, TestParams param)
        {
            return Request.CreateResponse(HttpStatusCode.OK, param);
        }

        [HttpGet]
        //Complex object parameters must be marked by FromUri in http get request
        public HttpResponseMessage TestGet(int p1, [FromUri]TestParams param)
        {
            return Request.CreateResponse(HttpStatusCode.OK, param);
        }

        [HttpPut]
        //Complex object parameters are passed in body by default
        public HttpResponseMessage TestPut(int p1, TestParams param)
        {
            return Request.CreateResponse(HttpStatusCode.OK, param);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}