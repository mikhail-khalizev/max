using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.BinToCSharp.MethodInfo;
using MikhailKhalizev.Processor.x86.Utils;
using ConfigurationDto = MikhailKhalizev.Max.Configuration.ConfigurationDto;

namespace MikhailKhalizev.Max
{
    public class StartUp
    {
        static int Main(string[] args)
        {
            try
            {
                new StartUp(args);
                NonBlockingConsole.AllWritten.Wait();
                return 0;
            }
            catch (Exception ex)
            {
                NonBlockingConsole.AllWritten.Wait();
                Console.WriteLine(ex);
                return -1;
            }
        }

        public IServiceProvider Services { get; set; }
        public IConfiguration Configuration { get; set; }
        public ConfigurationDto ConfigurationDto { get; set; }

        public StartUp(string[] args)
        {
            // Read configuration.

            Configuration = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json", optional: true)
                .AddJsonFile("appsettings.user.json", optional: true)
                .AddJsonFile("settings/appsettings.json", optional: true)
                .AddJsonFile("settings/appsettings.user.json", optional: true)
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            ConfigurationDto = Configuration.Get<ConfigurationDto>();


            // Check configuration.

            var installedPath = ConfigurationDto.Max.InstalledPath;
            if (!Directory.Exists(installedPath))
                throw new InvalidOperationException($"Directory '{installedPath}' not found. Check Max:InstalledPath configuration option.");


            // Create ServiceProvider.

            var serviceCollection = new ServiceCollection();
            Services = serviceCollection.BuildServiceProvider();


            // Start.
            var methodsInfo = MethodInfoCollection.Load(ConfigurationDto.BinToCSharp);
            try
            {
                var definitionCollection = new DefinitionCollection();
                definitionCollection.AddDefinitionsClass<Definitions>();
                definitionCollection.AddDefinitionsClass<StringDefinitions>();

                AddressNameConverter.AddNamespace(new Interval<Address, Address.Comparer>(0x1016_5d52, 0x1019_c3ce), "sys"); // TODO Implement IDefinitionGroupArea with Begin, End.

                var redecodeArgIndex = args.IndexOf("--redecode");
                if (0 <= redecodeArgIndex)
                {
                    NonBlockingConsole.WriteLine("Start Redecode.");
                    var redecode = new Redecode(ConfigurationDto.BinToCSharp, methodsInfo, definitionCollection);

                    if (redecodeArgIndex + 1 < args.Length)
                        redecode.LimitFiles = int.Parse(args[redecodeArgIndex + 1]);

                    redecode.Start(GetType().Assembly);
                    return;
                }

                using (var p = new Processor.x86.Core.Processor(ConfigurationDto.Processor))
                {
                    var rp = new RawProgramMain(p, ConfigurationDto, methodsInfo, definitionCollection);
                    rp.Start();
                }
            }
            finally
            {
                methodsInfo.Save();
            }
        }
    }
}
