using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPIReference.Filters
{
    public class TokenAuthorizeAttribute : AuthorizeAttribute
    {
        protected override bool IsAuthorized(HttpActionContext actionContext)
        {
            // When implementing this for real, go to the database
            // 1.  validate the token belongs to a user in the system.
            // 2.  verify that the user can perform the action.
            bool requestHeaderHasToken = actionContext.Request.Headers.Contains("Token");

            return requestHeaderHasToken;
        }
    }
}