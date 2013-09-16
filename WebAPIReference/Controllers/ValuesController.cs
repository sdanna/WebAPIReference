using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIReference.Models;

namespace WebAPIReference.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [AllowAnonymous]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/v1/values
        /// <summary>
        /// If calling through fiddler, make sure to have the 
        /// "Content-Type: application/json; charset=utf-8"
        /// set in the Request Headers otherwise the Credentials object won't be model bound.
        /// 
        /// Returning HttpResponseMessage in this way easily allows you to control the 
        /// returned HttpStatus.
        /// 
        /// You must use the [FromBody] attribute since you are putting 
        /// json that matches the form of the Credentials object.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public HttpResponseMessage Post([FromBody]Credentials input)
        {
            var inputIsValid = true;
            if (!inputIsValid)
            {
                var errorMessage = new ErrorMessage {Message = "Invalid object state."};
                var badResponse = Request.CreateResponse(HttpStatusCode.NotAcceptable, errorMessage);
                return badResponse;
            }

            var returnVM = new ReturnVM
                {
                    Data1 = "123",
                    Data2 = "456",
                    Data3 = "789"
                };
            var response = Request.CreateResponse(HttpStatusCode.OK, returnVM);
            return response;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}