namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class LabelExpression : Expression
    {
        public Address Address { get; }

        protected internal LabelExpression(Address address)
            : base(ExpressionType.Goto, 0)
        {
            Address = address;
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitLabel(this);
        }
    }
}