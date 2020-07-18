using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public class SimpleBranchPlugin : PluginBase
    {
        /// <inheritdoc />
        public SimpleBranchPlugin(LowLevelEngine engine)
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
                Engine.RegisterOnInstructionAttachToMethod(
                    cmd,
                    (method, index) =>
                    {
                        if (method.MethodInfo.JumpsInfo?.IsGoUp?.Contains(cmd.End) == true)
                            cmd.IsCallUp = true;
                    });
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

                Engine.RegisterOnInstructionAttachToMethod(
                    cmd,
                    (method, index) =>
                    {
                        Engine.MethodInfoCollection.AddExtraRaw(method.MethodInfo, extraStart, extraBytes);
                    });

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


            var notSuppressed = !Engine.SuppressDecodeIntervals.Contains(toAddr, false);
            if (notSuppressed)
                Engine.AddToDecode(toAddr);

            if (cmd.IsCall || op.type != ud_type.UD_OP_JIMM)
            {
                Engine.AddNewDetectedMethod(toAddr);
            }
            else
            {
                Engine.BranchesInfo.TryGetValue(new BranchInfo(cmd.Begin), out var actual);
                if (actual == null)
                {
                    actual = new BranchInfo(cmd.Begin);
                    actual.To = new MySortedSet<Address>();
                    Engine.BranchesInfo.Add(actual);
                }

                actual.To.Add(toAddr);

                Engine.RegisterOnInstructionAttachToMethod(
                    cmd,
                    (method, index) =>
                    {
                        if (extraBytes != null)
                            Engine.MethodInfoCollection.AddExtraRaw(method.MethodInfo, extraStart, extraBytes);

                        Engine.BranchesInfo.TryGetValue(new BranchInfo(method.Instructions[index].Begin), out var branchInfo);
                        if (branchInfo == null)
                            throw new InvalidOperationException();

                        var to = branchInfo.To.Single();
                        
                        if (method.InstructionOf(to)?.Metadata.HasLabel != true)
                        {
                            if (method.Begin <= to && to < method.End)
                                cmd.Comments.Add("Адрес перехода делит инструкцию в этой функции пополам.");
                        }
                    });
            }
        }
    }
}