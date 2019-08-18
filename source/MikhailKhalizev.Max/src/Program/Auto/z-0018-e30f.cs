using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("9dd76dff-bfe6-468b-8e2a-aa84a8805c86")]
        public void Method_0018_e30f()
        {
            ii(0x18_e30f, 3); callw(0x18_e070, -0x2a2);                 /* call 0xe070 */
            ii(0x18_e312, 2); if(jbw_func(0x18_e2b3, -0x61)) return;    /* jb 0xe2b3 */
            ii(0x18_e314, 2); if(jcxzw_func(0x18_e2b3, -0x63)) return;  /* jcxz 0xe2b3 */
            ii(0x18_e316, 3); mov(esi, edi);                            /* mov esi, edi */
            ii(0x18_e319, 3); mov(edi, ebx);                            /* mov edi, ebx */
            ii(0x18_e31c, 1); pushw(es);                                /* push es */
            ii(0x18_e31d, 1); pushw(ds);                                /* push ds */
            ii(0x18_e31e, 1); popw(es);                                 /* pop es */
            ii(0x18_e31f, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e320, 5); test(memb_a32[ds, esi + 0x5], 0x10);      /* test byte [esi+0x5], 0x10 */
            ii(0x18_e325, 2); if(jnzw_func(0x18_e306, -0x21)) return;   /* jnz 0xe306 */
            ii(0x18_e327, 5); test(memb_a32[ds, esi + 0x5], 0x7f);      /* test byte [esi+0x5], 0x7f */
            ii(0x18_e32c, 2); if(jzw_func(0x18_e306, -0x28)) return;    /* jz 0xe306 */
            ii(0x18_e32e, 3); if(jmpw_func(0x18_e062, -0x2cf)) return;  /* jmp 0xe062 */
        }
    }
}
