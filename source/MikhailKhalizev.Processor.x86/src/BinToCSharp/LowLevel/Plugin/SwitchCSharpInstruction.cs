using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public class SwitchCSharpInstruction : CSharpInstruction
    {
        private readonly SwitchFeature _switchFeature;

        /// <inheritdoc />
        public SwitchCSharpInstruction(CSharpInstruction origInstruction, SwitchFeature switchFeature)
            : base(origInstruction)
        {
            _switchFeature = switchFeature;
        }

        /// <inheritdoc />
        public override string GetCommandMethodName()
        {
            return base.GetCommandMethodName() + "_switch";
        }

        /// <inheritdoc />
        public override IEnumerable<string> GetCode(bool isLastInstructionInMethod)
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
                    _switchFeature.Addresses.Distinct().OrderBy(x => x).SelectMany(
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

            if (HasLabel)
                lines = Enumerable.Empty<string>().Append($"l_{Begin}:").Concat(lines);

            return lines;
        }
    }
}