using System;
using System.Collections.Generic;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class BinaryExpression : Expression
    {
        public Expression Left { get; }
        public Expression Right { get; }

        protected internal BinaryExpression(ExpressionType nodeType, int lengthInBits, Expression left, Expression right)
            : base(nodeType, lengthInBits)
        {
            Left = left;
            Right = right;
        }

        /// <summary>
        /// Creates a new expression that is like this one, but using the
        /// supplied children. If all of the children are the same, it will
        /// return this expression.
        /// </summary>
        /// <param name="left">The <see cref="Left"/> property of the result.</param>
        /// <param name="right">The <see cref="Right"/> property of the result.</param>
        /// <returns>This expression if no children changed, or an expression with the updated children.</returns>
        public BinaryExpression Update(Expression left, Expression right)
        {
            if (left == Left && right == Right)
                return this;

            return MakeBinary(NodeType, left, right);
        }


        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitBinary(this);
        }
    }
}