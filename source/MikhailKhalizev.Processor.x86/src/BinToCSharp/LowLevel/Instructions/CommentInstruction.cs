using System.Collections.Generic;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel
{
    public class CommentInstruction : IInstruction
    {
        /// <inheritdoc />
        public Address Begin { get; set; }

        /// <inheritdoc />
        public Address End { get; set; }

        /// <inheritdoc />
        public InstructionMetadata Metadata => _metadata ??= new InstructionMetadata();
        private InstructionMetadata _metadata;
        

        private readonly string _comment;

        public CommentInstruction(Address begin, Address end, string comment)
        {
            _comment = comment;
            Begin = begin;
            End = end;
        }

        /// <inheritdoc />
        public IEnumerable<string> GetLowLevelCode()
        {
            var ii = this.GetInstructionInfoString();

            var lines = Enumerable.Empty<string>();

            if (Metadata.HasLabel)
                lines = lines.Append($"l_{Begin}:");

            lines = lines.Append("//  " + ii + _comment);

            return lines;
        }
    }
}