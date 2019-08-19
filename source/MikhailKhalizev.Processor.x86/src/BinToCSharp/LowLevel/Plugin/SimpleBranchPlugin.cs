using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Core.Abstractions.Memory;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class SimpleBranchPlugin : PluginBase
    {
        /// <inheritdoc />
        public SimpleBranchPlugin(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, CSharpInstruction cmd)
        {
            if (cmd.Operands.Count < 1)
                return;
            var op = cmd.Operands[0];

            
            if (cmd.IsCall)
            {
                var orig = cmd.WriteCmd;

                cmd.WriteCmd = (engine, dm, index, func, offset) =>
                {
                    if (dm.MethodInfo.JumpsInfo?.IsGoUp?.Contains(cmd.End - offset) == true)
                        cmd.IsCallUp = true;

                    return orig(engine, dm, index, func, offset);
                };
            }


            Address toAddr = 0; // prediction address.

            Address extraStart = 0;
            byte[] extraBytes = null;

            if ((cmd.IsJmpOrJcc || cmd.IsLoopOrLoopcc || cmd.IsCall) && (op.type == ud_type.UD_OP_JIMM))
            {
                switch (op.size)
                {
                    case 8: op.lval.sqword = op.lval.@sbyte; break;
                    case 16: op.lval.sqword = op.lval.sword; break;
                    case 32: op.lval.sqword = op.lval.sdword; break;
                    default: throw new NotImplementedException();
                }

                toAddr = cmd.End + (Address)op.lval.sqword;
            }
            else if ((cmd.IsCall || cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp)
                && !cmd.BrFar
                && op.type == ud_type.UD_OP_MEM
                && op.@base == ud_type.UD_NONE
                && op.index == ud_type.UD_NONE
                && op.offset != 0
                // Support only 32bit+ flat model (without segments) to increase accuracy.
                && Engine.Mode != ArchitectureMode.x86_16
                && Engine.CsBase == 0
                && Engine.DsBase == 0)
            {
                Address where;
                switch (op.offset)
                {
                    case 8: where = op.lval.@sbyte; break;
                    case 16: where = op.lval.sword; break;
                    case 32: where = op.lval.sdword; break;
                    default: throw new NotImplementedException();
                }

                extraStart = where;
                extraBytes = Engine.Memory.ReadAll(extraStart, op.size / 8);
                
                var orig = cmd.WriteCmd;
                cmd.WriteCmd = (engine, dm, index, func, offset) =>
                {
                    engine.MethodInfoCollection.AddExtraRaw(dm.MethodInfo, extraStart, extraBytes);
                    return orig(engine, dm, index, func, offset);
                };

                switch (op.size)
                {
                    case 16:
                        toAddr = BitConverter.ToUInt16(extraBytes);
                        break;
                    case 32:
                        toAddr = BitConverter.ToUInt32(extraBytes);
                        break;
                    default:
                        throw new NotImplementedException();
                }

                if (toAddr == 0)
                    return;

                var os = "Вызов '" + Engine.DefinitionCollection.GetAddressFullName(toAddr) + "'.";

                cmd.Comments.Add(os);
            }
            else
                return;


            Address eip = toAddr - Engine.CsBase;
            if (Engine.Mode == ArchitectureMode.x86_16)
                eip &= 0xffff;
            toAddr = Engine.CsBase + eip;


            var notSuppressed = !Engine.SuppressDecode.Contains(toAddr, false);
            if (notSuppressed)
                Engine.AddToDecode(toAddr);

            if (cmd.IsCall || op.type != ud_type.UD_OP_JIMM)
            {
                Engine.AddNewDetectedMethod(toAddr);
            }
            else
            {
                Engine.BrunchesInfo.TryGetValue(new BrunchInfo(cmd.Begin), out var actual);
                if (actual == null)
                {
                    actual = new BrunchInfo(cmd.Begin);
                    actual.To = new SortedSet<Address>();
                    Engine.BrunchesInfo.Add(actual);
                }

                actual.To.Add(toAddr);
                cmd.WriteCmd = (engine, dm, index, func, offset) => on_cmd_write(engine, dm, index, func, offset, extraStart, extraBytes);
            }
        }

        private string on_cmd_write(Engine engine, DetectedMethod dm, int cmdIndex, List<string> commentsInCurrentFunc, int offset, Address extraStart, byte[] extraBytes)
        {
            if (extraBytes != null)
                engine.MethodInfoCollection.AddExtraRaw(dm.MethodInfo, extraStart, extraBytes);

            engine.BrunchesInfo.TryGetValue(new BrunchInfo(dm.Instructions[cmdIndex].Begin), out var curJmp);
            if (curJmp == null)
                throw new InvalidOperationException();

            var to = curJmp.To.Single();

            var jmpOutside = false;
            var suffix = "";
            if (!dm.Labels.Contains(to))
            {
                jmpOutside = true;
                suffix = "_func";

                if (dm.Begin <= to && to < dm.End)
                    commentsInCurrentFunc.Add("Адрес перехода делит инструкцию в этой функции пополам.");
            }

            if (dm.Instructions[cmdIndex].IsLocalBranch != !jmpOutside)
                throw new InvalidOperationException($"Должно быть уже заполнено в {nameof(Engine)}.{nameof(Engine.DetectMethods)}.");

            return dm.Instructions[cmdIndex].ToCodeString(suffix);
        }
    }
}