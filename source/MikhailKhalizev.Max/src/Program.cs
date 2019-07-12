using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.BinToCSharp;
using MikhailKhalizev.Processor.x86.Utils;
using MikhailKhalizev.Utils;
using Newtonsoft.Json;
using SharpDisasm;
using SharpDisasm.Udis86;
using Instruction = SharpDisasm.Instruction;

namespace MikhailKhalizev.Max
{
    public class ConfigurationDto
    {
        public ConfigurationMaxDto Max { get; set; } = new ConfigurationMaxDto();
    }

    public class ConfigurationMaxDto
    {
        public string InstalledPath { get; set; }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            new Program(args);
        }

        public IServiceProvider Services { get; set; }
        public IConfiguration Configuration { get; set; }
        public ConfigurationDto ConfigurationDto { get; set; }

        public Program(string[] args)
        {
            // Read configuration.

            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("settings/appsettings.json", optional: true, reloadOnChange: true)
                .AddUserSecrets<Program>()
                .AddEnvironmentVariables()
                .AddCommandLine(args)
                .Build();
            ConfigurationDto = Configuration.Get<ConfigurationDto>();

            // Check configuration.

            var installedPath = ConfigurationDto.Max.InstalledPath;
            if (!Directory.Exists(installedPath))
                throw new InvalidOperationException($"Directory '{installedPath}' not found. Check Max:InstalledPath configuration parameter.");

            // Create ServiceProvider.

            var serviceCollection = new ServiceCollection();
            Services = serviceCollection.BuildServiceProvider();
            
            // Start.
            
            var definitionsStr = File.ReadAllText("settings/definitions.json");
            foreach (var x in JsonConvert.DeserializeObject<Dictionary<string, string>>(definitionsStr))
                AddressNameConverter.KnownDefinitions[Address.Parse(x.Key)] = x.Value;

            var funcsStr = File.ReadAllText("settings/funcs.json");
            var funcs = JsonConvert.DeserializeObject<List<FunctionModel>>(funcsStr);
            //var str = JsonConvert.SerializeObject(funcs, Formatting.Indented);


            var processor = new Processor.x86.FullSimulate.Processor();
            var rp = new RawProgram(processor, installedPath, "MAXRUN.EXE");
            processor.run_func += rp.run_func;
            rp.init_x86_dos_prog();

            processor.correct_function_position(0);
        }
    }
}
