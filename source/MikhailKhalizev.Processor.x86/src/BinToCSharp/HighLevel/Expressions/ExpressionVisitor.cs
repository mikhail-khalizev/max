using System;
using System.Collections.ObjectModel;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public abstract class ExpressionVisitor
    {
        protected ExpressionVisitor()
        { }

        public virtual Expression Visit(Expression node) => node?.Accept(this);

        public T VisitAndConvert<T>(T node, string callerName) where T : Expression
        {
            if (node == null)
                return null;

            node = Visit(node) as T;

            if (node == null)
                throw new InvalidOperationException($"MustRewriteToSameNode({callerName}, {typeof(T)})");

            return node;
        }

        public ReadOnlyCollection<Expression> Visit(ReadOnlyCollection<Expression> nodes)
        {
            Expression[] newNodes = null;

            for (int i = 0, n = nodes.Count; i < n; i++)
            {
                var node = Visit(nodes[i]);

                if (newNodes != null)
                {
                    newNodes[i] = node;
                }
                else if (!ReferenceEquals(node, nodes[i]))
                {
                    newNodes = new Expression[n];
                    for (var j = 0; j < i; j++)
                        newNodes[j] = nodes[j];
                    newNodes[i] = node;
                }
            }

            if (newNodes == null)
                return nodes;

            return new ReadOnlyCollection<Expression>(newNodes);
        }

        public static ReadOnlyCollection<T> Visit<T>(ReadOnlyCollection<T> nodes, Func<T, T> elementVisitor)
        {
            T[] newNodes = null;

            for (int i = 0, n = nodes.Count; i < n; i++)
            {
                var node = elementVisitor(nodes[i]);
                if (newNodes != null)
                {
                    newNodes[i] = node;
                }
                else if (!ReferenceEquals(node, nodes[i]))
                {
                    newNodes = new T[n];
                    for (var j = 0; j < i; j++)
                    {
                        newNodes[j] = nodes[j];
                    }
                    newNodes[i] = node;
                }
            }

            if (newNodes == null)
                return nodes;
            
            return new ReadOnlyCollection<T>(newNodes);
        }

        public ReadOnlyCollection<T> VisitAndConvert<T>(ReadOnlyCollection<T> nodes, string callerName) where T : Expression
        {
            T[] newNodes = null;

            for (int i = 0, n = nodes.Count; i < n; i++)
            {
                var node = Visit(nodes[i]) as T;
                if (node == null)
                    throw new InvalidOperationException($"MustRewriteToSameNode({callerName}, {typeof(T)})");

                if (newNodes != null)
                {
                    newNodes[i] = node;
                }
                else if (!object.ReferenceEquals(node, nodes[i]))
                {
                    newNodes = new T[n];
                    for (var j = 0; j < i; j++)
                        newNodes[j] = nodes[j];
                    newNodes[i] = node;
                }
            }

            if (newNodes == null)
                return nodes;
            
            return new ReadOnlyCollection<T>(newNodes);
        }

        // private Expression[] VisitArguments(IArgumentProvider nodes)
        // {
        //     return ExpressionVisitorUtils.VisitArguments(this, nodes);
        // }
        // 
        // private ParameterExpression[] VisitParameters(IParameterProvider nodes, string callerName)
        // {
        //     return ExpressionVisitorUtils.VisitParameters(this, nodes, callerName);
        // }
        // 
        // protected internal virtual Expression VisitBinary(BinaryExpression node)
        // {
        //     // Walk children in evaluation order: left, conversion, right
        //     return ValidateBinary(
        //         node,
        //         node.Update(
        //             Visit(node.Left),
        //             VisitAndConvert(node.Conversion, nameof(VisitBinary)),
        //             Visit(node.Right)
        //         )
        //     );
        // }
        // 
        // protected internal virtual Expression VisitBlock(BlockExpression node)
        // {
        //     Expression[] nodes = ExpressionVisitorUtils.VisitBlockExpressions(this, node);
        //     ReadOnlyCollection<ParameterExpression> v = VisitAndConvert(node.Variables, "VisitBlock");
        // 
        //     if (v == node.Variables && nodes == null)
        //     {
        //         return node;
        //     }
        // 
        //     return node.Rewrite(v, nodes);
        // }
        // 
        // protected internal virtual Expression VisitConditional(ConditionalExpression node)
        // {
        //     return node.Update(Visit(node.Test), Visit(node.IfTrue), Visit(node.IfFalse));
        // }
        // 
        // protected internal virtual Expression VisitConstant(ConstantExpression node)
        // {
        //     return node;
        // }
        // 
        // protected internal virtual Expression VisitGoto(GotoExpression node)
        // {
        //     return node.Update(VisitLabelTarget(node.Target), Visit(node.Value));
        // }

        protected internal virtual Expression VisitDefault(Expression node)
        {
            return node;
        }
    }
}