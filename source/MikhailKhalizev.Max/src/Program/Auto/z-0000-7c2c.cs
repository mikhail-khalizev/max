using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9eddc154-ec00-49da-bdb1-d7eef1bcb9b2")]
        public void Method_0000_7c2c()
        {
            ii(0x7c2c, 3);    if(callw_up(0x7c36, 0x7)) return;         /* call 0x7c36 */
            ii(0x7c2f, 2);    if(jzw_func(0x7c70, 0x3f)) return;        /* jz 0x7c70 */
            ii(0x7c31, 3);    callw(0x7c36, 0x2);                       /* call 0x7c36 */
            ii(0x7c34, 3);    mov(si, 0x5b39);                          /* mov si, 0x5b39 */
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
