using System;
using MikhailKhalizev.Processor.x86.Abstractions;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Plugin
{
    public class AddCStringToCommentPlugin : PluginBase
    {
        public Address StringDataAreaBegin { get; set; }
        public Address StringDataAreaEnd { get; set; }

        /// <inheritdoc />
        public AddCStringToCommentPlugin(Engine engine)
            : base(engine)
        {
            Engine.InstructionDecoded += EngineOnInstructionDecoded;
        }

        private void EngineOnInstructionDecoded(object sender, Instruction cmd)
        {
            for (var i = 0; i < 3; i++)
            {
                if (cmd.Operands[i].type == ud_type.UD_OP_IMM
                    && StringDataAreaBegin <= cmd.Operands[i].lval.uqword
                    && cmd.Operands[i].lval.uqword < StringDataAreaEnd)
                {
                    var os = "";
                    os += '"';

                    var availSpace = ArraySegment<byte>.Empty;

                    for (var ptr = cmd.Operands[i].lval.uqword;; ptr++)
                    {
                        if (availSpace.Count == 0)
                            availSpace = Engine.Memory.GetMinSize(ptr, 1);

                        var c = (char)availSpace[0];
                        availSpace = availSpace.Slice(1);

                        if (c == '\0')
                            break;

                        switch (c)
                        {
                            case '\\':
                                os += "\\\\";
                                break;
                            case '\t':
                                os += "\\t";
                                break;
                            case '\n':
                                os += "\\n";
                                break;
                            case '\r':
                                os += "\\r";
                                break;

                            default:
                                os += c;
                                break;
                        }
                    }

                    os += '"';

                    cmd.Comments.Add(os);
                }
            }
        }
    };
}