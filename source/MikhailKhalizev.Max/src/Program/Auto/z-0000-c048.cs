using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c821926e-7c9c-4660-bdbb-b0d6e95fca8c")]
        public void Method_0000_c048()
        {
            ii(0xc048, 5);    test(memw_a16[ss, bp + 0x26], 0x200);     /* test word [bp+0x26], 0x200 */
            ii(0xc04d, 2);    if(jzw(0xc050, 0x1)) goto l_0xc050;       /* jz 0xe810 */
            ii(0xc04f, 1);    sti();                                    /* sti */
        l_0xc050:
            ii(0xc050, 3);    lea(sp, bp - 0x4);                        /* lea sp, [bp-0x4] */
            ii(0xc053, 4);    popw(memw_a16[ds, 0xf52]);                /* pop word [0xf52] */
            ii(0xc057, 4);    popw(memw_a16[ds, 0x99e]);                /* pop word [0x99e] */
            ii(0xc05b, 4);    popw(memw_a16[ds, 0x996]);                /* pop word [0x996] */
            ii(0xc05f, 1);    inc(sp);                                  /* inc sp */
            ii(0xc060, 1);    inc(sp);                                  /* inc sp */
            ii(0xc061, 1);    popw(ds);                                 /* pop ds */
            ii(0xc062, 1);    popw(es);                                 /* pop es */
            ii(0xc063, 1);    popa();                                   /* popa */
            ii(0xc064, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xc067, 2);    iretd(); return;                          /* iretd */
        }
    }
}
