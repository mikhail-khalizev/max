namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ParameterExpression : Expression
    {
        public string Name { get; }

        protected internal ParameterExpression(string name, int lengthInBits)
            : base(ExpressionType.Parameter, lengthInBits)
        {
            Name = name;
        }
        
        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitParameter(this);
        }
    }
}