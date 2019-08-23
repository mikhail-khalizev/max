using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_cf9b-9a25d7b3")]
        public void Method_0017_cf9b()
        {
            ii(0x17_cf9b, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_cf9d, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x17_cfa2, 3); cmp(bl, 0);                               /* cmp bl, 0x0 */
            ii(0x17_cfa5, 4); if(ja(0x17_cfc4, 0x1b)) goto l_0x17_cfc4; /* ja 0xcfc4 */
            ii(0x17_cfa9, 3); push(0x3e68);                             /* push 0x3e68 */
            ii(0x17_cfac, 1); pop(ds);                                  /* pop ds */
            ii(0x17_cfad, 3); call(0x17_ceac, -0x104);                  /* call 0xceac */
            ii(0x17_cfb0, 1); push(bx);                                 /* push bx */
            ii(0x17_cfb1, 1); push(ss);                                 /* push ss */
            ii(0x17_cfb2, 1); push(bp);                                 /* push bp */
            ii(0x17_cfb3, 1); nop();                                    /* nop */
            ii(0x17_cfb4, 1); push(cs);                                 /* push cs */
            ii(0x17_cfb5, 3); call(0x17_96b4, -0x3904);                 /* call 0x96b4 */
            ii(0x17_cfb8, 1); pop(bp);                                  /* pop bp */
            ii(0x17_cfb9, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x17_cfbc, 3); call(0x17_cf26, -0x99);                   /* call 0xcf26 */
            ii(0x17_cfbf, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_cfc1, 3); if(jmp_func(0x17_d0b0, 0xec)) return;     /* jmp 0xd0b0 */
        l_0x17_cfc4:
            ii(0x17_cfc4, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_cfc6, 5); jmp_far_ind(cs, -0x7988);                 /* jmp far word [cs:0x8678] */
        }
    }
}
