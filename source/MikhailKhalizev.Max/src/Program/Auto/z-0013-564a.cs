using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("263367b4-e550-4138-866c-c857be157920")]
        public void Method_0013_564a()
        {
            ii(0x13_564a, 1); pushw(ds);                                /* push ds */
            ii(0x13_564b, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x13_564e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x13_5650, 1); nop();                                    /* nop */
            ii(0x13_5651, 1); pushw(cs);                                /* push cs */
            ii(0x13_5652, 3); callw(0x13_8e80, 0x382b);                 /* call 0x8e80 */
            ii(0x13_5655, 3); mov(memw_a16[ds, 0xae], ax);              /* mov [0xae], ax */
            ii(0x13_5658, 4); mov(memw_a16[ds, 0xb0], dx);              /* mov [0xb0], dx */
            ii(0x13_565c, 5); cmp(memw_a16[ds, 0x51a0], 0);             /* cmp word [0x51a0], 0x0 */
            ii(0x13_5661, 2); if(jnzw(0x13_5678, 0x15)) goto l_0x13_5678; /* jnz 0x5678 */
            ii(0x13_5663, 4); pushw(memw_a16[ds, 0x4f86]);              /* push word [0x4f86] */
            ii(0x13_5667, 4); pushw(memw_a16[ds, 0x4f84]);              /* push word [0x4f84] */
            ii(0x13_566b, 1); nop();                                    /* nop */
            ii(0x13_566c, 1); pushw(cs);                                /* push cs */
            ii(0x13_566d, 3); callw(0x13_909e, 0x3a2e);                 /* call 0x909e */
            ii(0x13_5670, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x13_5673, 1); nop();                                    /* nop */
            ii(0x13_5674, 1); pushw(cs);                                /* push cs */
            ii(0x13_5675, 3); callw(0x13_9078, 0x3a00);                 /* call 0x9078 */
        l_0x13_5678:
            ii(0x13_5678, 1); popw(ds);                                 /* pop ds */
            ii(0x13_5679, 1); retfw(); return;                          /* retf */
        }
    }
}
