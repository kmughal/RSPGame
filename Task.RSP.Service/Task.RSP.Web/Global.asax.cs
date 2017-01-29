namespace Task.RSP.Web
{
    using System.Web.Http;
    using System.Web.Routing;

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);         
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}
