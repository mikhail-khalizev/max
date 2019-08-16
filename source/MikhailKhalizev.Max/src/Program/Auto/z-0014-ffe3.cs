using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3f5e62d8-6dfc-4a07-a524-7e826265e0ef")]
        public void Method_0014_ffe3()
        {
            ii(0x14_ffe3, 1); pushw(bp);                                /* push bp */
            ii(0x14_ffe4, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x14_ffe6, 1); pushw(ds);                                /* push ds */
            ii(0x14_ffe7, 2); pushd(esi);                               /* push esi */
            ii(0x14_ffe9, 2); pushd(edi);                               /* push edi */
            ii(0x14_ffeb, 2); pushd(ebx);                               /* push ebx */
            ii(0x14_ffed, 5); movzx(ebx, memw_a16[ss, bp + 0x6]);       /* movzx ebx, word [bp+0x6] */
            ii(0x14_fff2, 4); cmp(ebx, 0x20);                           /* cmp ebx, 0x20 */
            ii(0x14_fff6, 2); if(jaew_func(0x15_0034, 0x3c)) return;    /* jae 0x34 */
            ii(0x14_fff8, 2); mov(bh, 0x1);                             /* mov bh, 0x1 */
        }
    }
}
