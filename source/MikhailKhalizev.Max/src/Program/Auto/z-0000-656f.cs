using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x656f-4abbc702")]
        public void Method_0000_656f()
        {
            ii(0x656f, 1);    push(bp);                                 /* push bp */
            ii(0x6570, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6572, 4);    cmp(memw[ss, bp + 0x4], 0x20);            /* cmp word [bp+0x4], 0x20 */
            ii(0x6576, 2);    if(jz(0x658a, 0x12)) goto l_0x658a;       /* jz 0x658a */
            ii(0x6578, 4);    cmp(memw[ss, bp + 0x4], 0x9);             /* cmp word [bp+0x4], 0x9 */
            ii(0x657c, 2);    if(jz(0x658a, 0xc)) goto l_0x658a;        /* jz 0x658a */
            ii(0x657e, 4);    cmp(memw[ss, bp + 0x4], 0xa);             /* cmp word [bp+0x4], 0xa */
            ii(0x6582, 2);    if(jz(0x658a, 0x6)) goto l_0x658a;        /* jz 0x658a */
            ii(0x6584, 4);    cmp(memw[ss, bp + 0x4], 0xd);             /* cmp word [bp+0x4], 0xd */
            ii(0x6588, 2);    if(jnz(0x658f, 0x5)) goto l_0x658f;       /* jnz 0x658f */
        l_0x658a:
            ii(0x658a, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x658d, 1);    pop(bp);                                  /* pop bp */
            ii(0x658e, 1);    ret(); return;                            /* ret */
        l_0x658f:
            ii(0x658f, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6591, 1);    pop(bp);                                  /* pop bp */
            ii(0x6592, 1);    ret();                                    /* ret */
        }
    }
}
