using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c26-ae8da42b")]
        public void Method_0000_5c26()
        {
            ii(0x5c26, 1);  pop(bx);                                   /* pop bx */
            ii(0x5c27, 3);  mov(cx, memw[cs, bx]);                     /* mov cx, [cs:bx] */
            ii(0x5c2a, 4);  mov(bx, memw[ds, 0xafa]);                  /* mov bx, [0xafa] */
            ii(0x5c2e, 1);  inc(bx);                                   /* inc bx */
            ii(0x5c2f, 1);  inc(bx);                                   /* inc bx */
            ii(0x5c30, 4);  mov(memw[ds, 0xafa], bx);                  /* mov [0xafa], bx */
            ii(0x5c34, 2);  pop(memw[ds, bx]);                         /* pop word [bx] */
        }
    }
}
