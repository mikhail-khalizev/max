using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MikhailKhalizev.Max.Configuration;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Utils;
using IApplicationLifetime = Microsoft.AspNetCore.Hosting.IApplicationLifetime;

namespace MikhailKhalizev.Max
{
    public class Startup
    {
        public static int ExitCode { get; set; }

        public static int Main(string[] args)
        {
            try
            {
                CreateWebHostBuilder(args).Build().Run();
                return ExitCode;
            }
            catch (System.OperationCanceledException ex)
            {
                NonBlockingConsole.WriteLine(ex.Message);
                return -2;
            }
            catch (Exception ex)
            {
                NonBlockingConsole.WriteLine(ex);
                return -1;
            }
            finally
            {
                NonBlockingConsole.AllWritten.Wait();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            if (args.Contains("--redecode"))
                args = args.Append(int.MaxValue.ToString()).ToArray();

            return WebHost.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration(
                    (hostingContext, config) =>
                    {
                        var env = hostingContext.HostingEnvironment;

                        config
                            .AddJsonFile("appsettings.json", optional: true)
                            .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                            .AddJsonFile("appsettings.user.json", optional: true)
                            .AddJsonFile("settings/appsettings.json", optional: true)
                            .AddJsonFile($"settings/appsettings.{env.EnvironmentName}.json", optional: true)
                            .AddJsonFile("settings/appsettings.user.json", optional: true)
                            .AddEnvironmentVariables()
                            .AddCommandLine(args);
                    })
                .UseStartup<Startup>();
        }


        public IConfiguration Configuration { get; }
        public ConfigurationDto ConfigurationDto { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            ConfigurationDto = configuration.Get<ConfigurationDto>();

            // Check configuration.

            var installedPath = ConfigurationDto.Program.WorkingDirectory;
            if (!Directory.Exists(installedPath))
                throw new InvalidOperationException(
                    $"Directory '{installedPath}' not found. Check Program:WorkingDirectory configuration option.");
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddRazorPages()
                .AddApplicationPart(Assembly.GetEntryAssembly())
                .AddApplicationPart(Assembly.GetExecutingAssembly());
            services
                .AddSignalR()
                .AddNewtonsoftJsonProtocol();

            services.AddSingleton(
                provider => new Processor.x86.CSharpExecutor.Cpu(
                    ConfigurationDto.Processor,
                    provider.GetRequiredService<IHostApplicationLifetime>().ApplicationStopping));
            services.AddSingleton(p => MethodInfoCollection.Load(ConfigurationDto.BinToCSharp));
            services.AddSingleton(
                p =>
                {
                    var definitionCollection = new DefinitionCollection();
                    definitionCollection.AddDefinitionsFromAssembly(typeof(Definitions).Assembly);
                    return definitionCollection;
                });
            services.AddSingleton(
                p => new RawProgramMain(
                    p.GetRequiredService<Processor.x86.CSharpExecutor.Cpu>(),
                    ConfigurationDto,
                    p.GetRequiredService<MethodInfoCollection>(),
                    p.GetRequiredService<DefinitionCollection>(),
                    p));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [UsedImplicitly]
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IHostApplicationLifetime applicationLifetime)
        {
            // TODO Implement IDefinitionGroupArea with Begin, End. And remove AddressNameConverter.AddNamespace.
            AddressNameConverter.AddNamespace(new Interval<Address, Address.Comparer>(0x1016_5d52, 0x1019_c3ce), "sys");
            foreach (var interval in RawProgramMain.MveForceEndIntervals)
                AddressNameConverter.AddNamespace(interval, "mve");

            // Redecode.

            var redecodeCount = Configuration.GetValue<int?>("redecode");
            if (redecodeCount != null)
            {
                NonBlockingConsole.WriteLine("Start Redecode.");

                var methodsInfo = app.ApplicationServices.GetRequiredService<MethodInfoCollection>();
                var definitionCollection = app.ApplicationServices.GetRequiredService<DefinitionCollection>();

                var redecode = new Redecode(ConfigurationDto.BinToCSharp, methodsInfo, definitionCollection);
                redecode.LimitFiles = redecodeCount.Value;
                redecode.Start(GetType().Assembly);

                applicationLifetime.StopApplication();
                return;
            }

            // Asp.

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseStaticFiles();
            app.UseRouting();
            app.UseEndpoints(
                endpoints =>
                {
                    endpoints.MapHub<MainHub>("/signalr");
                    endpoints.MapControllers();
                    endpoints.MapRazorPages();
                });

            // Start M.A.X.
            
            var rawProgramMain = app.ApplicationServices.GetRequiredService<RawProgramMain>();
            Task.Run(
                () =>
                {
                    try
                    {
                        rawProgramMain.Start();
                    }
                    catch (OperationCanceledException ex)
                    {
                        NonBlockingConsole.WriteLine(ex.Message);
                        ExitCode = -2;
                    }
                    catch (Exception ex)
                    {
                        NonBlockingConsole.WriteLine(ex);
                        ExitCode = -1;
                    }

                    applicationLifetime.StopApplication();
                });
        }
    }
}