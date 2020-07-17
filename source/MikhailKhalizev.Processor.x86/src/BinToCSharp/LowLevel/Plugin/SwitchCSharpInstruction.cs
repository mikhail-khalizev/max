using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel.Plugin
{
    public class SwitchCSharpInstruction : ProxyCSharpInstruction
    {
        private readonly CSharpInstruction _instruction;
        private readonly SwitchFeature _switchFeature;

        /// <inheritdoc />
        public SwitchCSharpInstruction(
            ICSharpInstruction icSharpInstructionImplementation,
            SwitchFeature switchFeature)
            : base(icSharpInstructionImplementation)
        {
            _instruction = (CSharpInstruction) icSharpInstructionImplementation;
            _switchFeature = switchFeature;
        }

        /// <inheritdoc />
        public override IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            var lines = Enumerable.Empty<string>();

            var ii = this.GetInstructionInfoString(true);
            var comments = string.Join(" ", _instruction.Comments.Select(x => $"/* {x} */"));

            var cmd = _instruction.GetCommandString().TrimEnd(';');

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


            lines =
                _instruction.CommentThis
                    ? lines.Select(x => "//  " + x)
                    : lines.Select(x => "    " + x);

            if (HasLabel)
                lines = Enumerable.Empty<string>().Append($"l_{Begin}:").Concat(lines);

            return lines;
        }
    }
}