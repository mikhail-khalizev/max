using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_a838-fe6c4151")]
        public void Method_0018_a838()
        {
            ii(0x18_a838, 5); test(memw_a16[ss, bp + 0x26], 0x200);     /* test word [bp+0x26], 0x200 */
            ii(0x18_a83d, 2); if(jzw(0x18_a840, 0x1)) goto l_0x18_a840; /* jz 0xa840 */
            ii(0x18_a83f, 1); sti();                                    /* sti */
        l_0x18_a840:
            ii(0x18_a840, 3); lea(sp, bp - 0x4);                        /* lea sp, [bp-0x4] */
            ii(0x18_a843, 4); popw(memw_a16[ds, 0xf52]);                /* pop word [0xf52] */
            ii(0x18_a847, 4); popw(memw_a16[ds, 0x99e]);                /* pop word [0x99e] */
            ii(0x18_a84b, 4); popw(memw_a16[ds, 0x996]);                /* pop word [0x996] */
            ii(0x18_a84f, 1); inc(sp);                                  /* inc sp */
            ii(0x18_a850, 1); inc(sp);                                  /* inc sp */
            ii(0x18_a851, 1); popw(ds);                                 /* pop ds */
            ii(0x18_a852, 1); popw(es);                                 /* pop es */
            ii(0x18_a853, 1); popa();                                   /* popa */
            ii(0x18_a854, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x18_a857, 2); iretd(); return;                          /* iretd */
        }
    }
}