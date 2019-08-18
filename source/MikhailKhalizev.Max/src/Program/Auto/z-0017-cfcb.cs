using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_cfcb-39b60ce7")]
        public void Method_0017_cfcb()
        {
            ii(0x17_cfcb, 2); pushd(ebx);                               /* push ebx */
            ii(0x17_cfcd, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x17_cfd2, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x17_cfd5, 1); popw(ds);                                 /* pop ds */
            ii(0x17_cfd6, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x17_cfd8, 5); cmp(memb_a16[ds, 0x5], 0);                /* cmp byte [0x5], 0x0 */
            ii(0x17_cfdd, 4); if(jnzw(0x17_cfe3, 0x2)) goto l_0x17_cfe3; /* jnz 0xcfe3 */
            ii(0x17_cfe1, 2); mov(al, 0x3);                             /* mov al, 0x3 */
        l_0x17_cfe3:
            ii(0x17_cfe3, 2); cmp(bl, al);                              /* cmp bl, al */
            ii(0x17_cfe5, 4); if(jaw(0x17_d005, 0x1c)) goto l_0x17_d005; /* ja 0xd005 */
            ii(0x17_cfe9, 3); callw(0x17_ceac, -0x140);                 /* call 0xceac */
            ii(0x17_cfec, 1); pushw(bx);                                /* push bx */
            ii(0x17_cfed, 1); pushw(ss);                                /* push ss */
            ii(0x17_cfee, 1); pushw(bp);                                /* push bp */
            ii(0x17_cfef, 1); nop();                                    /* nop */
            ii(0x17_cff0, 1); pushw(cs);                                /* push cs */
            ii(0x17_cff1, 3); callw(0x17_9706, -0x38ee);                /* call 0x9706 */
            ii(0x17_cff4, 1); popw(bp);                                 /* pop bp */
            ii(0x17_cff5, 1); popw(bx);                                 /* pop bx */
            ii(0x17_cff6, 1); popw(bx);                                 /* pop bx */
            ii(0x17_cff7, 3); callw(0x17_cf26, -0xd4);                  /* call 0xcf26 */
            ii(0x17_cffa, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_cffc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_cffe, 4); if(jnzw_func(0x17_d0ab, 0xa9)) return;    /* jnz 0xd0ab */
            ii(0x17_d002, 3); if(jmpw_func(0x17_d0b0, 0xab)) return;    /* jmp 0xd0b0 */
        l_0x17_d005:
            ii(0x17_d005, 2); popd(ebx);                                /* pop ebx */
            ii(0x17_d007, 5); if(jmpw_a16_far_ind(cs, -0x7984)) return; /* jmp far word [cs:0x867c] */
        }
    }
}
