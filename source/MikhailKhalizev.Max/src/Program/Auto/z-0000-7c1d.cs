using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x7c1d-82ef974a")]
        public void Method_0000_7c1d()
        {
            ii(0x7c1d, 3);    callw(0x7c36, 0x16);                      /* call 0x7c36 */
            ii(0x7c20, 3);    and(al, 0xe8);                            /* lock and al, 0xe8 */
            ii(0x7c23, 2);    adc(memw_a16[ds, bx + si], ax);           /* adc [bx+si], ax */
            ii(0x7c25, 2);    if(loopw_a16_func(0x7c48, 0x21)) return;  /* loop 0x7c48 */ /* Адрес перехода делит инструкцию в этой функции пополам. */
            ii(0x7c27, 3);    callw(0x7c36, 0xc);                       /* call 0x7c36 */
            ii(0x7c2a, 2);    mov(bl, 0x3f);                            /* mov bl, 0x3f */
            ii(0x7c2c, 3);    callw(0x7c36, 0x7);                       /* call 0x7c36 */
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
