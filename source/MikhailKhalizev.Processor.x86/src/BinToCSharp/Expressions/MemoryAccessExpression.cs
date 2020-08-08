using System;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class MemoryAccessExpression : Expression
    {
        public Expression Address { get; }

        protected internal MemoryAccessExpression(Expression address, int dataLengthInBits)
            : base(ExpressionType.MemoryAccess, dataLengthInBits)
        {
            Address = address;
        }

        public MemoryAccessExpression Update(Expression address)
        {
            if (address == Address)
                return this;

            return MemoryAccess(address, LengthInBits);
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