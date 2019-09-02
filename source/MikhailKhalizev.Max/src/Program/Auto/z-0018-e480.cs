using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e480-99821fa5")]
        public void Method_0018_e480()
        {
            ii(0x18_e480, 2); push(0x20);                               /* push 0x20 */
            ii(0x18_e482, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e483, 2); mov(cl, 3);                               /* mov cl, 0x3 */
            ii(0x18_e485, 4); xchg(memb[ds, 0x980], cl);                /* xchg [0x980], cl */
            ii(0x18_e489, 4); mov(bx, memw_a32[ss, ebp + 0x14]);        /* mov bx, [ebp+0x14] */
            ii(0x18_e48d, 3); call(0x18_e450, -0x40);                   /* call 0xe450 */
            ii(0x18_e490, 4); mov(memb[ds, 0x980], cl);                 /* mov [0x980], cl */
            ii(0x18_e494, 2); if(jb(0x18_e497, 1)) goto l_0x18_e497;    /* jb 0xe497 */
            ii(0x18_e496, 1); ret(); return;                            /* ret */
        l_0x18_e497:
            ii(0x18_e497, 4); mov(memw_a32[ss, ebp + 0x20], ax);        /* mov [ebp+0x20], ax */
            ii(0x18_e49b, 4); mov(memw_a32[ss, ebp + 0x14], bx);        /* mov [ebp+0x14], bx */
            ii(0x18_e49f, 3); if(jmp_func(0x18_e062, -0x440)) return;   /* jmp 0xe062 */
        }
    }
}
