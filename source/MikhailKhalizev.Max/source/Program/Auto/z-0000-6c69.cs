using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6c69-2252553f")]
        public void Method_0000_6c69()
        {
            ii(0x6c69, 1);  push(bp);                                  /* push bp */
            ii(0x6c6a, 2);  mov(bp, sp);                               /* mov bp, sp */
            ii(0x6c6c, 3);  sub(sp, 0x18);                             /* sub sp, 0x18 */
            ii(0x6c6f, 4);  mov(memb[ss, bp - 13], 0x1a);              /* mov byte [bp-0xd], 0x1a */
            ii(0x6c73, 5);  mov(memw[ss, bp - 8], 0x80);               /* mov word [bp-0x8], 0x80 */
            ii(0x6c78, 3);  mov(ax, memw[ds, 0xcec]);                  /* mov ax, [0xcec] */
            ii(0x6c7b, 3);  mov(memw[ss, bp - 16], ax);                /* mov [bp-0x10], ax */
            ii(0x6c7e, 3);  lea(ax, memw[ss, bp - 22]);                /* lea ax, [bp-0x16] */
            ii(0x6c81, 1);  push(ax);                                  /* push ax */
            ii(0x6c82, 3);  lea(ax, memw[ss, bp - 14]);                /* lea ax, [bp-0xe] */
            ii(0x6c85, 1);  push(ax);                                  /* push ax */
            ii(0x6c86, 1);  push(ax);                                  /* push ax */
            ii(0x6c87, 3);  call(0x64b8, -0x7d2);                      /* call 0x64b8 */
            ii(0x6c8a, 3);  add(sp, 6);                                /* add sp, 0x6 */
            ii(0x6c8d, 5);  cmp(memb[ds, 0xe6a], 0);                   /* cmp byte [0xe6a], 0x0 */
            ii(0x6c92, 2);  if(jnz(0x6ce8, 0x54)) goto l_0x6ce8;       /* jnz 0x6ce8 */
            ii(0x6c94, 5);  cmp(memb[ds, 0x980], 1);                   /* cmp byte [0x980], 0x1 */
            ii(0x6c99, 2);  if(jz(0x6ca5, 0xa)) goto l_0x6ca5;         /* jz 0x6ca5 */
            ii(0x6c9b, 5);  cmp(memb[ds, 0x980], 3);                   /* cmp byte [0x980], 0x3 */
            ii(0x6ca0, 2);  if(jz(0x6ca5, 3)) goto l_0x6ca5;           /* jz 0x6ca5 */
            ii(0x6ca2, 3);  call(0x9686, 0x29e1);                      /* call 0x9686 */
        l_0x6ca5:
            ii(0x6ca5, 5);  mov(memw[ss, bp - 24], 0x2d40);            /* mov word [bp-0x18], 0x2d40 */
            ii(0x6caa, 5);  cmp(memb[ds, 0x2e], 0xb);                  /* cmp byte [0x2e], 0xb */
            ii(0x6caf, 2);  if(jz(0x6cbd, 0xc)) goto l_0x6cbd;         /* jz 0x6cbd */
            ii(0x6cb1, 5);  test(memb[ds, 0x47], 0x80);                /* test byte [0x47], 0x80 */
            ii(0x6cb6, 2);  if(jnz(0x6cbd, 5)) goto l_0x6cbd;          /* jnz 0x6cbd */
            ii(0x6cb8, 5);  mov(memw[ss, bp - 24], 0x29bc);            /* mov word [bp-0x18], 0x29bc */
        l_0x6cbd:
            ii(0x6cbd, 5);  test(memb[ds, 0x14], 8);                   /* test byte [0x14], 0x8 */
            ii(0x6cc2, 2);  if(jz(0x6cc9, 5)) goto l_0x6cc9;           /* jz 0x6cc9 */
            ii(0x6cc4, 5);  mov(memw[ss, bp - 24], 0x627f);            /* mov word [bp-0x18], 0x627f */
        l_0x6cc9:
            ii(0x6cc9, 5);  cmp(memw[ds, 0xe6e], 0);                   /* cmp word [0xe6e], 0x0 */
            ii(0x6cce, 2);  if(jz(0x6cd9, 9)) goto l_0x6cd9;           /* jz 0x6cd9 */
            ii(0x6cd0, 3);  mov(ax, memw[ss, bp - 24]);                /* mov ax, [bp-0x18] */
            ii(0x6cd3, 4);  cmp(memw[ds, 0xe6e], ax);                  /* cmp [0xe6e], ax */
            ii(0x6cd7, 2);  if(jbe(0x6ce8, 0xf)) goto l_0x6ce8;        /* jbe 0x6ce8 */
        l_0x6cd9:
            ii(0x6cd9, 3);  mov(ax, memw[ss, bp - 24]);                /* mov ax, [bp-0x18] */
            ii(0x6cdc, 3);  mov(memw[ds, 0xe6e], ax);                  /* mov [0xe6e], ax */
            ii(0x6cdf, 1);  push(ax);                                  /* push ax */
            ii(0x6ce0, 3);  push(memw[ss, bp + 4]);                    /* push word [bp+0x4] */
            ii(0x6ce3, 3);  call(0x5c3f, -0x10a7);                     /* call 0x5c3f */
            ii(0x6ce6, 1);  pop(bx);                                   /* pop bx */
            ii(0x6ce7, 1);  pop(bx);                                   /* pop bx */
        l_0x6ce8:
            ii(0x6ce8, 2);  mov(sp, bp);                               /* mov sp, bp */
            ii(0x6cea, 1);  pop(bp);                                   /* pop bp */
            ii(0x6ceb, 1);  ret();                                     /* ret */
        }
    }
}
