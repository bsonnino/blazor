using WebWindows.Blazor;

namespace BlazorWebWindow
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ComponentsDesktop.Run<Startup>("Blazor Avec WebWindow", "wwwroot/index.html");
        }
    }
}
