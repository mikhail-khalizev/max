using System;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    public static class ExpressionExtensions
    {
        // TODO Remove?
        // public static bool IsOpAssignment(this ExpressionType op)
        // {
        //     return op switch
        //     {
        //         ExpressionType.AddAssign => true,
        //         ExpressionType.SubtractAssign => true,
        //         ExpressionType.MultiplyAssign => true,
        //         ExpressionType.DivideAssign => true,
        //         ExpressionType.ModuloAssign => true,
        //         ExpressionType.PowerAssign => true,
        //         ExpressionType.AndAssign => true,
        //         ExpressionType.OrAssign => true,
        //         ExpressionType.RightShiftAssign => true,
        //         ExpressionType.LeftShiftAssign => true,
        //         ExpressionType.ExclusiveOrAssign => true,
        //         _ => false
        //     };
        // }
        // 
        // // Return the corresponding Op of an assignment op.
        // public static ExpressionType GetBinaryOpFromAssignmentOp(ExpressionType op)
        // {
        //     return op switch
        //     {
        //         ExpressionType.AddAssign => ExpressionType.Add,
        //         ExpressionType.SubtractAssign => ExpressionType.Subtract,
        //         ExpressionType.MultiplyAssign => ExpressionType.Multiply,
        //         ExpressionType.DivideAssign => ExpressionType.Divide,
        //         ExpressionType.ModuloAssign => ExpressionType.Modulo,
        //         ExpressionType.PowerAssign => ExpressionType.Power,
        //         ExpressionType.AndAssign => ExpressionType.And,
        //         ExpressionType.OrAssign => ExpressionType.Or,
        //         ExpressionType.RightShiftAssign => ExpressionType.RightShift,
        //         ExpressionType.LeftShiftAssign => ExpressionType.LeftShift,
        //         ExpressionType.ExclusiveOrAssign => ExpressionType.ExclusiveOr,
        //         _ => throw new ArgumentException(nameof(op))
        //     };
        // }
    }
}