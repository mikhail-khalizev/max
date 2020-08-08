namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class GotoExpression : Expression
    {
        public Expression Address { get; }

        protected internal GotoExpression(Expression address)
            : base(ExpressionType.Goto, 0)
        {
            Address = address;
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitGoto(this);
        }

        /// <summary>
        /// Creates a new expression that is like this one, but using the
        /// supplied children. If all of the children are the same, it will
        /// return this expression.
        /// </summary>
        /// <returns>This expression if no children changed, or an expression with the updated children.</returns>
        public GotoExpression Update(Expression address)
        {
            if (address == Address)
                return this;
            
            return Expression.Goto(address);
        }
    }
}