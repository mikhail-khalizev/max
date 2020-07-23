namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    /// <summary>
    /// Describes the node types for the nodes of an expression tree.
    /// </summary>
    public enum ExpressionType
    {
        /// <summary>
        /// A node that represents arithmetic addition without overflow checking.
        /// </summary>
        Add,

        /// <summary>
        /// A node that represents a bitwise AND operation.
        /// </summary>
        And,

        /// <summary>
        /// A node that represents a short-circuiting conditional AND operation.
        /// </summary>
        /// <remarks>
        /// Represents a conditional AND operation that evaluates the second operand only if the first operand evaluates to true.
        /// </remarks>
        AndAlso,

        /// <summary>
        /// A node that represents a method call.
        /// </summary>
        Call,
        
        /// <summary>
        /// A node that represents a conditional operation.
        /// </summary>
        Conditional,

        /// <summary>
        /// A node that represents an expression that has a constant value.
        /// </summary>
        Constant,
        
        /// <summary>
        /// A node that represents a cast or conversion operation. If the operation is a numeric conversion, it overflows silently if the converted value does not fit the target type.
        /// </summary>
        Convert,
        
        /// <summary>
        /// A node that represents arithmetic division.
        /// </summary>
        Divide,
        
        /// <summary>
        /// A node that represents an equality comparison.
        /// </summary>
        Equal,
        
        /// <summary>
        /// A node that represents a bitwise XOR operation.
        /// </summary>
        ExclusiveOr,
        
        /// <summary>
        /// A node that represents a "greater than" numeric comparison.
        /// </summary>
        GreaterThan,

        /// <summary>
        /// A node that represents a "greater than or equal" numeric comparison.
        /// </summary>
        GreaterThanOrEqual,
        
        /// <summary>
        /// A node that represents a bitwise left-shift operation.
        /// </summary>
        LeftShift,
        
        /// <summary>
        /// A node that represents a "less than" numeric comparison.
        /// </summary>
        LessThan,

        /// <summary>
        /// A node that represents a "less than or equal" numeric comparison.
        /// </summary>
        LessThanOrEqual,
        
        // /// <summary>
        // /// A node that represents reading from a field or property.
        // /// </summary>
        // MemberAccess,
        
        /// <summary>
        /// A node that represents an arithmetic remainder operation.
        /// </summary>
        Modulo,
        
        /// <summary>
        /// A node that represents arithmetic multiplication without overflow checking.
        /// </summary>
        Multiply,
        
        /// <summary>
        /// A node that represents an arithmetic negation operation.
        /// </summary>
        Negate,
        
        /// <summary>
        /// A node that represents a bitwise complement operation.
        /// </summary>
        Not,
        
        /// <summary>
        /// A node that represents an inequality comparison.
        /// </summary>
        NotEqual,

        /// <summary>
        /// A node that represents a bitwise OR operation.
        /// </summary>
        Or,

        /// <summary>
        /// A node that represents a short-circuiting conditional OR operation.
        /// </summary>
        /// <seealso cref="AndAlso"/>
        OrElse,
        
        // /// <summary>
        // /// A node that represents a reference to a parameter or variable defined in the context of the expression.
        // /// </summary>
        // Parameter,
        
        /// <summary>
        /// A node that represents raising a number to a power.
        /// </summary>
        Power,
        
        /// <summary>
        /// A node that represents a bitwise right-shift operation.
        /// </summary>
        RightShift,
        
        /// <summary>
        /// A node that represents arithmetic subtraction without overflow checking.
        /// </summary>
        Subtract,
        
        /// <summary>
        /// A node that represents an assignment.
        /// </summary>
        Assign,

        /// <summary>
        /// A node that represents a block of expressions.
        /// </summary>
        Block,
        
        /// <summary>
        /// A node that represents a unary decrement.
        /// </summary>
        Decrement,
        
        /// <summary>
        /// A node that represents a goto.
        /// </summary>
        Goto,
        
        /// <summary>
        /// A node that represents a unary increment.
        /// </summary>
        Increment,
        
        /// <summary>
        /// A node that represents a label.
        /// </summary>
        Label,
        
        /// <summary>
        /// A node that represents a loop.
        /// </summary>
        Loop,

        /// <summary>
        /// A node that represents a switch operation.
        /// </summary>
        Switch,

        // TODO Remove?
        // /// <summary>
        // /// A node that represents an arithmetic addition compound assignment without overflow checking.
        // /// </summary>
        // AddAssign,
        // 
        // /// <summary>
        // /// A node that represents a bitwise AND compound assignment.
        // /// </summary>
        // AndAssign,
        // 
        // /// <summary>
        // /// A node that represents an arithmetic division compound assignment .
        // /// </summary>
        // DivideAssign,
        // 
        // /// <summary>
        // /// A node that represents a bitwise XOR compound assignment.
        // /// </summary>
        // ExclusiveOrAssign,
        // 
        // /// <summary>
        // /// A node that represents a bitwise left-shift compound assignment.
        // /// </summary>
        // LeftShiftAssign,
        // 
        // /// <summary>
        // /// A node that represents an arithmetic remainder compound assignment.
        // /// </summary>
        // ModuloAssign,
        // 
        // /// <summary>
        // /// A node that represents arithmetic multiplication compound assignment without overflow checking.
        // /// </summary>
        // MultiplyAssign,
        // 
        // /// <summary>
        // /// A node that represents a bitwise OR compound assignment.
        // /// </summary>
        // OrAssign,
        // 
        // /// <summary>
        // /// A node that represents raising a number to a power compound assignment.
        // /// </summary>
        // PowerAssign,
        // 
        // /// <summary>
        // /// A node that represents a bitwise right-shift compound assignment.
        // /// </summary>
        // RightShiftAssign,
        // 
        // /// <summary>
        // /// A node that represents arithmetic subtraction compound assignment without overflow checking.
        // /// </summary>
        // SubtractAssign,
        // 
        // /// <summary>
        // /// A node that represents an unary prefix increment.
        // /// </summary>
        // PreIncrementAssign,
        // 
        // /// <summary>
        // /// A node that represents an unary prefix decrement.
        // /// </summary>
        // PreDecrementAssign,
        // 
        // /// <summary>
        // /// A node that represents an unary postfix increment.
        // /// </summary>
        // PostIncrementAssign,
        // 
        // /// <summary>
        // /// A node that represents an unary postfix decrement.
        // /// </summary>
        // PostDecrementAssign,
        
        /// <summary>
        /// A node that represents a true condition value.
        /// </summary>
        IsTrue,
        /// <summary>
        /// A node that represents a false condition value.
        /// </summary>
        IsFalse,

        Todo_Remove,
    }
}