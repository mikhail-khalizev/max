using System.Collections.Generic;
using System.Collections.ObjectModel;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class RemoveInnerBlockVisitor : ExpressionVisitor
    {
        /// <inheritdoc />
        protected internal override Expression VisitBlock(BlockExpression node)
        {
            List<Expression> list = null;
            
            var toProcess = new List<(int Index, ReadOnlyCollection<Expression> Expressions)>();
            toProcess.Add((0, node.Expressions));

            while (0 < toProcess.Count)
            {
                var cur = toProcess[^1];
                toProcess.RemoveAt(toProcess.Count - 1);

                for (var i = cur.Index; i < cur.Expressions.Count; i++)
                {
                    var ex = cur.Expressions[i];

                    if (ex is BlockExpression bl)
                    {
                        if (list == null)
                        {
                            list = new List<Expression>(cur.Expressions.Count + bl.Expressions.Count);
                            for (var j = 0; j < i; j++)
                                list.Add(node.Expressions[j]);
                        }

                        toProcess.Add((cur.Index + 1, cur.Expressions));
                        toProcess.Add((0, bl.Expressions));
                        break;
                    }
                    else
                    {
                        list?.Add(ex);
                    }
                }
            }


            if (list != null)
                return Expression.Block(list);
            else
                return node;
        }
    }
}