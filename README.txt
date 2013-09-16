1.  Version your API
Look in the App_Start\WebApiConfig.cs file.  Make sure you insert a 
version (v1, v2, etc) into your routeTemplate when configuring your
routes

2.  HttpResponseMessage as return types
Use the HttpResponseMessage as your return type.  Look at the 
ValuesController.Post(...) as an example.  This makes it easy to 
return back HttpStatus Codes to caller.  This also gives some info 
on how to use fiddler to test calls.

3.  Add a Test API to the main site to use for testing your API
http://blogs.msdn.com/b/yaohuang1/archive/2012/12/02/adding-a-simple-test-client-to-asp-net-web-api-help-page.aspx
Follow these steps.  Do it.

4.  If you need to implement a token for authorization see the TokenAuthorizeAttribute. 
This is still in it's infancy.  


// TODO:
Implement a way to create tokens that will be used by the user for requests.