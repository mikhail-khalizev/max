using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e30f-900ad328")]
        public void Method_0018_e30f()
        {
            ii(0x18_e30f, 3); call(0x18_e070, -0x2a2);                  /* call 0xe070 */
            ii(0x18_e312, 2); if(jb_func(0x18_e2b3, -0x61)) return;     /* jb 0xe2b3 */
            ii(0x18_e314, 2); if(jcxz_func(0x18_e2b3, -0x63)) return;   /* jcxz 0xe2b3 */
            ii(0x18_e316, 3); mov(esi, edi);                            /* mov esi, edi */
            ii(0x18_e319, 3); mov(edi, ebx);                            /* mov edi, ebx */
            ii(0x18_e31c, 1); push(es);                                 /* push es */
            ii(0x18_e31d, 1); push(ds);                                 /* push ds */
            ii(0x18_e31e, 1); pop(es);                                  /* pop es */
            ii(0x18_e31f, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e320, 5); test(memb_a32[ds, esi + 0x5], 0x10);      /* test byte [esi+0x5], 0x10 */
            ii(0x18_e325, 2); if(jnz_func(0x18_e306, -0x21)) return;    /* jnz 0xe306 */
            ii(0x18_e327, 5); test(memb_a32[ds, esi + 0x5], 0x7f);      /* test byte [esi+0x5], 0x7f */
            ii(0x18_e32c, 2); if(jz_func(0x18_e306, -0x28)) return;     /* jz 0xe306 */
            ii(0x18_e32e, 3); if(jmp_func(0x18_e062, -0x2cf)) return;   /* jmp 0xe062 */
        }
    }
}
