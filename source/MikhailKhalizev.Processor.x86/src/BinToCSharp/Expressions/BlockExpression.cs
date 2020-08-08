using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class BlockExpression : Expression
    {
        public ReadOnlyCollection<Expression> Expressions { get; }
        
        public BlockExpression(IEnumerable<Expression> expressions)
            : this(expressions as ReadOnlyCollection<Expression> ?? new ReadOnlyCollection<Expression>(expressions.ToList()))
        { }

        public BlockExpression(ReadOnlyCollection<Expression> expressions)
            : base(ExpressionType.Block, expressions[^1].LengthInBits)
        {
            Expressions = expressions;
        }
        
        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitBlock(this);
        }

        /// <summary>
        /// Creates a new expression that is like this one, but using the
        /// supplied children. If all of the children are the same, it will
        /// return this expression.
        /// </summary>
        /// <param name="expressions">The <see cref="Expressions"/> property of the result.</param>
        /// <returns>This expression if no children changed, or an expression with the updated children.</returns>
        public BlockExpression Update(IEnumerable<Expression> expressions)
        {
            if (expressions.SequenceEqual(Expressions))
                return this;

            return Expression.Block(expressions);
        }
    }
}