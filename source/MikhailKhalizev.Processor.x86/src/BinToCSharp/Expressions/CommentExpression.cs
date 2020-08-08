namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class CommentExpression : DebugInfoExpression
    {
        /// <inheritdoc />
        public override string DebugInfoType => "Comment";

        public string Comment { get; }

        protected internal CommentExpression(string comment)
        {
            Comment = comment;
        }

        /// <inheritdoc />
        public override string GetAsText()
        {
            return Comment;
        }
    }
}