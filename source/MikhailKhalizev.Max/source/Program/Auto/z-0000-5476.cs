using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5476-ae8da42b")]
        public void Method_0000_5476()
        {
            ii(0x5476, 1);  pop(bx);                                   /* pop bx */
            ii(0x5477, 3);  mov(cx, memw[cs, bx]);                     /* mov cx, [cs:bx] */
            ii(0x547a, 4);  mov(bx, memw[ds, 0xafa]);                  /* mov bx, [0xafa] */
            ii(0x547e, 1);  inc(bx);                                   /* inc bx */
            ii(0x547f, 1);  inc(bx);                                   /* inc bx */
            ii(0x5480, 4);  mov(memw[ds, 0xafa], bx);                  /* mov [0xafa], bx */
            ii(0x5484, 2);  pop(memw[ds, bx]);                         /* pop word [bx] */
        }
    }
}
