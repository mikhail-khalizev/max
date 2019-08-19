using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5476-c16b2afb")]
        public void Method_0000_5476()
        {
            ii(0x5476, 1);    popw(bx);                                 /* pop bx */
            ii(0x5477, 3);    mov(cx, memw_a16[cs, bx]);                /* mov cx, [cs:bx] */
            ii(0x547a, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x547e, 1);    inc(bx);                                  /* inc bx */
            ii(0x547f, 1);    inc(bx);                                  /* inc bx */
            ii(0x5480, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x5484, 2);    popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x5486, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x5489, 4);    if(jmpw_a16_far_ind(ds, 0xaf2)) return;   /* jmp far word [0xaf2] */
        }
    }
}
