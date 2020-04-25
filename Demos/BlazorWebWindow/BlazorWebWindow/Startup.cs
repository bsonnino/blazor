using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using WebWindows.Blazor;

namespace BlazorWebWindow
{
   public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
        }

        public void Configure(DesktopApplicationBuilder app)
        {
            app.AddComponent<App>("app");
        }
    } 
}
