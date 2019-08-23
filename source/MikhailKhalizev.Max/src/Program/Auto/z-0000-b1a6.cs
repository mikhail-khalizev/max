using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb1a6-bab2f245")]
        public void Method_0000_b1a6()
        {
            ii(0xb1a6, 6);    movzx(eax, memw_a16[ds, 0xdfa]);          /* movzx eax, word [0xdfa] */
            ii(0xb1ac, 4);    shl(eax, 0xa);                            /* shl eax, 0xa */
            ii(0xb1b0, 4);    mov(memd_a16[ds, 0xaa8], eax);            /* mov [0xaa8], eax */
            ii(0xb1b4, 2);    if(jzw_func(0xb19b, -0x1b)) return;       /* jz 0xb19b */
            ii(0xb1b6, 4);    mov(eax, memd_a16[ds, 0x98]);             /* mov eax, [0x98] */
            ii(0xb1ba, 5);    mov(memd_a16[cs, 0x7bb2], eax);           /* mov [cs:0x7bb2], eax */
            ii(0xb1bf, 5);    cmp(memb_a16[ds, 0xdff], 0);              /* cmp byte [0xdff], 0x0 */
            ii(0xb1c4, 2);    if(jnzw_func(0xb19b, -0x2b)) return;      /* jnz 0xb19b */
            ii(0xb1c6, 1);    pushw(si);                                /* push si */
            ii(0xb1c7, 1);    pushw(di);                                /* push di */
            ii(0xb1c8, 4);    mov(cx, memw_a16[ds, 0xaa]);              /* mov cx, [0xaa] */
            ii(0xb1cc, 2);    inc(ch);                                  /* inc ch */
            ii(0xb1ce, 2);    mov(es, cx);                              /* mov es, cx */
            ii(0xb1d0, 3);    xor(esi, esi);                            /* xor esi, esi */
            ii(0xb1d3, 3);    callw(0xb1d9, 0x3);                       /* call 0xb1d9 */
            ii(0xb1d6, 1);    popw(di);                                 /* pop di */
            ii(0xb1d7, 1);    popw(si);                                 /* pop si */
            ii(0xb1d8, 1);    retw();                                   /* ret */
        }
    }
}
