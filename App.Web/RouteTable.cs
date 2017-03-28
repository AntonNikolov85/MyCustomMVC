namespace App.Web
{
    using CustomMVC.Routers;
    using CustomHttpServer.Enums;
    using CustomHttpServer.Models;

    public static class RouteTable
    {
        public static Route[] Routes
        {
            get
            {
                return new Route[]
                {
                     new Route()
                    {
                        Name = "Controller/Action/GET",
                        Method = RequestMethod.GET,
                        UrlRegex = @"^/(.+)/(.+)",
                        Callable = new ControllerRouter().Handle
                    },
                    new Route()
                    {
                        Name = "Controller/Action/POST",
                        Method = RequestMethod.POST,
                        UrlRegex = @"^/(.+)/(.+)",
                        Callable = new ControllerRouter().Handle
                    }
                };
            }
        }
    }
}
