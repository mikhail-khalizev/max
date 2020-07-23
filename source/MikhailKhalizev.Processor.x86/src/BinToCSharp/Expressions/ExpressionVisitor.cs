using System;
using System.Collections.ObjectModel;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
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

        /// <summary>
        /// Visits the children of the <see cref="BinaryExpression"/>.
        /// </summary>
        /// <param name="node">The expression to visit.</param>
        /// <returns>The modified expression, if it or any subexpression was modified;
        /// otherwise, returns the original expression.</returns>
        protected internal virtual Expression VisitBinary(BinaryExpression node)
        {
            return node.Update(Visit(node.Left), Visit(node.Right));
        }

        protected internal virtual Expression VisitDefault(Expression node)
        {
            return node;
        }
    }
}