using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ScopeExpressionBuilder : ScopeExpression
    {
        /// <inheritdoc />
        public override ReadOnlyCollection<ScopeExpression> PrevScopes => _prevScopes ?? base.PrevScopes;
        private ReadOnlyCollection<ScopeExpression> _prevScopes;

        /// <inheritdoc />
        public override ReadOnlyCollection<ScopeExpression> NextScopes => _nextScopes ?? base.NextScopes;
        private ReadOnlyCollection<ScopeExpression> _nextScopes;

        /// <inheritdoc />
        public ScopeExpressionBuilder(Expression expression)
            : base(expression)
        { }

        public void SetPrevScopes(IEnumerable<ScopeExpression> scopes)
        {
            _prevScopes = scopes as ReadOnlyCollection<ScopeExpression> ?? new ReadOnlyCollection<ScopeExpression>(scopes.ToList());
        }

        public void SetNextScopes(IEnumerable<ScopeExpression> scopes)
        {
            _nextScopes = scopes as ReadOnlyCollection<ScopeExpression> ?? new ReadOnlyCollection<ScopeExpression>(scopes.ToList());
        }
    }
}