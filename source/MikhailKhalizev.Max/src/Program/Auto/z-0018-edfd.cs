using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_edfd-48fa92d7")]
        public void Method_0018_edfd()
        {
            ii(0x18_edfd, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x18_edff, 6); lds(ebx, memd_a32[ss, ebx + 0xa]);        /* lds ebx, [ss:ebx+0xa] */
            ii(0x18_ee05, 3); mov(bl, memb_a32[ds, ebx]);               /* mov bl, [ebx] */
            ii(0x18_ee08, 3); cmp(bl, -0x65 /* 0x9b */);                /* cmp bl, 0x9b */
            ii(0x18_ee0b, 2); if(jz(0x18_ee13, 0x6)) goto l_0x18_ee13;  /* jz 0xee13 */
            ii(0x18_ee0d, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x18_ee10, 3); cmp(bl, -0x28 /* 0xd8 */);                /* cmp bl, 0xd8 */
        l_0x18_ee13:
            ii(0x18_ee13, 1); pop(ds);                                  /* pop ds */
            ii(0x18_ee14, 2); pop(ebx);                                 /* pop ebx */
            ii(0x18_ee16, 2); if(jz(0x18_ee19, 0x1)) goto l_0x18_ee19;  /* jz 0xee19 */
            ii(0x18_ee18, 1); ret(); return;                            /* ret */
        l_0x18_ee19:
            ii(0x18_ee19, 3); if(jmp_func(0x18_ef0e, 0xf2)) return;     /* jmp 0xef0e */
        }
    }
}
