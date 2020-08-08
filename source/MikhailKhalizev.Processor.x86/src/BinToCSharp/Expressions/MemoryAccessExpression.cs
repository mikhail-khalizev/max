using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class MemoryAccessExpression : Expression
    {
        public RegisterInfo Segment { get; }
        public Expression Address { get; }

        protected internal MemoryAccessExpression(RegisterInfo segment, Expression address, int dataLengthInBits)
            : base(ExpressionType.MemoryAccess, dataLengthInBits)
        {
            if (!segment.IsSegment)
                throw new ArgumentException($"Expected segment register, but found {segment}");

            Segment = segment;
            Address = address;
        }

        public MemoryAccessExpression Update(RegisterInfo segment, Expression address)
        {
            if (segment == Segment && address == Address)
                return this;

            return MemoryAccess(segment, address, LengthInBits);
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitMemoryAccess(this);
        }
    }
}