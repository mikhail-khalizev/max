using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class CommentDummyInstructionsPlugin : PluginBase
    {
        /// <inheritdoc />
        public CommentDummyInstructionsPlugin(Engine engine)
            : base(engine)
        {
            // NOTE. Ignore this plugin.
            // Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        {
            if (cmd.Mnemonic == ud_mnemonic_code.UD_Inop)
            {
                cmd.CommentThis = true;
                return;
            }
            
            if (cmd.Mnemonic == ud_mnemonic_code.UD_Ixchg)
            {
                if (Equals(cmd.Operands[0], cmd.Operands[1]))
                    cmd.CommentThis = true;
                return;
            }

            if (cmd.Mnemonic == ud_mnemonic_code.UD_Imov)
            {
                if (Equals(cmd.Operands[0], cmd.Operands[1]))
                {
                    cmd.CommentThis = true;
                    return;
                }

                // Поддерживаем запись только в регистр.
                // Запись память не поддерживаем - это опасно - неизвестно будет ли всё-таки использоваться значение, записанное в память или нет.
                if (cmd.Operands[0].type == ud_type.UD_OP_REG &&
                    (cmd.Operands[1].type == ud_type.UD_OP_REG || cmd.Operands[1].type == ud_type.UD_OP_MEM))
                {
                    // cmd.write_cmd = WriteCmd; // Надо разбираться, проверять. Лучше в будущем сделать DataFlow на графах.
                    return;
                }
            }
        }

        private string WriteCmd(DetectedMethod dm, int cmdIndex, List<string> comments_in_current_func)
        {
            var cmd = dm.Instructions[cmdIndex];

            if (dm.Labels.Contains(cmd.Begin))
                return cmd.ToCodeString();


            var dstReg =
                cmd.Operands[0].type == ud_type.UD_OP_REG
                    ? cmd.Operands[0].@base
                    : ud_type.UD_NONE;

            var srcReg = new[]
            {
                cmd.Operands[1].@base,
                cmd.Operands[1].index,
                cmd.GetEffectiveSegmentOfOperand(cmd.Operands[1])
            };


            // Перебираем все предыдущие команды.
            for (var i = cmdIndex - 1; 0 <= i; i--)
            {
                var cmdPrev = dm.Instructions[i];

                if (dm.Labels.Contains(cmdPrev.End))
                    break;

                // Смотрим команду только если она не закомментированна.
                if (cmdPrev.CommentThis)
                    continue;

                // Поддерживаем только операции mov.
                if (cmdPrev.Mnemonic != ud_mnemonic_code.UD_Imov)
                    break;


                // mov a, b
                // mov b, a
                if (Equals(cmdPrev.Operands[1], cmd.Operands[0]) && Equals(cmdPrev.Operands[0], cmd.Operands[1]))
                {
                    cmd.CommentThis = true;
                    break;
                }

                // mov a, b
                // mov a, b
                if (Equals(cmdPrev.Operands[0], cmd.Operands[0]) && Equals(cmdPrev.Operands[1], cmd.Operands[1]))
                {
                    cmd.CommentThis = true;
                    break;
                }


                if (cmdPrev.Operands[0].type == ud_type.UD_OP_REG)
                {
                    var to = cmdPrev.Operands[0].@base;

                    // Изменение регистра от которого мы зависим.
                    // mov reg1, ?
                    // mob reg2, (reg1)

                    if (srcReg.Any(x => RegisterInfo.Intersects(to, x)))
                        break;

                    // Изменение регистра, в который cmd записывает.
                    // mov reg1.0, ?
                    // mov reg1.1, ?

                    if (RegisterInfo.Intersects(to, dstReg)) 
                        break;
                }
                else
                {
                    if (cmd.Operands[1].type == ud_type.UD_OP_MEM)
                    {
                        // mov mem1, ?
                        // mov reg, mem2

                        if (cmdPrev.Operands[0].@base == cmd.Operands[1].@base
                            && cmdPrev.Operands[0].index == cmd.Operands[1].index
                            && cmdPrev.Operands[0].scale == cmd.Operands[1].scale
                            && cmdPrev.Operands[0].offset == cmd.Operands[1].offset
                            && cmdPrev.Operands[0].size != 0
                            && cmdPrev.Operands[0].size == cmd.Operands[1].size
                            && cmdPrev.PfxSeg == cmd.PfxSeg)
                        {
                            var ic = Interval.From(
                                cmdPrev.Operands[0].lval.udword,
                                cmdPrev.Operands[0].lval.udword + cmdPrev.Operands[0].size / 8);

                            var io = Interval.From(
                                cmd.Operands[1].lval.udword,
                                cmd.Operands[1].lval.udword + cmd.Operands[1].size / 8);

                            // Запись в ту область памяти, из которой cmd_orig будет читать.
                            if (ic.IsIntersects(io, false))
                                break;
                        }
                        else
                            break; // Запись неизвестно куда.
                    }
                }
            }

            // @todo - Можно ещё просматривать вперёд - т.к. могут встретиться повторная запись в тот же регистр.
            return cmd.ToCodeString();
        }
    }
}