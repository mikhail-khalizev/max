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
    public class Program
    {
        static void Main(string[] args)
        {
            new Program(args).Process2();
        }

        public IServiceProvider Services { get; set; }
        public IConfiguration Configuration { get; set; }

        public Program(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables()
                .AddUserSecrets<Program>()
                .AddCommandLine(args)
                .Build();

            var installedPath = Configuration["Max:InstalledPath"];

            var serviceCollection = new ServiceCollection();
            Services = serviceCollection.BuildServiceProvider();


            var definitionsStr = File.ReadAllText("settings/definitions.json");
            foreach (var x in JsonConvert.DeserializeObject<Dictionary<string, string>>(definitionsStr))
                AddressNameConverter.KnownDefinitions[Address.Parse(x.Key)] = x.Value;

            AddressNameConverter.DefaultNamespaceByAddress.Add(
                (new Interval<Address>(0x10165d52, 0x1019c3cd + 1), "sys"));

            var funcsStr = File.ReadAllText("settings/funcs.json");
            var funcs = JsonConvert.DeserializeObject<IEnumerable<FunctionModel>>(funcsStr);
            //var str = JsonConvert.SerializeObject(funcs, Formatting.Indented);

            var rp = new RawProgram(new Processor.x86.FullSimulate.Processor(), installedPath, "MAXRUN.EXE");
            rp.init_x86_dos_prog();
        }

        public void Process2()
        {

        }

        public void ExtractInformationFromOldCore()
        {
            var paths = Directory.GetFiles(@"..\..\old\program\", "*.cpp", SearchOption.AllDirectories);
            var resultCmd = new List<(ArchitectureMode, string, Address, string, Instruction)>();
            var resultFunc = new List<(ArchitectureMode, Address, string)>();

            foreach (var path in paths)
            {
                var content = File.ReadAllText(path);

                var func = Regex.Match(
                    content,
                    "FUNC_BEGIN\\((/\\*.*?\\*/ *)?(?<addr>0x.*?), (?<hash>.*?, (?<arch>.*?)), \\({(?<body>.*?)}\\)\\)",
                    RegexOptions.Singleline);
                if (!func.Success)
                    continue;

                var fa = AddressNameConverter.GetAddress(func.Groups["addr"].Value);
                var archNum = HexHelper.ToUInt32(func.Groups["arch"].Value);
                var arch = (ArchitectureMode)archNum;

                var fb =
                    func.Groups["body"].Value.Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(HexHelper.ToUInt8)
                        .ToList();
                if (fb.Count == 0)
                    continue;

                resultFunc.Add((arch, fa, HexHelper.ToString(fb)));
                continue;

                var instrs = Regex.Matches(
                    content.Substring(func.Index + func.Length),
                    "II\\((?<addr>.*?), (?<len>.*?)\\)(?<dec>.*?;)( */\\* (?<asm>.*?) \\*/)?\r?\n",
                    RegexOptions.Singleline);
                foreach (var instr in instrs.OfType<Match>())
                {
                    var ia = AddressNameConverter.GetAddress(instr.Groups["addr"].Value);
                    var il = HexHelper.ToInt32(instr.Groups["len"].Value);
                    var id = instr.Groups["asm"].Value;
                    var dec = instr.Groups["dec"].Value.Trim();

                    if (il == 0)
                        il = fb.Count - ia.OffsetFromInBytes(fa);

                    var ib = new byte[il];
                    fb.CopyTo(ia.OffsetFromInBytes(fa), ib, 0, il);

                    if (il != 0 && !dec.StartsWith("/*") && !dec.Contains("switch") && !dec.Contains("_func"))
                    {
                        var dis = new Disassembler(ib, arch, ia, true);
                        var ins = dis.NextInstruction();
                        var cmd = new Processor.x86.BinToCSharp.Instruction(ins);
                        var cmdStr = cmd.MyToString();


                        dec = dec.Replace("fld(0 /* st0 */, ", "fld(");
                        dec = dec.Replace("loopnzw", "loopnew");
                        dec = dec.Replace("setnb", "setae");
                        dec = dec.Replace("setnb", "setae");
                        dec = dec.Replace("/* sys */ ", "");
                        cmdStr = cmdStr.Replace("/* sys */ ", "");

                        if (cmdStr != dec &&
                            !(dec.StartsWith("mov(memd_a32(") && cmdStr.StartsWith("mov(memw_a32")) &&
                            !(dec.StartsWith("mov(gs, memd_a32") && cmdStr.StartsWith("mov(gs, memw_a32")) &&
                            !(dec.StartsWith("mov(ds, memd_a32") && cmdStr.StartsWith("mov(ds, memw_a32")) &&
                            !(dec.StartsWith("mov(es, memd_a32") && cmdStr.StartsWith("mov(es, memw_a32")) &&
                            !(dec.StartsWith("mov(fs, memd_a32") && cmdStr.StartsWith("mov(fs, memw_a32")))
                        {
                            var i = 0;
                        }

                        resultCmd.Add((arch, HexHelper.ToString(ins.Bytes), ia, dec, ins));
                    }
                }
            }

            var abc = resultFunc
                .Distinct(new CustomEqualityComparer<(ArchitectureMode, Address, string)>(
                    (x, y) => x.Item3 == y.Item3,
                    x => x.Item3.GetHashCode()))
                .OrderBy(x => x.Item1)
                .ThenBy(x => x.Item2)
                .ToList();

            var res = JsonConvert.SerializeObject(
                abc.Select(x => new
                {
                    Arch = x.Item1,
                    Addr = x.Item2.ToFullString(),
                    Guid = Guid.NewGuid(),
                    Raw = x.Item3
                }),
                Formatting.Indented);
            
            //var abc = result
            //    .Distinct(new CustomEqualityComparer<Tuple<ArchitectureMode, string, Address, string, Instruction>>(
            //        (x, y) => GetDistinctString(x.Item5) == GetDistinctString(y.Item5),
            //        x => GetDistinctString(x.Item5).GetHashCode()))
            //    .OrderBy(x => x.Item1)
            //    .ThenBy(x => x.Item2)
            //    .ThenBy(x => (uint)x.Item3)
            //    .Select(x =>
            //    {
            //        var str = x.Item4;
            //        foreach (var a in AddressConverter.KnownDefinitions.AsEnumerable())
            //            str = str.Replace(a.Value, a.Key.ToString());
            //        str = str.Replace("/* sys */ ", "");
            //        return Tuple.Create(x.Item1, x.Item2, x.Item3, str, x.Item5);
            //    })
            //    .ToList();

            //var res = JsonConvert.SerializeObject(
            //    abc.Select(x => new { Mode = x.Item1, Address = x.Item3.ToString(), Raw = x.Item2, Dec = x.Item4 }),
            //    Formatting.Indented);
        }

        public string GetDistinctString(Instruction i)
        {
            var s = "";
            s += i.Mnemonic;
            s += i.adr_mode;
            s += i.br_far;
            s += i.br_near;
            s += i.dis_mode;
            s += i.opr_mode;
            s += i.primary_opcode;
            s += " p:";
            s += i.pfx_adr;
            s += i.pfx_lock;
            s += i.pfx_opr;
            s += i.pfx_rep;
            s += i.pfx_repe;
            s += i.pfx_repne;
            s += i.pfx_rex;
            s += i.pfx_seg;
            s += i.pfx_str;

            s += " o:";
            s += i.Operands.Length;

            foreach (var o in i.Operands)
            {
                s += GetDistinctString(o);
                s += ' ';
            }

            return s;
        }

        public string GetDistinctString(Operand o)
        {
            var s = "";
            s += GetDistinctString(o.Base);
            s += GetDistinctString(o.Index);
            s += o.Value == 0 ? 0 : o.Value < 0 ? -1 : 1;
            s += o.Offset;
            s += o.Opcode;
            if (o.Type == ud_type.UD_OP_PTR)
            {
                s += o.PtrOffset == 0;
                s += o.PtrSegment;
            }
            s += o.Scale;
            s += o.Size;
            s += GetDistinctString(o.Type);
            return s;
        }

        public string GetDistinctString(ud_type val)
        {
            if (val == ud_type.UD_NONE)
                return "";
            if (ud_type.UD_R_AL <= val && val <= ud_type.UD_R_BL)
                return ud_type.UD_R_AL.ToString();
            if (ud_type.UD_R_AH <= val && val <= ud_type.UD_R_BH)
                return ud_type.UD_R_AH.ToString();

            if (ud_type.UD_R_AX <= val && val <= ud_type.UD_R_BX)
                return ud_type.UD_R_AX.ToString();
            if (ud_type.UD_R_SI <= val && val <= ud_type.UD_R_DI)
                return ud_type.UD_R_AX.ToString();

            if (ud_type.UD_R_EAX <= val && val <= ud_type.UD_R_EBX)
                return ud_type.UD_R_EAX.ToString();
            if (ud_type.UD_R_ESI <= val && val <= ud_type.UD_R_EDI)
                return ud_type.UD_R_EAX.ToString();

            if (ud_type.UD_R_ST0 <= val && val <= ud_type.UD_R_ST7)
                return ud_type.UD_R_ST0.ToString();

            return val.ToString();
        }
    }
}
