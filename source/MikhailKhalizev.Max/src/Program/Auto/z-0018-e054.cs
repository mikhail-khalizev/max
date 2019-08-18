using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e054-db6d6e8e")]
        public void Method_0018_e054()
        {
            ii(0x18_e054, 2); cmp(bl, ah);                              /* cmp bl, ah */
            ii(0x18_e056, 2); if(jaew(0x18_e062, 0xa)) goto l_0x18_e062; /* jae 0xe062 */
            ii(0x18_e058, 2); shl(bx, 0x1);                             /* shl bx, 1 */
            ii(0x18_e05a, 1); cld();                                    /* cld */
            ii(0x18_e05b, 3); if(jmpw_abs(memw_a16[cs, bx + si])) return; /* jmp word [cs:bx+si] */
            ii(0x18_e05e, 4); if(jmpw_a16_far_ind(cs, si - 0x6)) return; /* jmp far word [cs:si-0x6] */
        l_0x18_e062:
            ii(0x18_e062, 5); or(memb_a32[ss, ebp + 0x2c], 0x1);        /* or byte [ebp+0x2c], 0x1 */
            ii(0x18_e067, 3); mov(esp, ebp);                            /* mov esp, ebp */
            ii(0x18_e06a, 1); popw(ds);                                 /* pop ds */
            ii(0x18_e06b, 1); popw(es);                                 /* pop es */
            ii(0x18_e06c, 2); popad();                                  /* popad */
            ii(0x18_e06e, 2); iretd(); return;                          /* iretd */
        }
    }
}
