using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class RegisterExpression : Expression
    {
        public RegisterInfo RegisterInfo { get; }

        public RegisterExpression(RegisterInfo registerInfo)
            : base(ExpressionType.RegisterAccess, registerInfo.LengthInBits)
        {
            RegisterInfo = registerInfo;
        }

        public RegisterExpression Update(RegisterInfo registerInfo)
        {
            if (registerInfo == RegisterInfo)
                return this;

            return RegisterAccess(registerInfo);
        }

        /// <summary>
        /// Dispatches to the specific visit method for this node type.
        /// </summary>
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return visitor.VisitRegisterAccess(this);
        }
    }
}