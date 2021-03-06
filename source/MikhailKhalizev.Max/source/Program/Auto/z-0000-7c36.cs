using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c36-ae8da42b")]
        public void Method_0000_7c36()
        {
            ii(0x7c36, 1);  pop(bx);                                   /* pop bx */
            ii(0x7c37, 3);  mov(cx, memw[cs, bx]);                     /* mov cx, [cs:bx] */
            ii(0x7c3a, 4);  mov(bx, memw[ds, 0xafa]);                  /* mov bx, [0xafa] */
            ii(0x7c3e, 1);  inc(bx);                                   /* inc bx */
            ii(0x7c3f, 1);  inc(bx);                                   /* inc bx */
            ii(0x7c40, 4);  mov(memw[ds, 0xafa], bx);                  /* mov [0xafa], bx */
            ii(0x7c44, 2);  pop(memw[ds, bx]);                         /* pop word [bx] */
        }
    }
}
