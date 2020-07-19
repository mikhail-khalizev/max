using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public class SwitchInstruction : X86Instruction
    {
        public List<Address> Addresses { get; }

        /// <inheritdoc />
        public SwitchInstruction(X86Instruction origInstruction, List<Address> addresses)
            : base(origInstruction)
        {
            Addresses = addresses;
        }

        /// <inheritdoc />
        public override string GetCommandMethodName()
        {
            return base.GetCommandMethodName() + "_switch";
        }

        /// <inheritdoc />
        public override IEnumerable<string> GetCode()
        {
            var lines = Enumerable.Empty<string>();

            var ii = this.GetInstructionInfoString();
            var comments = string.Join(" ", Comments.Select(x => $"/* {x} */"));

            var cmd = GetCommandString().TrimEnd(';');

            lines = lines
                .Append((ii + comments).TrimEnd())
                .Concat(
                    new[]
                    {
                        $"switch ({cmd})",
                        "{"
                    })
                .Concat(
                    Addresses.Distinct().OrderBy(x => x).SelectMany(
                        to =>
                        {
                            return
                                new[]
                                {
                                    $"    case {to}:",
                                    $"        goto l_{to};"
                                };
                        }))
                .Concat(
                    new[]
                    {
                        "    default:",
                        "        throw new NotImplementedException();",
                        "}"
                    });


            lines = CommentThis
                ? lines.Select(x => "//  " + x)
                : lines.Select(x => "    " + x);

            return lines;
        }
    }
}