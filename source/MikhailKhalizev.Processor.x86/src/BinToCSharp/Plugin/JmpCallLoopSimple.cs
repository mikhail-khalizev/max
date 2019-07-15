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
            var engine = (Engine) sender;
            var op = cmd.Operands[0];
            Address to_addr;

            if ((cmd.IsAnyJump || cmd.IsAnyLoop || cmd.IsCall) && (op.type == ud_type.UD_OP_JIMM))
            {
                switch (op.size)
                {
                    case 8: op.lval.sqword = op.lval.@sbyte; break;
                    case 16: op.lval.sqword = op.lval.sword; break;
                    case 32: op.lval.sqword = op.lval.sdword; break;
                    default: throw new NotImplementedException();
                }

                to_addr = cmd.End + (Address)op.lval.sqword;
            }
            else if ((cmd.IsCall || cmd.Mnemonic == ud_mnemonic_code.UD_Ijmp)
                    && !cmd.BrFar
                    && op.type == ud_type.UD_OP_MEM
                    && op.@base == ud_type.UD_NONE
                    && op.index == ud_type.UD_NONE
                    && op.offset != 0)
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
                        where += engine.CsBase;
                        break;
                    case ud_type.UD_R_DS:
                        where += engine.DsBase;
                        break;
                    case ud_type.UD_R_SS:
                        return;
                    default:
                        throw new NotImplementedException();
                }

                switch (op.size)
                {
                case 16:
                    to_addr = engine.Memory.GetFixSize(where, 2).GetUInt16();
                    break;
                case 32:
                    to_addr = engine.Memory.GetFixSize(where, 4).GetUInt32();
                    break;
                default:
                    throw new NotImplementedException();
                }

                to_addr += engine.CsBase;


                if (to_addr == 0)
                    return;


                var os =
                    "Вызов '" +
                    AddressNameConverter.GetResultName(
                        to_addr,
                        true,
                        false /* лучше true, но комментарий в комментарие.. */) +
                    "'.";

                cmd.Comments.Add(os);
            }
            else
                return;


            Address _eip = to_addr - engine.CsBase;
            if (engine.Mode == ArchitectureMode.x86_16)
                _eip &= 0xffff;
            to_addr = engine.CsBase + _eip;


            bool not_suppressed = engine.SuppressDecode.Contains(to_addr, false);

            if (not_suppressed)
                engine.AddressesToDecode.Add(to_addr);

            if (cmd.IsCall || op.type != ud_type.UD_OP_JIMM)
            {
                if (not_suppressed)
                    engine.NewDetectedMethods.Add(new DetectedMethod(to_addr)); // create if not exist.
            }
            else
            {
                engine.jmp_to_known_addr.TryGetValue(new JumpsToKnownAddresses(cmd.Begin), out var actual);
                if (actual == null)
                {
                    actual = new JumpsToKnownAddresses(cmd.Begin);
                    actual.To = new SortedSet<Address>();
                    engine.jmp_to_known_addr.Add(actual);
                }

                actual.To.Add(to_addr);
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