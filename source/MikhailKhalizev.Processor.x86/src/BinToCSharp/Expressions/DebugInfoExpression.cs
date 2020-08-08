namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public abstract class DebugInfoExpression : Expression
    {
        protected internal DebugInfoExpression()
            : base(ExpressionType.DebugInfo, 0)
        { }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitDebugInfo(this);
        }

        public abstract string GetAsText();
        public abstract string DebugInfoType { get; }
    }
}