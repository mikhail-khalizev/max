using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_9bec-cf854c63")]
        public void Method_0018_9bec()
        {
            ii(0x18_9bec, 3); callw(0x18_9f20, 0x331);                  /* call 0x9f20 */
            ii(0x18_9bef, 2); xor(bp, ax);                              /* xor bp, ax */
            ii(0x18_9bf1, 3); sub(ax, 0x3403);                          /* sub ax, 0x3403 */
            ii(0x18_9bf4, 3); callw(0x18_9f20, 0x329);                  /* call 0x9f20 */
            ii(0x18_9bf7, 3); xor(ax, 0x25e8);                          /* xor ax, 0x25e8 */
            ii(0x18_9bfa, 4); add(si, memw_a16[ds, 0x21e8]);            /* add si, [0x21e8] */
            ii(0x18_9bfe, 2); add(si, memw_a16[ds, bx]);                /* add si, [bx] */
            ii(0x18_9c00, 3); callw(0x18_9f20, 0x31d);                  /* call 0x9f20 */
            ii(0x18_9c03, 2); cmp(al, ch);                              /* cmp al, ch */
            ii(0x18_9c05, 2); sbb(memw_a16[ss, bp + di], ax);           /* sbb [bp+di], ax */
            ii(0x18_9c07, 2); cmp(ax, bp);                              /* cmp ax, bp */
            ii(0x18_9c09, 3); adc(ax, 0x3a03);                          /* adc ax, 0x3a03 */
            ii(0x18_9c0c, 3); callw(0x18_9f20, 0x311);                  /* call 0x9f20 */
            ii(0x18_9c0f, 2); cmp(bp, ax);                              /* cmp bp, ax */
            ii(0x18_9c11, 3); or(ax, 0x3c03);                           /* or ax, 0x3c03 */
            ii(0x18_9c14, 3); callw(0x18_9f20, 0x309);                  /* call 0x9f20 */
            ii(0x18_9c17, 3); cmp(ax, 0x5e8);                           /* cmp ax, 0x5e8 */
            ii(0x18_9c1a, 4); add(di, memw_a16[ds, 0x1e8]);             /* add di, [0x1e8] */
            ii(0x18_9c1e, 2); add(di, memw_a16[ds, bx]);                /* add di, [bx] */
            ii(0x18_9c20, 3); callw(0x18_9f20, 0x2fd);                  /* call 0x9f20 */
            ii(0x18_9c23, 1); inc(ax);                                  /* inc ax */
            ii(0x18_9c24, 3); callw(0x18_9f20, 0x2f9);                  /* call 0x9f20 */
            ii(0x18_9c27, 1); inc(cx);                                  /* inc cx */
            ii(0x18_9c28, 3); callw(0x18_9f20, 0x2f5);                  /* call 0x9f20 */
            ii(0x18_9c2b, 1); inc(dx);                                  /* inc dx */
            ii(0x18_9c2c, 3); callw(0x18_9f20, 0x2f1);                  /* call 0x9f20 */
            ii(0x18_9c2f, 1); inc(bx);                                  /* inc bx */
            ii(0x18_9c30, 3); callw(0x18_9f20, 0x2ed);                  /* call 0x9f20 */
            ii(0x18_9c33, 1); inc(sp);                                  /* inc sp */
            ii(0x18_9c34, 3); callw(0x18_9f20, 0x2e9);                  /* call 0x9f20 */
            ii(0x18_9c37, 1); inc(bp);                                  /* inc bp */
            ii(0x18_9c38, 3); callw(0x18_9f20, 0x2e5);                  /* call 0x9f20 */
            ii(0x18_9c3b, 1); inc(si);                                  /* inc si */
            ii(0x18_9c3c, 3); callw(0x18_9f20, 0x2e1);                  /* call 0x9f20 */
            ii(0x18_9c3f, 1); inc(di);                                  /* inc di */
            ii(0x18_9c40, 3); callw(0x18_9f20, 0x2dd);                  /* call 0x9f20 */
            ii(0x18_9c43, 1); dec(ax);                                  /* dec ax */
            ii(0x18_9c44, 3); callw(0x18_9f20, 0x2d9);                  /* call 0x9f20 */
            ii(0x18_9c47, 1); dec(cx);                                  /* dec cx */
            ii(0x18_9c48, 3); callw(0x18_9f20, 0x2d5);                  /* call 0x9f20 */
            ii(0x18_9c4b, 1); dec(dx);                                  /* dec dx */
            ii(0x18_9c4c, 3); callw(0x18_9f20, 0x2d1);                  /* call 0x9f20 */
            ii(0x18_9c4f, 1); dec(bx);                                  /* dec bx */
            ii(0x18_9c50, 3); callw(0x18_9f20, 0x2cd);                  /* call 0x9f20 */
            ii(0x18_9c53, 1); dec(sp);                                  /* dec sp */
            ii(0x18_9c54, 3); callw(0x18_9f20, 0x2c9);                  /* call 0x9f20 */
            ii(0x18_9c57, 1); dec(bp);                                  /* dec bp */
            ii(0x18_9c58, 3); callw(0x18_9f20, 0x2c5);                  /* call 0x9f20 */
            ii(0x18_9c5b, 1); dec(si);                                  /* dec si */
            ii(0x18_9c5c, 3); callw(0x18_9f20, 0x2c1);                  /* call 0x9f20 */
            ii(0x18_9c5f, 1); dec(di);                                  /* dec di */
            ii(0x18_9c60, 3); callw(0x18_9f20, 0x2bd);                  /* call 0x9f20 */
            ii(0x18_9c63, 1); pushw(ax);                                /* push ax */
            ii(0x18_9c64, 3); callw(0x18_9f20, 0x2b9);                  /* call 0x9f20 */
            ii(0x18_9c67, 1); pushw(cx);                                /* push cx */
            ii(0x18_9c68, 3); callw(0x18_9f20, 0x2b5);                  /* call 0x9f20 */
            ii(0x18_9c6b, 1); pushw(dx);                                /* push dx */
            ii(0x18_9c6c, 3); callw(0x18_9f20, 0x2b1);                  /* call 0x9f20 */
            ii(0x18_9c6f, 1); pushw(bx);                                /* push bx */
            ii(0x18_9c70, 3); callw(0x18_9f20, 0x2ad);                  /* call 0x9f20 */
            ii(0x18_9c73, 1); pushw(sp);                                /* push sp */
            ii(0x18_9c74, 3); callw(0x18_9f20, 0x2a9);                  /* call 0x9f20 */
            ii(0x18_9c77, 1); pushw(bp);                                /* push bp */
            ii(0x18_9c78, 3); callw(0x18_9f20, 0x2a5);                  /* call 0x9f20 */
            ii(0x18_9c7b, 1); pushw(si);                                /* push si */
            ii(0x18_9c7c, 3); callw(0x18_9f20, 0x2a1);                  /* call 0x9f20 */
            ii(0x18_9c7f, 1); pushw(di);                                /* push di */
            ii(0x18_9c80, 3); callw(0x18_9f20, 0x29d);                  /* call 0x9f20 */
            ii(0x18_9c83, 1); popw(ax);                                 /* pop ax */
            ii(0x18_9c84, 3); callw(0x18_9f20, 0x299);                  /* call 0x9f20 */
            ii(0x18_9c87, 1); popw(cx);                                 /* pop cx */
            ii(0x18_9c88, 3); callw(0x18_9f20, 0x295);                  /* call 0x9f20 */
            ii(0x18_9c8b, 1); popw(dx);                                 /* pop dx */
            ii(0x18_9c8c, 3); callw(0x18_9f20, 0x291);                  /* call 0x9f20 */
            ii(0x18_9c8f, 1); popw(bx);                                 /* pop bx */
            ii(0x18_9c90, 3); callw(0x18_9f20, 0x28d);                  /* call 0x9f20 */
            ii(0x18_9c93, 1); popw(sp);                                 /* pop sp */
            ii(0x18_9c94, 3); callw(0x18_9f20, 0x289);                  /* call 0x9f20 */
            ii(0x18_9c97, 1); popw(bp);                                 /* pop bp */
            ii(0x18_9c98, 3); callw(0x18_9f20, 0x285);                  /* call 0x9f20 */
            ii(0x18_9c9b, 1); popw(si);                                 /* pop si */
            ii(0x18_9c9c, 3); callw(0x18_9f20, 0x281);                  /* call 0x9f20 */
            ii(0x18_9c9f, 1); popw(di);                                 /* pop di */
            ii(0x18_9ca0, 3); callw(0x18_9f20, 0x27d);                  /* call 0x9f20 */
            ii(0x18_9ca3, 1); pusha();                                  /* pusha */
            ii(0x18_9ca4, 3); callw(0x18_9f20, 0x279);                  /* call 0x9f20 */
            ii(0x18_9ca7, 1); popa();                                   /* popa */
            ii(0x18_9ca8, 3); callw(0x18_9f20, 0x275);                  /* call 0x9f20 */
        }
    }
}
