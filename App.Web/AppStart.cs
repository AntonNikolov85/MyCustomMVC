namespace App.Web
{
    using CustomMVC;
    using CustomHttpServer;

    public class AppStart
    {
        public static void Main()
        {
            HttpServer server = new HttpServer(8081, RouteTable.Routes);
            MvcEngine.Run(server, "App.Web");
        }
    }
}
