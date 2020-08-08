using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Text;
using MikhailKhalizev.Processor.x86.BinToCSharp.LowLevel;
using MikhailKhalizev.Processor.x86.Decoder;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.Expressions
{
    public class ExpressionStringBuilder : ExpressionVisitor
    {
        [Flags]
        protected enum Flow
        {
            None,
            Space,
            NewLine,
            NewLineWithIndent,

            Break = 0x8000 // newline if column > MaxColumn
        };

        private const int Tab = 4;
        private const int MaxColumn = 120;

        private readonly TextWriter _out;
        private int _column;

        private readonly Stack<int> _stack = new Stack<int>();
        private int _delta;
        private Flow _flow;

        private Dictionary<ParameterExpression, int> _paramIds;

        protected ExpressionStringBuilder(TextWriter file)
        {
            _out = file;
        }

        protected int Base => _stack.Count > 0 ? _stack.Peek() : 0;

        protected int Delta => _delta;

        protected int Depth => Base + Delta;

        protected void Indent()
        {
            _delta += Tab;
        }

        protected void Dedent()
        {
            _delta -= Tab;
        }

        protected void NewLine()
        {
            _flow = Flow.NewLine;
        }

        private static int GetId<T>(T e, ref Dictionary<T, int> ids)
        {
            if (ids == null)
            {
                ids = new Dictionary<T, int>();
                ids.Add(e, 1);
                return 1;
            }
            else
            {
                int id;
                if (!ids.TryGetValue(e, out id))
                {
                    // e is met the first time
                    id = ids.Count + 1;
                    ids.Add(e, id);
                }

                return id;
            }
        }

        private int GetParamId(ParameterExpression p)
        {
            Debug.Assert(string.IsNullOrEmpty(p.Name));
            return GetId(p, ref _paramIds);
        }

        /// <summary>
        /// Output a given expression tree to a string.
        /// </summary>
        public static string ExpressionToString(Expression node)
        {
            Debug.Assert(node != null);

            using StringWriter writer = new StringWriter(CultureInfo.CurrentCulture);
            WriteTo(node, writer);
            return writer.ToString();
        }

        /// <summary>
        /// Write out the given AST
        /// </summary>
        public static void WriteTo(Expression node, TextWriter writer)
        {
            Debug.Assert(node != null);
            Debug.Assert(writer != null);

            new ExpressionStringBuilder(writer).WriteTo(node);
        }

        private void WriteTo(Expression node)
        {
            Visit(node);
            Debug.Assert(_stack.Count == 0);
        }

        #region The printing code

        private void Out(string s)
        {
            Out(Flow.None, s, Flow.None);
        }

        private void Out(Flow before, string s)
        {
            Out(before, s, Flow.None);
        }

        private void Out(string s, Flow after)
        {
            Out(Flow.None, s, after);
        }

        private void Out(Flow before, string s, Flow after)
        {
            switch (GetFlow(before))
            {
                case Flow.None:
                    break;
                case Flow.Space:
                    Write(" ");
                    break;
                case Flow.NewLine:
                    WriteLine();
                    Write(new string(' ', Depth));
                    break;
                case Flow.NewLineWithIndent:
                    WriteLine();
                    Write(new string(' ', Depth + Tab));
                    break;
            }

            Write(s);
            _flow = after;
        }

        private void WriteLine()
        {
            _out.WriteLine();
            _column = 0;
        }

        private void Write(string s)
        {
            _out.Write(s);
            _column += s.Length;
        }

        private Flow GetFlow(Flow flow)
        {
            Flow last = CheckBreak(_flow);
            flow = CheckBreak(flow);

            // Get the biggest flow that is requested None < Space < NewLine
            return (Flow) System.Math.Max((int) last, (int) flow);
        }

        private Flow CheckBreak(Flow flow)
        {
            if ((flow & Flow.Break) != 0)
            {
                if (_column > (MaxColumn + Depth))
                {
                    flow = Flow.NewLineWithIndent;
                }
                else
                {
                    flow &= ~Flow.Break;
                }
            }

            return flow;
        }

        #endregion

        #region The AST Output

        private void VisitExpressions<T>(char open, IReadOnlyList<T> expressions) where T : Expression
        {
            VisitExpressions<T>(open, ',', expressions);
        }

        private void VisitExpressions<T>(char open, char separator, IReadOnlyList<T> expressions) where T : Expression
        {
            VisitExpressions(open, separator, expressions, e => Visit(e));
        }

        private void VisitExpressions<T>(char open, char separator, IReadOnlyList<T> expressions, Action<T> visit)
        {
            Out(open.ToString());

            if (expressions != null)
            {
                Indent();
                bool isFirst = true;
                foreach (T e in expressions)
                {
                    if (isFirst)
                    {
                        if (open == '{' || expressions.Count > 1)
                        {
                            NewLine();
                        }

                        isFirst = false;
                    }
                    else
                    {
                        Out(separator.ToString(), Flow.NewLine);
                    }

                    visit(e);
                }

                Out(separator.ToString());
                Dedent();
            }

            char close;
            switch (open)
            {
                case '(':
                    close = ')';
                    break;
                case '{':
                    close = '}';
                    break;
                case '[':
                    close = ']';
                    break;
                default: throw new InvalidOperationException($"Unexpected '{open}'.");
            }

            if (open == '{')
            {
                NewLine();
            }

            Out(close.ToString(), Flow.Break);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        protected internal override Expression VisitBinary(BinaryExpression node)
        {
            bool parenthesizeLeft = NeedsParentheses(node, node.Left);
            bool parenthesizeRight = NeedsParentheses(node, node.Right);

            var numberType = "";
            switch (node.NumberType)
            {
                case NumberType.Irrelevant:
                    numberType = "";
                    break;
                case NumberType.UnsignedInteger:
                    numberType = "u";
                    break;
                case NumberType.SignedInteger:
                    numberType = "s";
                    break;
                case NumberType.Float32:
                    numberType = "f32";
                    break;
                case NumberType.Float64:
                    numberType = "f64";
                    break;
                default:
                    throw new NotSupportedException($"node: {node}, node.NumberType: {node.NumberType}");
            }

            string op;
            Flow beforeOp = Flow.Space;
            switch (node.NodeType)
            {
                case ExpressionType.Assign:
                    op = "=";
                    break;
                case ExpressionType.Equal:
                    op = "==";
                    break;
                case ExpressionType.NotEqual:
                    op = "!=";
                    break;
                case ExpressionType.AndAlso:
                    op = "&&";
                    beforeOp = Flow.Break | Flow.Space;
                    break;
                case ExpressionType.OrElse:
                    op = "||";
                    beforeOp = Flow.Break | Flow.Space;
                    break;
                case ExpressionType.GreaterThan:
                    op = ">";
                    break;
                case ExpressionType.LessThan:
                    op = "<";
                    break;
                case ExpressionType.GreaterThanOrEqual:
                    op = ">=";
                    break;
                case ExpressionType.LessThanOrEqual:
                    op = "<=";
                    break;
                case ExpressionType.Add:
                    op = "+";
                    break;
                case ExpressionType.Subtract:
                    op = "-";
                    break;
                case ExpressionType.Divide:
                    op = "/";
                    break;
                case ExpressionType.Modulo:
                    op = "%";
                    break;
                case ExpressionType.Multiply:
                    op = "*";
                    break;
                case ExpressionType.LeftShift:
                    op = "<<";
                    break;
                case ExpressionType.RightShift:
                    op = ">>";
                    break;
                case ExpressionType.And:
                    op = "&";
                    break;
                case ExpressionType.Or:
                    op = "|";
                    break;
                case ExpressionType.ExclusiveOr:
                    op = "^";
                    break;
                case ExpressionType.Power:
                    op = "**";
                    break;

                default:
                    throw new InvalidOperationException();
            }

            if (node.NodeType == ExpressionType.LeftShift && node.LengthInBits == node.Left.LengthInBits)
            {
                // skip add numberType
            }
            else
                op += numberType;

            if (parenthesizeLeft)
            {
                Out("(", Flow.None);
            }

            Visit(node.Left);
            if (parenthesizeLeft)
            {
                Out(Flow.None, ")", Flow.Break);
            }

            Out(beforeOp, op, Flow.Space | Flow.Break);

            if (parenthesizeRight)
            {
                Out("(", Flow.None);
            }

            Visit(node.Right);
            if (parenthesizeRight)
            {
                Out(Flow.None, ")", Flow.Break);
            }

            return node;
        }

        /// <inheritdoc />
        protected override RegisterInfo VisitRegisterInfo(RegisterInfo registerInfo)
        {
            Out(registerInfo.Name);
            return registerInfo;
        }


        private static bool IsSimpleExpression(Expression node)
        {
            var binary = node as BinaryExpression;
            if (binary != null)
            {
                return !(binary.Left is BinaryExpression || binary.Right is BinaryExpression);
            }

            return false;
        }

        protected internal override Expression VisitConditional(ConditionalExpression node)
        {
            if (IsSimpleExpression(node.Test))
            {
                Out("If (");
                Visit(node.Test);
                Out(") {", Flow.NewLine);
            }
            else
            {
                Out("If (", Flow.NewLine);
                Indent();
                Visit(node.Test);
                Dedent();
                Out(Flow.NewLine, ") {", Flow.NewLine);
            }

            Indent();
            Visit(node.IfTrue);
            Dedent();

            if (node.IfFalse != Expression.Empty)
            {
                Out(Flow.NewLine, "} .Else {", Flow.NewLine);
                Indent();
                Visit(node.IfFalse);
                Dedent();
            }

            Out(Flow.NewLine, "}");

            return node;
        }

        protected internal override Expression VisitConstant(ConstantExpression node)
        {
            var value = node.Value;

            switch (node.ConstantType)
            {
                case ConstantType.Hex:
                    Out($"0x{value:x}");
                    break;

                default:
                    Out(value.ToString());
                    break;
            }

            return node;
        }

        /// <inheritdoc />
        protected internal override Expression VisitMemoryAccess(MemoryAccessExpression node)
        {
            Out($"mem{X86Instruction.GetSizeSuffixByBits(node.LengthInBits)}[");
            Visit(node.Address);
            Out("]");
            return node;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private static bool NeedsParentheses(Expression parent, Expression child)
        {
            Debug.Assert(parent != null);
            if (child == null)
                return false;

            int childOpPrec = GetOperatorPrecedence(child);
            int parentOpPrec = GetOperatorPrecedence(parent);

            if (childOpPrec == parentOpPrec)
            {
                // When parent op and child op has the same precedence,
                // we want to be a little conservative to have more clarity.
                // Parentheses are not needed if
                // 1) Both ops are &&, ||, &, |, or ^, all of them are the only
                // op that has the precedence.
                // 2) Parent op is + or *, e.g. x + (y - z) can be simplified to
                // x + y - z.
                // 3) Parent op is -, / or %, and the child is the left operand.
                // In this case, if left and right operand are the same, we don't
                // remove parenthesis, e.g. (x + y) - (x + y)
                //
                switch (parent.NodeType)
                {
                    case ExpressionType.AndAlso:
                    case ExpressionType.OrElse:
                    case ExpressionType.And:
                    case ExpressionType.Or:
                    case ExpressionType.ExclusiveOr:
                        // Since these ops are the only ones on their precedence,
                        // the child op must be the same.
                        Debug.Assert(child.NodeType == parent.NodeType);
                        // We remove the parenthesis, e.g. x && y && z
                        return false;
                    case ExpressionType.Add:
                    case ExpressionType.Multiply:
                        return false;
                    case ExpressionType.Subtract:
                    case ExpressionType.Divide:
                    case ExpressionType.Modulo:
                        BinaryExpression binary = parent as BinaryExpression;
                        Debug.Assert(binary != null);
                        // Need to have parenthesis for the right operand.
                        return child == binary.Right;
                }

                return true;
            }

            // Special case: negate of a constant needs parentheses, to
            // disambiguate it from a negative constant.
            if (child != null && child.NodeType == ExpressionType.Constant &&
                (parent.NodeType == ExpressionType.Negate))
            {
                return true;
            }

            // If the parent op has higher precedence, need parentheses for the child.
            return childOpPrec < parentOpPrec;
        }

        // the greater the higher
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        private static int GetOperatorPrecedence(Expression node)
        {
            // Roughly matches C# operator precedence, with some additional
            // operators. Also things which are not binary/unary expressions,
            // such as conditional and type testing, don't use this mechanism.
            switch (node.NodeType)
            {
                // Assignment
                case ExpressionType.Assign:
                    return 1;

                // Conditional (?:) would go here

                // Conditional OR
                case ExpressionType.OrElse:
                    return 2;

                // Conditional AND
                case ExpressionType.AndAlso:
                    return 3;

                // Logical OR
                case ExpressionType.Or:
                    return 4;

                // Logical XOR
                case ExpressionType.ExclusiveOr:
                    return 5;

                // Logical AND
                case ExpressionType.And:
                    return 6;

                // Equality
                case ExpressionType.Equal:
                case ExpressionType.NotEqual:
                    return 7;

                // Relational, type testing
                case ExpressionType.GreaterThan:
                case ExpressionType.LessThan:
                case ExpressionType.GreaterThanOrEqual:
                case ExpressionType.LessThanOrEqual:
                    return 8;

                // Shift
                case ExpressionType.LeftShift:
                case ExpressionType.RightShift:
                    return 9;

                // Additive
                case ExpressionType.Add:
                case ExpressionType.Subtract:
                    return 10;

                // Multiplicative
                case ExpressionType.Divide:
                case ExpressionType.Modulo:
                case ExpressionType.Multiply:
                    return 11;

                // Unary
                case ExpressionType.Negate:
                case ExpressionType.Not:
                case ExpressionType.Convert:
                    return 12;

                // Power, which is not in C#
                // But VB/Python/Ruby put it here, above unary.
                case ExpressionType.Power:
                    return 13;

                // Primary, which includes all other node types:
                //   member access, calls, indexing, new.
                default:
                    return 14;

                // These aren't expressions, so never need parentheses:
                //   constants, variables
                case ExpressionType.Constant:
                    return 15;
            }
        }

        private void ParenthesizedVisit(Expression parent, Expression nodeToVisit)
        {
            if (NeedsParentheses(parent, nodeToVisit))
            {
                Out("(");
                Visit(nodeToVisit);
                Out(")");
            }
            else
            {
                Visit(nodeToVisit);
            }
        }

        // protected internal override Expression VisitMethodCall(MethodCallExpression node)
        // {
        //     Out("Call ");
        //     if (node.Object != null)
        //     {
        //         ParenthesizedVisit(node, node.Object);
        //     }
        //     else if (node.Method.DeclaringType != null)
        //     {
        //         Out(node.Method.DeclaringType.ToString());
        //     }
        //     else
        //     {
        //         Out("<UnknownType>");
        //     }
        //     Out(".");
        //     Out(node.Method.Name);
        //     VisitExpressions('(', node.Arguments);
        //     return node;
        // }

        // protected internal override Expression VisitUnary(UnaryExpression node)
        // {
        //     switch (node.NodeType)
        //     {
        //         case ExpressionType.Convert:
        //             Out("(" + node.Type.ToString() + ")");
        //             break;
        //         case ExpressionType.Not:
        //             Out(node.Type == typeof(bool) ? "!" : "~");
        //             break;
        //         case ExpressionType.OnesComplement:
        //             Out("~");
        //             break;
        //         case ExpressionType.Negate:
        //             Out("-");
        //             break;
        //     }
        // 
        //     ParenthesizedVisit(node, node.Operand);
        //     return node;
        // }

        protected internal override Expression VisitBlock(BlockExpression node)
        {
            Out("block", Flow.Space);
            VisitExpressions('{', ';', node.Expressions);
            return node;
        }

        protected internal override Expression VisitParameter(ParameterExpression node)
        {
            // Have '$' for the DebugView of ParameterExpressions
            Out("$");
            if (string.IsNullOrEmpty(node.Name))
            {
                // If no name if provided, generate a name as $var1, $var2.
                // No guarantee for not having name conflicts with user provided variable names.
                //
                int id = GetParamId(node);
                Out("var" + id);
            }
            else
            {
                Out(GetDisplayName(node.Name));
            }
            return node;
        }

        protected internal override Expression VisitLabel(LabelExpression node)
        {
            Out($"label {(int)node.Address}");
            return node;
        }

        protected internal override Expression VisitGoto(GotoExpression node)
        {
            Out("goto", Flow.Space);
            Visit(node.Address);
            return node;
        }

        protected internal override Expression VisitReturn(ReturnExpression node)
        {
            Out("return");
            return node;
        }

        protected internal override Expression VisitDebugInfo(DebugInfoExpression node)
        {
            Out($"DebugInfo {node.DebugInfoType}: {node.GetAsText()}");
            return node;
        }

        // protected internal override Expression VisitLoop(LoopExpression node)
        // {
        //     Out(".Loop", Flow.Space);
        //     if (node.ContinueLabel != null)
        //     {
        //         DumpLabel(node.ContinueLabel);
        //     }
        //     Out(" {", Flow.NewLine);
        //     Indent();
        //     Visit(node.Body);
        //     Dedent();
        //     Out(Flow.NewLine, "}");
        //     if (node.BreakLabel != null)
        //     {
        //         Out("", Flow.NewLine);
        //         DumpLabel(node.BreakLabel);
        //     }
        //     return node;
        // }

        // protected override SwitchCase VisitSwitchCase(SwitchCase node)
        // {
        //     foreach (Expression test in node.TestValues)
        //     {
        //         Out(".Case (");
        //         Visit(test);
        //         Out("):", Flow.NewLine);
        //     }
        //     Indent(); Indent();
        //     Visit(node.Body);
        //     Dedent(); Dedent();
        //     NewLine();
        //     return node;
        // }

        // protected internal override Expression VisitSwitch(SwitchExpression node)
        // {
        //     Out(".Switch ");
        //     Out("(");
        //     Visit(node.SwitchValue);
        //     Out(") {", Flow.NewLine);
        //     Visit(node.Cases, VisitSwitchCase);
        //     if (node.DefaultBody != null)
        //     {
        //         Out(".Default:", Flow.NewLine);
        //         Indent(); Indent();
        //         Visit(node.DefaultBody);
        //         Dedent(); Dedent();
        //         NewLine();
        //     }
        //     Out("}");
        //     return node;
        // }

        // private void DumpLabel(LabelTarget target)
        // {
        //     Out(string.Format(CultureInfo.CurrentCulture, ".LabelTarget {0}:", GetLabelTargetName(target)));
        // }

        // private string GetLabelTargetName(LabelTarget target)
        // {
        //     if (string.IsNullOrEmpty(target.Name))
        //     {
        //         // Create the label target name as #Label1, #Label2, etc.
        //         return "#Label" + GetLabelTargetId(target);
        //     }
        //     else
        //     {
        //         return GetDisplayName(target.Name);
        //     }
        // }

        /// <summary>
        /// Return true if the input string contains any whitespace character.
        /// Otherwise false.
        /// </summary>
        private static bool ContainsWhiteSpace(string name)
        {
            foreach (char c in name)
            {
                if (char.IsWhiteSpace(c))
                {
                    return true;
                }
            }

            return false;
        }

        private static string QuoteName(string name)
        {
            return "'" + name + "'";
        }

        private static string GetDisplayName(string name)
        {
            if (ContainsWhiteSpace(name))
            {
                // if name has whitespace in it, quote it
                return QuoteName(name);
            }
            else
            {
                return name;
            }
        }

        #endregion
    }
}