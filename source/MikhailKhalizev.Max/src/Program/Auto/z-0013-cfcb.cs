using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b6af60cc-d933-4957-b749-88542cafa968")]
        public void Method_0013_cfcb()
        {
            ii(0x13_cfcb, 2); pushd(ebx);                               /* push ebx */
            ii(0x13_cfcd, 5); movzx(bx, memb_a32[ss, ebp + 0x20]);      /* movzx bx, byte [ebp+0x20] */
            ii(0x13_cfd2, 3); pushw(0x3e68);                            /* push 0x3e68 */
            ii(0x13_cfd5, 1); popw(ds);                                 /* pop ds */
            ii(0x13_cfd6, 2); mov(al, 0xa);                             /* mov al, 0xa */
            ii(0x13_cfd8, 5); cmp(memb_a16[ds, 0x5], 0);                /* cmp byte [0x5], 0x0 */
            ii(0x13_cfdd, 4); if(jnzw(0x13_cfe3, 0x2)) goto l_0x13_cfe3; /* jnz 0xcfe3 */
            ii(0x13_cfe1, 2); mov(al, 0x3);                             /* mov al, 0x3 */
        l_0x13_cfe3:
            ii(0x13_cfe3, 2); cmp(bl, al);                              /* cmp bl, al */
            ii(0x13_cfe5, 4); if(jaw(0x13_d005, 0x1c)) goto l_0x13_d005; /* ja 0xd005 */
            ii(0x13_cfe9, 3); callw(0x13_ceac, -0x140);                 /* call 0xceac */
            ii(0x13_cfec, 1); pushw(bx);                                /* push bx */
            ii(0x13_cfed, 1); pushw(ss);                                /* push ss */
            ii(0x13_cfee, 1); pushw(bp);                                /* push bp */
            ii(0x13_cfef, 1); nop();                                    /* nop */
            ii(0x13_cff0, 1); pushw(cs);                                /* push cs */
            ii(0x13_cff1, 3); callw(0x13_9706, -0x38ee);                /* call 0x9706 */
            ii(0x13_cff4, 1); popw(bp);                                 /* pop bp */
            ii(0x13_cff5, 1); popw(bx);                                 /* pop bx */
            ii(0x13_cff6, 1); popw(bx);                                 /* pop bx */
            ii(0x13_cff7, 3); callw(0x13_cf26, -0xd4);                  /* call 0xcf26 */
            ii(0x13_cffa, 2); popd(ebx);                                /* pop ebx */
            ii(0x13_cffc, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x13_cffe, 4); if(jnzw_func(0x13_d0ab, 0xa9)) return;    /* jnz 0xd0ab */
            ii(0x13_d002, 3); if(jmpw_func(0x13_d0b0, 0xab)) return;    /* jmp 0xd0b0 */
        l_0x13_d005:
            ii(0x13_d005, 2); popd(ebx);                                /* pop ebx */
            ii(0x13_d007, 5); if(jmpw_a16_far_ind(cs, -0x7984)) return; /* jmp far word [cs:0x867c] */
        }
    }
}
