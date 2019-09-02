using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e218-39b2d482")]
        public void Method_0017_e218()
        {
            ii(0x17_e218, 1); pop(cx);                                  /* pop cx */
            ii(0x17_e219, 1); pop(dx);                                  /* pop dx */
            ii(0x17_e21a, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x17_e21c, 2); sub(bx, ax);                              /* sub bx, ax */
            ii(0x17_e21e, 2); if(jb(0x17_e22b, 0xb)) goto l_0x17_e22b;  /* jb 0xe22b */
            ii(0x17_e220, 4); cmp(bx, memw[ds, 0x1da6]);                /* cmp bx, [0x1da6] */
            ii(0x17_e224, 2); if(jb(0x17_e22b, 5)) goto l_0x17_e22b;    /* jb 0xe22b */
            ii(0x17_e226, 2); mov(sp, bx);                              /* mov sp, bx */
            ii(0x17_e228, 1); push(dx);                                 /* push dx */
            ii(0x17_e229, 1); push(cx);                                 /* push cx */
            ii(0x17_e22a, 1); retf(); return;                           /* retf */
        l_0x17_e22b:
            ii(0x17_e22b, 1); push(dx);                                 /* push dx */
            ii(0x17_e22c, 1); push(cx);                                 /* push cx */
            ii(0x17_e22d, 3); mov(ax, memw[ds, 0x1da2]);                /* mov ax, [0x1da2] */
            ii(0x17_e230, 1); inc(ax);                                  /* inc ax */
            ii(0x17_e231, 2); if(jnz(0x17_e238, 5)) goto l_0x17_e238;   /* jnz 0xe238 */
            ii(0x17_e233, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e235, 3); if(jmp_func(0x17_d16b, -0x10cd)) return;  /* jmp 0xd16b */
        l_0x17_e238:
            ii(0x17_e238, 4); jmp_far_ind(memw[ds, 0x1da2]);            /* jmp far word [0x1da2] */
        }
    }
}
