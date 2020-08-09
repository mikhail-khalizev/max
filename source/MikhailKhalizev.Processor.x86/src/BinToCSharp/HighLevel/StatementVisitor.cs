using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class StatementVisitor : ExpressionVisitor
    {
        private int _statement = 0;

        /// <inheritdoc />
        protected internal override Expression VisitBinary(BinaryExpression node)
        {
            _statement++;

            Expression r;
            if (_statement == 1)
            {
                r = VisitStatement(node);
            }
            else
            {
                r = VisitBinaryInternal(node);
            }

            _statement--;

            return r;
        }

        protected virtual Expression VisitBinaryInternal(BinaryExpression node)
        {
            return base.VisitBinary(node);
        }

        protected virtual Expression VisitStatement(Expression node)
        {
            return Visit(node);
        }
    }
}