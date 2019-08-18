using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dddf32a7-f1bc-4bcc-8bcf-d183210fb4d9")]
        public void Method_0018_abe9()
        {
            ii(0x18_abe9, 1); pushw(bx);                                /* push bx */
            ii(0x18_abea, 3); mov(dx, memw_a16[ss, bp + 0x12]);         /* mov dx, [bp+0x12] */
            ii(0x18_abed, 3); mov(cx, memw_a16[ss, bp + 0x4]);          /* mov cx, [bp+0x4] */
            ii(0x18_abf0, 2); xor(bh, bh);                              /* xor bh, bh */
            ii(0x18_abf2, 3); mov(bl, memb_a16[ss, bp + 0x16]);         /* mov bl, [bp+0x16] */
            ii(0x18_abf5, 3); cmp(bl, 0xd);                             /* cmp bl, 0xd */
            ii(0x18_abf8, 2); if(jzw_func(0x18_abe4, -0x16)) return;    /* jz 0xabe4 */
            ii(0x18_abfa, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x18_abfc, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x18_ac01, 2); if(jzw_func(0x18_abe7, -0x1c)) return;    /* jz 0xabe7 */
            ii(0x18_ac03, 3); mov(ax, 0x205);                           /* mov ax, 0x205 */
            ii(0x18_ac06, 4); movzx(edx, dx);                           /* movzx edx, dx */
            ii(0x18_ac0a, 1); pushw(cs);                                /* push cs */
            ii(0x18_ac0b, 3); callw(0x18_a3b9, -0x855);                 /* call 0xa3b9 */
            ii(0x18_ac0e, 2); mov(ax, bx);                              /* mov ax, bx */
            ii(0x18_ac10, 3); shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x18_ac13, 3); cmp(ax, 0x10);                            /* cmp ax, 0x10 */
            ii(0x18_ac16, 2); if(jbew_func(0x18_ac3c, 0x24)) return;    /* jbe 0xac3c */
            ii(0x18_ac18, 2); pushw(0x10);                              /* push 0x10 */
            ii(0x18_ac1a, 1); popw(es);                                 /* pop es */
            ii(0x18_ac1b, 5); mov(memb_a16[es, bx + 0x5], 0x8e);        /* mov byte [es:bx+0x5], 0x8e */
            ii(0x18_ac20, 3); cmp(cx, 0x18);                            /* cmp cx, 0x18 */
            ii(0x18_ac23, 2); if(jzw_func(0x18_ac3c, 0x17)) return;     /* jz 0xac3c */
            ii(0x18_ac25, 3); cmp(cx, 0x70);                            /* cmp cx, 0x70 */
            ii(0x18_ac28, 2); if(jzw_func(0x18_ac3c, 0x12)) return;     /* jz 0xac3c */
            ii(0x18_ac2a, 1); pushw(ds);                                /* push ds */
            ii(0x18_ac2b, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x18_ac2d, 1); popw(ds);                                 /* pop ds */
            ii(0x18_ac2e, 2); mov(si, cx);                              /* mov si, cx */
            ii(0x18_ac30, 4); test(memb_a16[ds, si + 0x6], 0x40);       /* test byte [si+0x6], 0x40 */
            ii(0x18_ac34, 1); popw(ds);                                 /* pop ds */
            ii(0x18_ac35, 2); if(jnzw_func(0x18_ac3c, 0x5)) return;     /* jnz 0xac3c */
            ii(0x18_ac37, 5); mov(memb_a16[es, bx + 0x5], 0x86);        /* mov byte [es:bx+0x5], 0x86 */
        }
    }
}
