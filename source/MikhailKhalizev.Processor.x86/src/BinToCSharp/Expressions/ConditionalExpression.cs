namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ConditionalExpression : Expression
    {
        /// <summary>
        /// Gets the test of the conditional operation.
        /// </summary>
        public Expression Test { get; }

        /// <summary>
        /// Gets the expression to execute if the test evaluates to true.
        /// </summary>
        public Expression IfTrue { get; }

        /// <summary>
        /// Gets the expression to execute if the test evaluates to false.
        /// </summary>
        public Expression IfFalse { get; }

        protected internal ConditionalExpression(Expression test, Expression ifTrue)
            : this(test, ifTrue, Expression.Empty)
        { }

        protected internal ConditionalExpression(Expression test, Expression ifTrue, Expression ifFalse)
            : base(ExpressionType.Conditional, 0)
        {
            Test = test;
            IfTrue = ifTrue;
            IfFalse = ifFalse;
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitConditional(this);
        }

        /// <summary>
        /// Creates a new expression that is like this one, but using the
        /// supplied children. If all of the children are the same, it will
        /// return this expression.
        /// </summary>
        /// <param name="test">The <see cref="Test"/> property of the result.</param>
        /// <param name="ifTrue">The <see cref="IfTrue"/> property of the result.</param>
        /// <param name="ifFalse">The <see cref="IfFalse"/> property of the result.</param>
        /// <returns>This expression if no children changed, or an expression with the updated children.</returns>
        public ConditionalExpression Update(Expression test, Expression ifTrue, Expression ifFalse)
        {
            if (test == Test && ifTrue == IfTrue && ifFalse == IfFalse)
                return this;

            return Expression.Condition(test, ifTrue, ifFalse);
        }
    }
}