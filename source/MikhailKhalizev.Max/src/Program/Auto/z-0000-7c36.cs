using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c36-c16b2afb")]
        public void Method_0000_7c36()
        {
            ii(0x7c36, 1);    popw(bx);                                 /* pop bx */
            ii(0x7c37, 3);    mov(cx, memw_a16[cs, bx]);                /* mov cx, [cs:bx] */
            ii(0x7c3a, 4);    mov(bx, memw_a16[ds, 0xafa]);             /* mov bx, [0xafa] */
            ii(0x7c3e, 1);    inc(bx);                                  /* inc bx */
            ii(0x7c3f, 1);    inc(bx);                                  /* inc bx */
            ii(0x7c40, 4);    mov(memw_a16[ds, 0xafa], bx);             /* mov [0xafa], bx */
            ii(0x7c44, 2);    popw(memw_a16[ds, bx]);                   /* pop word [bx] */
            ii(0x7c46, 3);    pushw(0x3e8f);                            /* push 0x3e8f */
            ii(0x7c49, 4);    if(jmpw_a16_far_ind(ds, 0xaf2)) return;   /* jmp far word [0xaf2] */
        }
    }
}
