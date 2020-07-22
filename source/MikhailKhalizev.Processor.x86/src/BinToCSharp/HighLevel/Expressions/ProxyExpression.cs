namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public class ProxyExpression : Expression
    {
        public Expression Source { get; set; }

        /// <inheritdoc />
        public ProxyExpression() : base(0)
        { }

        public ProxyExpression(Expression source) : base(source.LengthInBits)
        {
            Source = source;
        }

        /// <inheritdoc />
        public override int LengthInBits => Source.LengthInBits;

        /// <inheritdoc />
        public override bool UsedAsInt
        {
            get => Source.UsedAsInt;
            set => Source.UsedAsInt = value;
        }

        /// <inheritdoc />
        public override bool UsedAsUint
        {
            get => Source.UsedAsUint;
            set => Source.UsedAsUint = value;
        }

        /// <inheritdoc />
        public override bool UsedAsPointer
        {
            get => Source.UsedAsPointer;
            set => Source.UsedAsPointer = value;
        }

        /// <inheritdoc />
        protected internal override Expression Accept(ExpressionVisitor visitor)
        {
            return Source.Accept(visitor);
        }
    }
}