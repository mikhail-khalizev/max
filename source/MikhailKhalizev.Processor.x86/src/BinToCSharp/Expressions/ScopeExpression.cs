using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ScopeExpression : Expression
    {
        private static readonly ReadOnlyCollection<ScopeExpression> _empty = new ReadOnlyCollection<ScopeExpression>(new List<ScopeExpression>());

        public Expression Expression { get; }
        public virtual ReadOnlyCollection<ScopeExpression> PrevScopes { get; }
        public virtual ReadOnlyCollection<ScopeExpression> NextScopes { get; }

        public ScopeExpression(Expression expression)
            : base(ExpressionType.Scope, expression.LengthInBits)
        {
            Expression = expression;
            PrevScopes = _empty;
            NextScopes = _empty;
        }

        public ScopeExpression(Expression expression, IEnumerable<ScopeExpression> prevScopes, IEnumerable<ScopeExpression> nextScopes)
            : base(ExpressionType.Scope, expression.LengthInBits)
        {
            Expression = expression;
            PrevScopes = prevScopes as ReadOnlyCollection<ScopeExpression> ?? new ReadOnlyCollection<ScopeExpression>(prevScopes.ToList());
            NextScopes = nextScopes as ReadOnlyCollection<ScopeExpression> ?? new ReadOnlyCollection<ScopeExpression>(nextScopes.ToList());
        }
        
        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitScope(this);
        }

        public ScopeExpression Update(Expression expression)
        {
            if (expression == Expression)
                return this;

            return Expression.Scope(expression, PrevScopes, NextScopes);
        }
    }
}