using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MikhailKhalizev.Max.Program;
using MikhailKhalizev.Processor.x86;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.Core.Abstractions;
using MikhailKhalizev.Processor.x86.Utils;
using Newtonsoft.Json;
using SharpDisasm;
using SharpDisasm.Udis86;
using ConfigurationDto = MikhailKhalizev.Max.Configuration.ConfigurationDto;
using Instruction = SharpDisasm.Instruction;

namespace MikhailKhalizev.Max
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            new StartUp(args);
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
                .AddJsonFile("settings/appsettings.json", optional: true)
                .AddUserSecrets<StartUp>()
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
            
            using (var p = new Processor.x86.Core.Processor(ConfigurationDto.Processor))
            {
                var rp = new RawProgramMain(p, ConfigurationDto);
                rp.Start();
            }
        }
    }
}
