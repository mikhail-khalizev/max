namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ReturnExpression : Expression
    {
        protected internal ReturnExpression()
            : base(ExpressionType.Goto, 0)
        { }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitReturn(this);
        }
    }
}