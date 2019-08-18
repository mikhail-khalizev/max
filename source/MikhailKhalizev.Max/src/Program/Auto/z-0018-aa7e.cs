using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea715429-bde7-40f3-a3e9-293256c4aa10")]
        public void Method_0018_aa7e()
        {
            ii(0x18_aa7e, 5); test(memb_a16[ds, 0x14], 0x4);            /* test byte [0x14], 0x4 */
            ii(0x18_aa83, 2); if(jnzw(0x18_aa97, 0x12)) goto l_0x18_aa97; /* jnz 0xaa97 */
            ii(0x18_aa85, 1); sti();                                    /* sti */
            ii(0x18_aa86, 4); mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0x18_aa8a, 4); mov(al, memb_a16[es, 0x46c]);             /* mov al, [es:0x46c] */
            ii(0x18_aa8e, 2); mov(ah, al);                              /* mov ah, al */
            ii(0x18_aa90, 4); xchg(memb_a16[ds, 0x10ed], al);           /* xchg [0x10ed], al */
            ii(0x18_aa94, 2); sub(al, ah);                              /* sub al, ah */
            ii(0x18_aa96, 1); cli();                                    /* cli */
        l_0x18_aa97:
            ii(0x18_aa97, 1); retw(); return;                           /* ret */
        }
    }
}
