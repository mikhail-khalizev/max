using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x55e7-98ca9f15")]
        public void Method_0000_55e7()
        {
            ii(0x55e7, 1);  push(bp);                                  /* push bp */
            ii(0x55e8, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x55ea, 3);  sub(sp, 6);                                /* sub sp, 0x6 */
            ii(0x55ed, 1);  push(si);                                  /* push si */
            ii(0x55ee, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x55f2, 2);  if(jz(0x5603, 0xf)) goto l_0x5603;         /* jz 0x5603 */
            ii(0x55f4, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x55f7, 3);  call(0x5237, -0x3c3);                      /* call 0x5237 */
            ii(0x55fa, 1);  pop(bx);                                   /* pop bx */
            ii(0x55fb, 3);  mov(ax, 0xad2);                            /* mov ax, 0xad2 */
            ii(0x55fe, 1);  push(ax);                                  /* push ax */
            ii(0x55ff, 3);  call(0x5237, -0x3cb);                      /* call 0x5237 */
            ii(0x5602, 1);  pop(bx);                                   /* pop bx */
        l_0x5603:
            ii(0x5603, 3);  mov(si, 5);                                /* mov si, 0x5 */
            ii(0x5606, 2);  jmp(0x5622, 0x1a); goto l_0x5622;          /* jmp 0x5622 */
        l_0x5608:
            ii(0x5608, 3);  lea(cx, memw[ds, si - 1]);                 /* lea cx, [si-0x1] */
            ii(0x560b, 2);  shl(cl, 1);                                /* shl cl, 1 */
            ii(0x560d, 2);  shl(cl, 1);                                /* shl cl, 1 */
            ii(0x560f, 3);  mov(bx, memw[ss, bp + 6]);                 /* mov bx, [bp+0x6] */
            ii(0x5612, 2);  shr(bx, cl);                               /* shr bx, cl */
            ii(0x5614, 3);  and(bx, 0xf);                              /* and bx, 0xf */
            ii(0x5617, 4);  mov(al, memb[ds, bx + 2736]);              /* mov al, [bx+0xab0] */
            ii(0x561b, 3);  lea(bx, memw[ss, bp - 2]);                 /* lea bx, [bp-0x2] */
            ii(0x561e, 2);  sub(bx, si);                               /* sub bx, si */
            ii(0x5620, 2);  mov(memb[ds, bx], al);                     /* mov [bx], al */
        l_0x5622:
            ii(0x5622, 1);  dec(si);                                   /* dec si */
            ii(0x5623, 2);  if(jns(0x5608, -0x1d)) goto l_0x5608;      /* jns 0x5608 */
            ii(0x5625, 4);  mov(memb[ss, bp - 2], 0);                  /* mov byte [bp-0x2], 0x0 */
            ii(0x5629, 3);  lea(ax, memw[ss, bp - 6]);                 /* lea ax, [bp-0x6] */
            ii(0x562c, 1);  push(ax);                                  /* push ax */
            ii(0x562d, 3);  call(0x5237, -0x3f9);                      /* call 0x5237 */
            ii(0x5630, 1);  pop(bx);                                   /* pop bx */
            ii(0x5631, 4);  cmp(memw[ss, bp + 4], 0);                  /* cmp word [bp+0x4], 0x0 */
            ii(0x5635, 2);  if(jz(0x563f, 8)) goto l_0x563f;           /* jz 0x563f */
            ii(0x5637, 3);  mov(ax, 0xad4);                            /* mov ax, 0xad4 */
            ii(0x563a, 1);  push(ax);                                  /* push ax */
            ii(0x563b, 3);  call(0x5237, -0x407);                      /* call 0x5237 */
            ii(0x563e, 1);  pop(bx);                                   /* pop bx */
        l_0x563f:
            ii(0x563f, 1);  pop(si);                                   /* pop si */
            ii(0x5640, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x5642, 1);  pop(bp);                                   /* pop bp */
            ii(0x5643, 1);  ret();                                     /* ret */
        }
    }
}
