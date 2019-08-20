using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_afbb-d63e339")]
        public void Method_0018_afbb()
        {
            ii(0x18_afbb, 5); test(memb_a16[ds, 0x15], 0x1);            /* test byte [0x15], 0x1 */
            ii(0x18_afc0, 2); if(jnzw_func(0x18_af98, -0x2a)) return;   /* jnz 0xaf98 */
            ii(0x18_afc2, 5); cmp(memb_a16[ds, 0x34], 0x15);            /* cmp byte [0x34], 0x15 */
            ii(0x18_afc7, 2); if(jnzw_func(0x18_af98, -0x31)) return;   /* jnz 0xaf98 */
            ii(0x18_afc9, 3); callw(0x18_a8bf, -0x70d);                 /* call 0xa8bf */
            ii(0x18_afcc, 2); pushw(0x40);                              /* push 0x40 */
            ii(0x18_afce, 1); popw(es);                                 /* pop es */
            ii(0x18_afcf, 5); mov(bx, memw_a16[es, 0x6e]);              /* mov bx, [es:0x6e] */
            ii(0x18_afd4, 3); mov(ax, 0x16);                            /* mov ax, 0x16 */
            ii(0x18_afd7, 2); mul(bx);                                  /* mul bx */
            ii(0x18_afd9, 3); mov(cx, 0x3);                             /* mov cx, 0x3 */
            ii(0x18_afdc, 2); div(cx);                                  /* div cx */
            ii(0x18_afde, 5); mov(cx, memw_a16[es, 0x6c]);              /* mov cx, [es:0x6c] */
            ii(0x18_afe3, 3); shr(cx, 0xd);                             /* shr cx, 0xd */
            ii(0x18_afe6, 2); add(cx, ax);                              /* add cx, ax */
            ii(0x18_afe8, 4); mov(ax, memw_a16[es, 0x6c]);              /* mov ax, [es:0x6c] */
            ii(0x18_afec, 2); sub(ax, cx);                              /* sub ax, cx */
            ii(0x18_afee, 3); sbb(bl, 0);                               /* sbb bl, 0x0 */
            ii(0x18_aff1, 3); mov(cx, 0xcfb);                           /* mov cx, 0xcfb */
            ii(0x18_aff4, 2); mul(cx);                                  /* mul cx */
            ii(0x18_aff6, 3); mov(cx, 0xec54);                          /* mov cx, 0xec54 */
            ii(0x18_aff9, 2); div(cx);                                  /* div cx */
            ii(0x18_affb, 2); mov(ch, 0x3c);                            /* mov ch, 0x3c */
            ii(0x18_affd, 2); div(ch);                                  /* div ch */
            ii(0x18_afff, 2); xchg(bl, ah);                             /* xchg bl, ah */
            ii(0x18_b001, 3); mov(memw_a16[ss, bp + 0x14], ax);         /* mov [bp+0x14], ax */
            ii(0x18_b004, 1); xchg(dx, ax);                             /* xchg dx, ax */
            ii(0x18_b005, 2); xor(dx, dx);                              /* xor dx, dx */
            ii(0x18_b007, 3); mov(cx, 0x25d);                           /* mov cx, 0x25d */
            ii(0x18_b00a, 2); div(cx);                                  /* div cx */
            ii(0x18_b00c, 2); mov(ah, bl);                              /* mov ah, bl */
            ii(0x18_b00e, 3); mov(memw_a16[ss, bp + 0x12], ax);         /* mov [bp+0x12], ax */
            ii(0x18_b011, 2); if(jmpw_func(0x18_af95, -0x7e)) return;   /* jmp 0xaf95 */
        }
    }
}
