using org_view.Client.Context;
using org_view.Client.Repositories;
using org_view.Client.Services;
using org_view.Components;
using Microsoft.EntityFrameworkCore;

namespace org_view
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

            //mine
            builder.Services.AddHttpClient<IOrgService, OrgService>();

            builder.Services.AddDbContextFactory<OrgContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("orgdbConnection"));
            });

            builder.Services.AddSingleton<IOrgRepository, OrgRepository>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode()
                .AddInteractiveWebAssemblyRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

            app.Run();
        }
    }
}