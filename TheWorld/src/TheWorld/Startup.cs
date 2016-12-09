using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TheWorld.Services;

namespace TheWorld
{
    public class Startup
    {
		private IHostingEnvironment _env;
		private IConfigurationRoot _config;

		public Startup(IHostingEnvironment env)
		{
			// Apparently IHostingEnvironment is not accessible within ConfigureServices but apparently within Configure.
			_env = env;

			var builder = new ConfigurationBuilder()
				.SetBasePath(_env.ContentRootPath)
				.AddJsonFile("config.json")
				.AddEnvironmentVariables();

			_config = builder.Build();
		}

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
			// "Sinleton" given no need to create multiple instances.
			services.AddSingleton(_config);

			// "Production" may not be setup at the moment.
			if (_env.IsProduction() == false)
			{
				services.AddScoped<IMailService, DebugMailService>();
			}
			else
			{
				// Implement real email sending functionality.
			}

			services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

			// "Production" may not be setup at the moment.
			if (env.IsProduction() == false)
			{
				app.UseDeveloperExceptionPage();
			}
			
			app.UseStaticFiles();
			app.UseMvc(config =>
			{
				config.MapRoute(
					name: "Default",
					template: "{controller}/{action}/{id?}",
					defaults: new { controller = "App", action = "Index" });
			});
		}
    }
}
