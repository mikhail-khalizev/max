using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ScopeId
    { }

    public class ScopeExpression : Expression
    {
        public ScopeId Id { get; }
        public Expression Expression { get; }
        public virtual ReadOnlyCollection<ScopeId> PrevScopes { get; }
        public virtual ReadOnlyCollection<ScopeId> NextScopes { get; }

        public ScopeExpression(Expression expression, ScopeId id, IEnumerable<ScopeId> prevScopes, IEnumerable<ScopeId> nextScopes)
            : base(ExpressionType.Scope, expression.LengthInBits)
        {
            Expression = expression;
            Id = id;
            PrevScopes = prevScopes as ReadOnlyCollection<ScopeId> ?? new ReadOnlyCollection<ScopeId>(prevScopes.ToList());
            NextScopes = nextScopes as ReadOnlyCollection<ScopeId> ?? new ReadOnlyCollection<ScopeId>(nextScopes.ToList());
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

            return Expression.Scope(expression, Id, PrevScopes, NextScopes);
        }
    }
}