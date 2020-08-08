using System;
using System.Collections.ObjectModel;
using MikhailKhalizev.Processor.x86.Decoder;

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


        protected internal virtual Expression VisitDefault(Expression node)
        {
            return node;
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

        protected virtual RegisterInfo VisitSegment(RegisterInfo segment)
        {
            return segment;
        }

        protected internal virtual Expression VisitMemoryAccess(MemoryAccessExpression node)
        {
            return node.Update(VisitSegment(node.Segment), Visit(node.Address));
        }

        protected virtual RegisterInfo VisitRegisterInfo(RegisterInfo registerInfo)
        {
            return registerInfo;
        }

        protected internal virtual Expression VisitRegisterAccess(RegisterExpression node)
        {
            return node.Update(VisitRegisterInfo(node.RegisterInfo));
        }

        protected internal virtual Expression VisitConditional(ConditionalExpression node)
        {
            return node.Update(Visit(node.Test), Visit(node.IfTrue), Visit(node.IfFalse));
        }

        protected internal virtual Expression VisitConstant(ConstantExpression node)
        {
            return node;
        }

        protected internal virtual Expression VisitGoto(GotoExpression node)
        {
            return node.Update(Visit(node.Address));
        }

        protected internal virtual Expression VisitReturn(ReturnExpression node)
        {
            return node;
        }

        protected internal virtual Expression VisitBlock(BlockExpression node)
        {
            var nodes = VisitAndConvert(node.Expressions, nameof(VisitBlock));
            if (nodes == node.Expressions)
                return node;

            return node.Update(nodes);
        }
    }
}