using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class SplitToScope
    {
        public static Expression Process(Expression mainNode)
        {
            return
                new ChangeScopeInfoToScopeExpression().Visit(
                    new AddScopeInfoVisitor().Process(mainNode));
        }


        // Temporary scope, modified expression.
        private class ScopeInfo : Expression
        {
            public static ScopeInfo NoScope { get; } = new ScopeInfo();

            public ScopeId Id { get; } = new ScopeId();
            public List<Expression> Expressions { get; } = new List<Expression>();
            public HashSet<ScopeInfo> PrevScopes { get; } = new HashSet<ScopeInfo>();
            public HashSet<ScopeInfo> NextScopes { get; } = new HashSet<ScopeInfo>();
            
            /// <inheritdoc />
            public ScopeInfo()
                : base(ExpressionType.Scope, 0)
            { }

            public void AddPrevScope(ScopeInfo scope)
            {
                if (scope == NoScope || scope == null)
                    return;

                PrevScopes.Add(scope);
                scope.NextScopes.Add(this);
            }

            public void AddExpression(Expression expression)
            {
                Expressions.Add(expression);
            }

            private Expression GetInnerExpression()
            {
                return Expressions.Count switch
                {
                    0 => Expression.Empty,
                    1 => Expressions[0],
                    _ => Expression.Block(Expressions)
                };
            }

            /// <inheritdoc />
            protected internal override Expression Accept(ExpressionVisitor visitor)
            {
                // Для ToString.
                return visitor.Visit(GetInnerExpression());
            }

            public ScopeExpression GetScopeExpression()
            {
                return Expression.Scope(
                    GetInnerExpression(),
                    Id,
                    PrevScopes.Select(x => x.Id),
                    NextScopes.Select(x => x.Id));
            }
        }

        private class ChangeScopeInfoToScopeExpression : ExpressionVisitor
        {
            /// <inheritdoc />
            public override Expression Visit(Expression node)
            {
                if (node is ScopeInfo si)
                    return si.GetScopeExpression();
                else
                    return base.Visit(node);
            }
        }

        private class AddScopeInfoVisitor : ExpressionVisitor
        {
            public ScopeInfo _current = null;

            public Dictionary<Address, HashSet<ScopeInfo>> _prevScopeByLabel = new Dictionary<Address, HashSet<ScopeInfo>>();
            public Dictionary<Address, ScopeInfo> _scopeAtLabel = new Dictionary<Address, ScopeInfo>();


            public Expression Process(Expression mainNode)
            {
                var node = ProcessInNewScope(mainNode).ResultExpression;

                foreach (var pair in _scopeAtLabel)
                {
                    if (_prevScopeByLabel.TryGetValue(pair.Key, out var prevs))
                    {
                        foreach (var prev in prevs)
                            pair.Value.AddPrevScope(prev);
                    }
                }

                return node;
            }

            private (Expression ResultExpression, ScopeInfo NewScope) ProcessInNewScope(Expression mainNode)
            {
                var scope = new ScopeInfo();
                scope.AddPrevScope(_current);
                _current = scope;

                var scopeBefore = _current;
                var node = Visit(mainNode);
                var scopeAfter = _current;

                if (scopeBefore == scopeAfter)
                {
                    scope.AddExpression(node);
                    return (scope, scope);
                }
                else
                {
                    if (node is BlockExpression block)
                        return (Expression.Block(block.Expressions.Prepend(scope)), scope);

                    return (Expression.Block(
                        new[]
                        {
                            scope,
                            node
                        }), scope);
                }
            }

            /// <inheritdoc />
            protected internal override Expression VisitBlock(BlockExpression node)
            {
                var result = new List<Expression>();

                foreach (var item in node.Expressions)
                {
                    var scopeBefore = _current;
                    var newItem = Visit(item);
                    var scopeAfter = _current;

                    if (scopeBefore == scopeAfter)
                        _current.AddExpression(newItem);
                    else
                        result.Add(newItem);
                }

                if (result.Count == 0)
                    return Expression.Empty;

                if (result.Count == 1)
                    return result[0];

                return Expression.Block(
                    result.SelectMany(
                        x =>
                        {
                            if (x is BlockExpression block)
                                return block.Expressions.AsEnumerable();
                            else
                                return new[] { x };
                        }));
            }

            /// <inheritdoc />
            protected internal override Expression VisitLabel(LabelExpression node)
            {
                var scope = new ScopeInfo();
                scope.AddPrevScope(_current);
                _scopeAtLabel[node.Address] = scope;

                _current = scope;
                return Expression.Block(new Expression[] { node, scope });
            }

            /// <inheritdoc />
            protected internal override Expression VisitGoto(GotoExpression node)
            {
                if (!(node.Address is ConstantExpression ce))
                    throw new NotSupportedException($"GotoExpression.Address is {node.Address.NodeType}.");

                if (!_prevScopeByLabel.TryGetValue(ce.Value, out var list))
                {
                    list = new HashSet<ScopeInfo>();
                    _prevScopeByLabel[ce.Value] = list;
                }
                list.Add(_current);

                _current = ScopeInfo.NoScope;
                return node;
            }

            /// <inheritdoc />
            protected internal override Expression VisitReturn(ReturnExpression node)
            {
                _current = ScopeInfo.NoScope;
                return node;
            }

            /// <inheritdoc />
            protected internal override Expression VisitConditional(ConditionalExpression node)
            {
                var prev = _current;

                var (testExpression, testScope) = ProcessInNewScope(node.Test);
                testScope.AddPrevScope(prev);
                var afterTestScope = _current;


                var afterIfTrueScope = afterTestScope;
                var ifTrueExpression = Expression.Empty;
                if (node.IfTrue != Expression.Empty)
                {
                    var (resultExpression, newScope) = ProcessInNewScope(node.IfTrue);
                    newScope.AddPrevScope(afterTestScope);
                    afterIfTrueScope = _current;
                    ifTrueExpression = resultExpression;
                }


                var afterIfFalseScope = afterTestScope;
                var ifFalseExpression = Expression.Empty;
                if (node.IfFalse != Expression.Empty)
                {
                    var (resultExpression, newScope) = ProcessInNewScope(node.IfFalse);
                    newScope.AddPrevScope(afterTestScope);
                    afterIfFalseScope = _current;
                    ifFalseExpression = resultExpression;
                }


                var resultScope = new ScopeInfo();
                resultScope.AddPrevScope(afterIfTrueScope);
                resultScope.AddPrevScope(afterIfFalseScope);


                _current = resultScope;
                return
                    Expression.Block(
                        new Expression[]
                        {
                            node.Update(testExpression, ifTrueExpression, ifFalseExpression),
                            resultScope
                        });
            }
        }
    }
}