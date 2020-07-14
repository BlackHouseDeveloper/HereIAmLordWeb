using System;
using HereIAmAPI.Model;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Web.Areas.Identity.Data;

[assembly: HostingStartup(typeof(Web.Areas.Identity.IdentityHostingStartup))]
namespace Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebIdentityDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebIdentityDbContextConnection")));

                services.AddDefaultIdentity<Profile>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebIdentityDbContext>();
            });
        }
    }
}