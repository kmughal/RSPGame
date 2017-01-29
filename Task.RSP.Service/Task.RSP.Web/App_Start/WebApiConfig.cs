
namespace Task.RSP.Web
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Serialization;
    using System.Web.Http;
    using System.Web.Http.Cors;
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            enableCamelCase(config);
            enableCors(config);
            config.MapHttpAttributeRoutes();
        }
        private static void enableCamelCase(HttpConfiguration config)
        {
            var formatters = GlobalConfiguration.Configuration.Formatters;
            var jsonFormatter = formatters.JsonFormatter;
            var settings = jsonFormatter.SerializerSettings;
            settings.Formatting = Formatting.Indented;
            settings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }

        private static void enableCors(HttpConfiguration config) => config.EnableCors(new
                EnableCorsAttribute(
                           origins: "*",
                           headers: "*",
                           methods: "*"));
    }
}
