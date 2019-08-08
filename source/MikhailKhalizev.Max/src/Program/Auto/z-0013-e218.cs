using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b8533bba-45c8-4baf-8c3d-9cb314b528a0")]
        public void Method_0013_e218()
        {
            ii(0x13_e218, 1); popw(cx);                                 /* pop cx */
            ii(0x13_e219, 1); popw(dx);                                 /* pop dx */
            ii(0x13_e21a, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x13_e21c, 2); sub(bx, ax);                              /* sub bx, ax */
            ii(0x13_e21e, 2); if(jbw(0x13_e22b, 0xb)) goto l_0x13_e22b; /* jb 0xe22b */
            ii(0x13_e220, 4); cmp(bx, memw_a16[ds, 0x1da6]);            /* cmp bx, [0x1da6] */
            ii(0x13_e224, 2); if(jbw(0x13_e22b, 0x5)) goto l_0x13_e22b; /* jb 0xe22b */
            ii(0x13_e226, 2); mov(sp, bx);                              /* mov sp, bx */
            ii(0x13_e228, 1); pushw(dx);                                /* push dx */
            ii(0x13_e229, 1); pushw(cx);                                /* push cx */
            ii(0x13_e22a, 1); retfw(); return;                          /* retf */
        l_0x13_e22b:
            ii(0x13_e22b, 1); pushw(dx);                                /* push dx */
            ii(0x13_e22c, 1); pushw(cx);                                /* push cx */
            ii(0x13_e22d, 3); mov(ax, memw_a16[ds, 0x1da2]);            /* mov ax, [0x1da2] */
            ii(0x13_e230, 1); inc(ax);                                  /* inc ax */
            ii(0x13_e231, 2); if(jnzw(0x13_e238, 0x5)) goto l_0x13_e238; /* jnz 0xe238 */
            ii(0x13_e233, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x13_e235, 3); if(jmpw_func(0x13_d16b, -0x10cd)) return; /* jmp 0xd16b */
        l_0x13_e238:
            ii(0x13_e238, 4); if(jmpw_a16_far_ind(ds, 0x1da2)) return;  /* jmp far word [0x1da2] */
        }
    }
}
