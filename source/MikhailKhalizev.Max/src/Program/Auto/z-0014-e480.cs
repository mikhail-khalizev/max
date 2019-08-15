using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f599138e-0ac4-4fa1-89be-8090de5f6416")]
        public void Method_0014_e480()
        {
            ii(0x14_e480, 2); pushw(0x20);                              /* push 0x20 */
            ii(0x14_e482, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e483, 2); mov(cl, 0x3);                             /* mov cl, 0x3 */
            ii(0x14_e485, 4); xchg(memb_a16[ds, 0x980], cl);            /* xchg [0x980], cl */
            ii(0x14_e489, 4); mov(bx, memw_a32[ss, ebp + 0x14]);        /* mov bx, [ebp+0x14] */
            ii(0x14_e48d, 3); callw(0x14_e450, -0x40);                  /* call 0xe450 */
            ii(0x14_e490, 4); mov(memb_a16[ds, 0x980], cl);             /* mov [0x980], cl */
            ii(0x14_e494, 2); if(jbw(0x14_e497, 0x1)) goto l_0x14_e497; /* jb 0xe497 */
            ii(0x14_e496, 1); retw(); return;                           /* ret */
        l_0x14_e497:
            ii(0x14_e497, 4); mov(memw_a32[ss, ebp + 0x20], ax);        /* mov [ebp+0x20], ax */
            ii(0x14_e49b, 4); mov(memw_a32[ss, ebp + 0x14], bx);        /* mov [ebp+0x14], bx */
            ii(0x14_e49f, 3); if(jmpw_func(0x14_e062, -0x440)) return;  /* jmp 0xe062 */
        }
    }
}
