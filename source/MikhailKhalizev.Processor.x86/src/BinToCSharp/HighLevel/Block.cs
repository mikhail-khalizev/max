using System;
using System.Collections.Generic;
using System.Linq;
using MikhailKhalizev.Processor.x86.BinToCSharp.Expressions;
using MikhailKhalizev.Processor.x86.CSharpExecutor.Abstractions.Registers;
using MikhailKhalizev.Processor.x86.Decoder;
using MikhailKhalizev.Processor.x86.Utils;
using SharpDisasm.Udis86;

namespace MikhailKhalizev.Processor.x86.BinToCSharp.HighLevel
{
    // Obsolete.

    // public class Block
    // {
    //     private readonly Dictionary<int /* register index */, (RegisterInfo RegisterInfo, Expression Value)> _registers =
    //         new Dictionary<int, (RegisterInfo, Expression)>();
    // 
    // 
    //     public Expression GetRegister(RegisterInfo registerInfo)
    //     {
    //         if (!_registers.TryGetValue(registerInfo.Index, out var item))
    //         {
    //             var register = new RegisterExpression(registerInfo);
    //             _registers[registerInfo.Index] = (registerInfo, register);
    //             return register;
    //         }
    // 
    //         if (item.RegisterInfo == registerInfo)
    //             return item.Value;
    // 
    //         return Expression.Combine(
    //             registerInfo.LengthInBits,
    //             (item.Value,
    //             item.RegisterInfo.BitOffset - registerInfo.BitOffset,
    //             item.RegisterInfo.BitMask >> registerInfo.BitOffset));
    //     }
    // 
    //     public void SetRegister(RegisterInfo registerInfo, Expression expression)
    //     {
    //         if (!_registers.TryGetValue(registerInfo.Index, out var item))
    //         {
    //             _registers[registerInfo.Index] = (registerInfo, expression);
    //             return;
    //         }
    // 
    //         if (item.RegisterInfo == registerInfo)
    //         {
    //             _registers[registerInfo.Index] = (registerInfo, expression);
    //             return;
    //         }
    // 
    //         var combination = Expression.Combine(
    //             Math.Max(
    //                 item.RegisterInfo.LengthInBits + item.RegisterInfo.BitOffset,
    //                 registerInfo.LengthInBits + registerInfo.BitOffset),
    //             (item.Value, item.RegisterInfo.BitOffset, item.RegisterInfo.BitMask),
    //             (expression, registerInfo.BitOffset, registerInfo.BitMask));
    // 
    //         var resultRegisterInfo = new[] { registerInfo, item.RegisterInfo }
    //             .OrderBy(x => x.LengthInBits)
    //             .Concat(
    //                 RegisterInfo.Registers
    //                     .Where(x => x.Index == registerInfo.Index)
    //                     .OrderBy(x => x.LengthInBits)
    //             )
    //             .Where(x => x.BitOffset == 0)
    //             .First(x => combination.LengthInBits <= x.LengthInBits);
    // 
    //         _registers[registerInfo.Index] = (resultRegisterInfo, combination);
    //     }
    // }
}