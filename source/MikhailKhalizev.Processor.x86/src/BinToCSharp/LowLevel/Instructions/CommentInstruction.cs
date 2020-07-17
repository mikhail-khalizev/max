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
        public bool HasLabel { get; set; }

        /// <inheritdoc />
        public bool IsJmpOrJcc => false;

        /// <inheritdoc />
        public bool IsLoopOrLoopcc => false;

        /// <inheritdoc />
        public bool IsRet => false;

        /// <inheritdoc />
        public bool IsJmp => false;

        /// <inheritdoc />
        public bool IsLocalBranch { get; set; }


        private readonly string _comment;

        public CommentInstruction(Address begin, Address end, string comment)
        {
            _comment = comment;
            Begin = begin;
            End = end;
        }

        /// <inheritdoc />
        public IEnumerable<string> GetCode(bool isLastInstructionInMethod)
        {
            var ii = this.GetInstructionInfoString();

            var lines = Enumerable.Empty<string>();

            if (HasLabel)
                lines = lines.Append($"l_{Begin}:");

            lines = lines.Append("//  " + ii + _comment);

            return lines;
        }
    }
}