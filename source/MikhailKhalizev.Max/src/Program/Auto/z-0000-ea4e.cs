using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6e6b44aa-d933-4858-bcfc-26758d9f9cc6")]
        public void Method_0000_ea4e()
        {
            ii(0xea4e, 5);    test(memb_a16[ds, 0x14], 0x4);            /* test byte [0x14], 0x4 */
            ii(0xea53, 2);    if(jnzw(0xea67, 0x12)) goto l_0xea67;     /* jnz 0xaa97 */
            ii(0xea55, 1);    sti();                                    /* sti */
            ii(0xea56, 4);    mov(es, memw_a16[ds, 0xc2e]);             /* mov es, [0xc2e] */
            ii(0xea5a, 4);    mov(al, memb_a16[es, 0x46c]);             /* mov al, [es:0x46c] */
            ii(0xea5e, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0xea60, 4);    xchg(memb_a16[ds, 0x10ed], al);           /* xchg [0x10ed], al */
            ii(0xea64, 2);    sub(al, ah);                              /* sub al, ah */
            ii(0xea66, 1);    cli();                                    /* cli */
        l_0xea67:
            ii(0xea67, 1);    retw(); return;                           /* ret */
        }
    }
}
