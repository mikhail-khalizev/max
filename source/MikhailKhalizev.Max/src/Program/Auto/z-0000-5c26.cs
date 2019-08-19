using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5c26-c16b2afb")]
        public void Method_0000_5c26()
        {
            ii(0x5c26, 1);    popw(bx);                                 /* pop bx */
            ii(0x5c27, 3);    mov(cx, memw_a16[cs, bx]);                /* mov cx, [cs:bx] */
            ii(0x5c2a, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x5c2e, 1);    inc(bx);                                  /* inc bx */
            ii(0x5c2f, 1);    inc(bx);                                  /* inc bx */
            ii(0x5c30, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x5c34, 2);    popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x5c36, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x5c39, 4);    if(jmpw_a16_far_ind(ds, 0xaf2)) return;   /* jmp far word [0xaf2] */
        }
    }
}
