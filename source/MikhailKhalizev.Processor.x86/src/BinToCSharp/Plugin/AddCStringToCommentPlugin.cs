using System;
using MikhailKhalizev.Processor.x86.Abstractions;
using MikhailKhalizev.Processor.x86.Abstractions.Memory;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class AddCStringToCommentPlugin : PluginBase
    {
        public Interval<Address> StringArea { get; set; }

        /// <inheritdoc />
        public AddCStringToCommentPlugin(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        {
            for (var i = 0; i < cmd.Operands.Count; i++)
            {
                if (cmd.Operands[i].type != ud_type.UD_OP_IMM || !StringArea.Contains(cmd.Operands[i].lval.uqword))
                    continue;

                var str = Engine.Memory.ReadCString(cmd.Operands[i].lval.uqword)
                    .Replace("\\", "\\\\")
                    .Replace("\"", "\\\"")
                    .Replace("\t", "\\t")
                    .Replace("\n", "\\n")
                    .Replace("\r", "\\r");

                cmd.Comments.Add($"\"{str}\"");
            }
        }
    };
}