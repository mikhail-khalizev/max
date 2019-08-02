using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("47c90894-1baa-4fde-9fb3-1ca8d2283b2a")]
        public void Method_0014_e30f()
        {
            ii(0x14_e30f, 3); callw(0x14_e070, -0x2a2);                 /* call 0xe070 */
            ii(0x14_e312, 2); jbw_func(0x14_e2b3, -0x61);               /* jb 0xe2b3 */
            ii(0x14_e314, 2); jcxzw_func(0x14_e2b3, -0x63);             /* jcxz 0xe2b3 */
            ii(0x14_e316, 3); mov(esi, edi);                            /* mov esi, edi */
            ii(0x14_e319, 3); mov(edi, ebx);                            /* mov edi, ebx */
            ii(0x14_e31c, 1); pushw(es);                                /* push es */
            ii(0x14_e31d, 1); pushw(ds);                                /* push ds */
            ii(0x14_e31e, 1); popw(es);                                 /* pop es */
            ii(0x14_e31f, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e320, 5); test(memb_a32[ds, esi + 0x5], 0x10);      /* test byte [esi+0x5], 0x10 */
            ii(0x14_e325, 2); jnzw_func(0x14_e306, -0x21);              /* jnz 0xe306 */
            ii(0x14_e327, 5); test(memb_a32[ds, esi + 0x5], 0x7f);      /* test byte [esi+0x5], 0x7f */
            ii(0x14_e32c, 2); jzw_func(0x14_e306, -0x28);               /* jz 0xe306 */
            ii(0x14_e32e, 3); jmpw_func(0x14_e062, -0x2cf); return;     /* jmp 0xe062 */
        }
    }
}
