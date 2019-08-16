using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c9376504-b0b1-44b6-97a2-bfc7fdad57eb")]
        public void Method_0014_edfc()
        {
            ii(0x14_edfc, 3); mov(ebx, esp);                            /* mov ebx, esp */
            ii(0x14_edff, 6); lds(ebx, ss, ebx + 0xa);                  /* lds ebx, [ss:ebx+0xa] */
            ii(0x14_ee05, 3); mov(bl, memb_a32[ds, ebx]);               /* mov bl, [ebx] */
            ii(0x14_ee08, 3); cmp(bl, -0x65 /* 0x9b */);                /* cmp bl, 0x9b */
            ii(0x14_ee0b, 2); if(jzw(0x14_ee13, 0x6)) goto l_0x14_ee13; /* jz 0xee13 */
            ii(0x14_ee0d, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x14_ee10, 3); cmp(bl, -0x28 /* 0xd8 */);                /* cmp bl, 0xd8 */
        l_0x14_ee13:
            ii(0x14_ee13, 1); popw(ds);                                 /* pop ds */
            ii(0x14_ee14, 2); popd(ebx);                                /* pop ebx */
            ii(0x14_ee16, 2); if(jzw(0x14_ee19, 0x1)) goto l_0x14_ee19; /* jz 0xee19 */
            ii(0x14_ee18, 1); retw(); return;                           /* ret */
        l_0x14_ee19:
            ii(0x14_ee19, 3); if(jmpw_func(0x14_ef0e, 0xf2)) return;    /* jmp 0xef0e */
        }
    }
}