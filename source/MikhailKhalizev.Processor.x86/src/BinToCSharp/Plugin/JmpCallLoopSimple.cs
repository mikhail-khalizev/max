using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class JmpCallLoopSimple : PluginBase
    {
        /// <inheritdoc />
        public JmpCallLoopSimple(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        {
            if (cmd.Operands.Count < 1)
                return;

            var op = cmd.Operands[0];
            Address toAddr = 0;

            if ((cmd.IsAnyJump || cmd.IsAnyLoop || cmd.IsCall) && (op.type == ud_type.UD_OP_JIMM))
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
                    // Support only flat model (without segments) to increase accuracy.
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


                switch (cmd.GetEffectiveSegmentOfOperand(cmd.Operands[0]))
                {
                    case ud_type.UD_R_CS:
                        where += Engine.CsBase;
                        break;
                    case ud_type.UD_R_DS:
                        where += Engine.DsBase;
                        break;
                    case ud_type.UD_R_SS:
                        return;
                    default:
                        throw new NotImplementedException();
                }

                switch (op.size)
                {
                    case 16:
                        toAddr = Engine.Memory.GetFixSize(where, 2).GetUInt16();
                        break;
                    case 32:
                        toAddr = Engine.Memory.GetFixSize(where, 4).GetUInt32();
                        break;
                    default:
                        throw new NotImplementedException();
                }

                toAddr += Engine.CsBase;


                if (toAddr == 0)
                    return;


                var os =
                    "Вызов '" +
                    AddressNameConverter.GetResultName(
                        toAddr,
                        false,
                        false /* лучше true, но комментарий в комментарие.. */) +
                    "'.";

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
                Engine.AddressesToDecode.Add(toAddr);

            if (cmd.IsCall || op.type != ud_type.UD_OP_JIMM)
            {
                if (notSuppressed)
                    Engine.NewDetectedMethods.Add(new DetectedMethod(toAddr)); // create if not exist.
            }
            else
            {
                Engine.jmp_to_known_addr.TryGetValue(new JumpsToKnownAddresses(cmd.Begin), out var actual);
                if (actual == null)
                {
                    actual = new JumpsToKnownAddresses(cmd.Begin);
                    actual.To = new SortedSet<Address>();
                    Engine.jmp_to_known_addr.Add(actual);
                }

                actual.To.Add(toAddr);
                cmd.write_cmd = on_cmd_write;
            }
        }

        private string on_cmd_write(Engine engine, DetectedMethod dm, int cmd_index, List<string> comments_in_current_func)
        {
            engine.jmp_to_known_addr.TryGetValue(new JumpsToKnownAddresses(dm.Instructions[cmd_index].Begin), out var cur_jmp);
            if (cur_jmp == null)
                throw new InvalidOperationException();

            var to = cur_jmp.To.Single();

            var func_suffix = "";
            if (!dm.Labels.Contains(to))
            {
                func_suffix = "_func";

                if (dm.Begin <= to && to < dm.End)
                    comments_in_current_func.Add("Адрес перехода делит инструкцию в этой функции пополам.");
            }

            return dm.Instructions[cmd_index].ToCodeString(func_suffix);
        }
    }
}