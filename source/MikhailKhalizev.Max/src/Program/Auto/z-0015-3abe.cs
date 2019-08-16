using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f8fdfbb8-f752-4ed6-89b7-4504880b0d32")]
        public void Method_0015_3abe()
        {
            ii(0x15_3abe, 1); popw(cx);                                 /* pop cx */
            ii(0x15_3abf, 1); popw(dx);                                 /* pop dx */
            ii(0x15_3ac0, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x15_3ac2, 2); sub(bx, ax);                              /* sub bx, ax */
            ii(0x15_3ac4, 2); if(jbw(0x15_3ad1, 0xb)) goto l_0x15_3ad1; /* jb 0x3ad1 */
            ii(0x15_3ac6, 4); cmp(bx, memw_a16[ds, 0x3f52]);            /* cmp bx, [0x3f52] */
            ii(0x15_3aca, 2); if(jbw(0x15_3ad1, 0x5)) goto l_0x15_3ad1; /* jb 0x3ad1 */
            ii(0x15_3acc, 2); mov(sp, bx);                              /* mov sp, bx */
            ii(0x15_3ace, 1); pushw(dx);                                /* push dx */
            ii(0x15_3acf, 1); pushw(cx);                                /* push cx */
            ii(0x15_3ad0, 1); retfw(); return;                          /* retf */
        l_0x15_3ad1:
            ii(0x15_3ad1, 1); pushw(dx);                                /* push dx */
            ii(0x15_3ad2, 1); pushw(cx);                                /* push cx */
            ii(0x15_3ad3, 3); mov(ax, memw_a16[ds, 0x3f4e]);            /* mov ax, [0x3f4e] */
            ii(0x15_3ad6, 1); inc(ax);                                  /* inc ax */
            ii(0x15_3ad7, 2); if(jnzw(0x15_3ade, 0x5)) goto l_0x15_3ade; /* jnz 0x3ade */
            ii(0x15_3ad9, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x15_3adb, 3); if(jmpw_func(0x15_2203, -0x18db)) return; /* jmp 0x2203 */
        l_0x15_3ade:
            ii(0x15_3ade, 4); if(jmpw_a16_far_ind(ds, 0x3f4e)) return;  /* jmp far word [0x3f4e] */
        }
    }
}
