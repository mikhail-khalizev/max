using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("d556edd2-6f44-49d0-b5de-9bae2b021933")]
        public void Method_0014_dc28()
        {
            ii(0x14_dc28, 2); mov(bx, sp);                              /* mov bx, sp */
            ii(0x14_dc2a, 1); pushw(bp);                                /* push bp */
            ii(0x14_dc2b, 2); pushd(edi);                               /* push edi */
            ii(0x14_dc2d, 4); mov(bp, memw_a16[ss, bx + 0x4]);          /* mov bp, [ss:bx+0x4] */
            ii(0x14_dc31, 4); mov(bx, memw_a16[ss, bx + 0x2]);          /* mov bx, [ss:bx+0x2] */
            ii(0x14_dc35, 5); cmp(memb_a16[ds, 0x2e], 0);               /* cmp byte [0x2e], 0x0 */
            ii(0x14_dc3a, 2); if(jzw(0x14_dc50, 0x14)) goto l_0x14_dc50; /* jz 0xdc50 */
            ii(0x14_dc3c, 3); and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x14_dc3f, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x14_dc41, 2); pushw(0x8);                               /* push 0x8 */
            ii(0x14_dc43, 1); popw(es);                                 /* pop es */
            ii(0x14_dc44, 3); callw(0x14_dc06, -0x41);                  /* call 0xdc06 */
            ii(0x14_dc47, 2); popd(edi);                                /* pop edi */
            ii(0x14_dc49, 1); popw(bp);                                 /* pop bp */
            ii(0x14_dc4a, 1); popw(ax);                                 /* pop ax */
            ii(0x14_dc4b, 1); pushw(ss);                                /* push ss */
            ii(0x14_dc4c, 1); popw(ss);                                 /* pop ss */
            ii(0x14_dc4d, 1); sti();                                    /* sti */
            ii(0x14_dc4e, 2); jmpw_abs(ax); return;                     /* jmp ax */
        l_0x14_dc50:
            ii(0x14_dc50, 1); pushw(ds);                                /* push ds */
            ii(0x14_dc51, 1); popw(es);                                 /* pop es */
            ii(0x14_dc52, 3); xor(edi, edi);                            /* xor edi, edi */
            ii(0x14_dc55, 3); mov(di, 0x8c0);                           /* mov di, 0x8c0 */
            ii(0x14_dc58, 1); pushw(di);                                /* push di */
            ii(0x14_dc59, 3); callw(0x14_dc06, -0x56);                  /* call 0xdc06 */
            ii(0x14_dc5c, 1); popw(di);                                 /* pop di */
            ii(0x14_dc5d, 2); mov(cx, ds);                              /* mov cx, ds */
            ii(0x14_dc5f, 4); test(memb_a16[ss, bp + 0x8], 0x8);        /* test byte [bp+0x8], 0x8 */
            ii(0x14_dc63, 2); if(jzw(0x14_dc67, 0x2)) goto l_0x14_dc67; /* jz 0xdc67 */
            ii(0x14_dc65, 2); mov(cx, cs);                              /* mov cx, cs */
        l_0x14_dc67:
            ii(0x14_dc67, 3); lar(ax, cx);                              /* lar ax, cx */
            ii(0x14_dc6a, 3); and(ah, 0xfe);                            /* and ah, 0xfe */
            ii(0x14_dc6d, 4); mov(memb_a16[es, di + 0x5], ah);          /* mov [es:di+0x5], ah */
            ii(0x14_dc71, 2); popd(edx);                                /* pop edx */
            ii(0x14_dc73, 1); popw(bp);                                 /* pop bp */
            ii(0x14_dc74, 1); popw(cx);                                 /* pop cx */
            ii(0x14_dc75, 3); mov(ax, 0xc);                             /* mov ax, 0xc */
            ii(0x14_dc78, 1); pushw(cs);                                /* push cs */
            ii(0x14_dc79, 3); callw(0x14_a3b9, -0x38c3);                /* call 0xa3b9 */
            ii(0x14_dc7c, 1); pushw(ss);                                /* push ss */
            ii(0x14_dc7d, 1); popw(ss);                                 /* pop ss */
            ii(0x14_dc7e, 3); mov(edi, edx);                            /* mov edi, edx */
            ii(0x14_dc81, 1); cmc();                                    /* cmc */
            ii(0x14_dc82, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x14_dc85, 2); rcl(ax, 0x1);                             /* rcl ax, 1 */
            ii(0x14_dc87, 1); sti();                                    /* sti */
            ii(0x14_dc88, 2); jmpw_abs(cx); return;                     /* jmp cx */
        }
    }
}
