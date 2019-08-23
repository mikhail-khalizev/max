using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xe808-fe6c4151")]
        public void Method_0000_e808()
        {
            ii(0xe808, 5);    test(memw[ss, bp + 0x26], 0x200);         /* test word [bp+0x26], 0x200 */
            ii(0xe80d, 2);    if(jz(0xe810, 0x1)) goto l_0xe810;        /* jz 0xe810 */
            ii(0xe80f, 1);    sti();                                    /* sti */
        l_0xe810:
            ii(0xe810, 3);    lea(sp, memw[ss, bp - 0x4]);              /* lea sp, [bp-0x4] */
            ii(0xe813, 4);    pop(memw[ds, 0xf52]);                     /* pop word [0xf52] */
            ii(0xe817, 4);    pop(memw[ds, 0x99e]);                     /* pop word [0x99e] */
            ii(0xe81b, 4);    pop(memw[ds, 0x996]);                     /* pop word [0x996] */
            ii(0xe81f, 1);    inc(sp);                                  /* inc sp */
            ii(0xe820, 1);    inc(sp);                                  /* inc sp */
            ii(0xe821, 1);    pop(ds);                                  /* pop ds */
            ii(0xe822, 1);    pop(es);                                  /* pop es */
            ii(0xe823, 1);    popa();                                   /* popa */
            ii(0xe824, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe827, 2);    iretd();                                  /* iretd */
        }
    }
}
