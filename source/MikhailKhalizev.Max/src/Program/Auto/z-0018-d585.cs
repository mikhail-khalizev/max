using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_d585-bf521f4d")]
        public void Method_0018_d585()
        {
            ii(0x18_d585, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x18_d589, 1);  push(di);                               /* push di */
            ii(0x18_d58a, 1);  push(si);                               /* push si */
            ii(0x18_d58b, 3);  mov(bx, memw[ss, bp + 4]);              /* mov bx, [bp+0x4] */
            ii(0x18_d58e, 3);  shr(bx, 3);                             /* shr bx, 0x3 */
            ii(0x18_d591, 4);  les(di, memw[ds, 0xaa0]);               /* les di, [0xaa0] */
            ii(0x18_d595, 4);  test(memb[es, bx + di], 0x10);          /* test byte [es:bx+di], 0x10 */
            ii(0x18_d599, 2);  if(jz(0x18_d615, 0x7a)) goto l_0x18_d615;/* jz 0xd615 */
            ii(0x18_d59b, 4);  mov(si, memw[ds, 0x97c]);               /* mov si, [0x97c] */
            ii(0x18_d59f, 2);  mov(ax, si);                            /* mov ax, si */
            ii(0x18_d5a1, 3);  xor(al, memb[ss, bp + 4]);              /* xor al, [bp+0x4] */
            ii(0x18_d5a4, 3);  and(ax, 7);                             /* and ax, 0x7 */
            ii(0x18_d5a7, 2);  xor(si, ax);                            /* xor si, ax */
            ii(0x18_d5a9, 4);  mov(memb[ss, bp - 2], 0);               /* mov byte [bp-0x2], 0x0 */
            ii(0x18_d5ad, 2);  jmp(0x18_d5f8, 0x49); goto l_0x18_d5f8; /* jmp 0xd5f8 */
        l_0x18_d5af:
            ii(0x18_d5af, 3);  lea(ax, memw[ss, bp - 12]);             /* lea ax, [bp-0xc] */
            ii(0x18_d5b2, 1);  push(ax);                               /* push ax */
            ii(0x18_d5b3, 1);  push(si);                               /* push si */
            ii(0x18_d5b4, 3);  call(0x18_dc8e, 0x6d7);                 /* call 0xdc8e */
            ii(0x18_d5b7, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d5b8, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d5b9, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x18_d5bb, 2);  if(jz(0x18_d5f8, 0x3b)) goto l_0x18_d5f8;/* jz 0xd5f8 */
            ii(0x18_d5bd, 4);  test(memb[ss, bp - 4], 0x10);           /* test byte [bp-0x4], 0x10 */
            ii(0x18_d5c1, 2);  if(jz(0x18_d5f8, 0x35)) goto l_0x18_d5f8;/* jz 0xd5f8 */
            ii(0x18_d5c3, 3);  mov(ax, memw[ss, bp - 12]);             /* mov ax, [bp-0xc] */
            ii(0x18_d5c6, 3);  mov(dx, memw[ss, bp - 10]);             /* mov dx, [bp-0xa] */
            ii(0x18_d5c9, 3);  sub(ax, memw[ss, bp + 6]);              /* sub ax, [bp+0x6] */
            ii(0x18_d5cc, 3);  sbb(dx, memw[ss, bp + 8]);              /* sbb dx, [bp+0x8] */
            ii(0x18_d5cf, 3);  mov(cx, memw[ss, bp + 10]);             /* mov cx, [bp+0xa] */
            ii(0x18_d5d2, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x18_d5d4, 2);  cmp(dx, bx);                            /* cmp dx, bx */
            ii(0x18_d5d6, 2);  if(ja(0x18_d5f8, 0x20)) goto l_0x18_d5f8;/* ja 0xd5f8 */
            ii(0x18_d5d8, 2);  if(jb(0x18_d5de, 4)) goto l_0x18_d5de;  /* jb 0xd5de */
            ii(0x18_d5da, 2);  cmp(ax, cx);                            /* cmp ax, cx */
            ii(0x18_d5dc, 2);  if(ja(0x18_d5f8, 0x1a)) goto l_0x18_d5f8;/* ja 0xd5f8 */
        l_0x18_d5de:
            ii(0x18_d5de, 3);  add(ax, memw[ss, bp + 12]);             /* add ax, [bp+0xc] */
            ii(0x18_d5e1, 3);  adc(dx, memw[ss, bp + 14]);             /* adc dx, [bp+0xe] */
            ii(0x18_d5e4, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x18_d5e7, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x18_d5ea, 3);  lea(ax, memw[ss, bp - 12]);             /* lea ax, [bp-0xc] */
            ii(0x18_d5ed, 1);  push(ax);                               /* push ax */
            ii(0x18_d5ee, 1);  push(si);                               /* push si */
            ii(0x18_d5ef, 3);  call(0x18_dc28, 0x636);                 /* call 0xdc28 */
            ii(0x18_d5f2, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d5f3, 1);  pop(bx);                                /* pop bx */
            ii(0x18_d5f4, 4);  mov(memb[ss, bp - 2], 1);               /* mov byte [bp-0x2], 0x1 */
        l_0x18_d5f8:
            ii(0x18_d5f8, 3);  sub(si, 8);                             /* sub si, 0x8 */
            ii(0x18_d5fb, 4);  cmp(si, memw[ds, 0xc34]);               /* cmp si, [0xc34] */
            ii(0x18_d5ff, 2);  if(jae(0x18_d5af, -0x52)) goto l_0x18_d5af;/* jae 0xd5af */
            ii(0x18_d601, 4);  cmp(memb[ss, bp - 2], 0);               /* cmp byte [bp-0x2], 0x0 */
            ii(0x18_d605, 2);  if(jnz(0x18_d615, 0xe)) goto l_0x18_d615;/* jnz 0xd615 */
            ii(0x18_d607, 3);  mov(bx, memw[ss, bp + 4]);              /* mov bx, [bp+0x4] */
            ii(0x18_d60a, 3);  shr(bx, 3);                             /* shr bx, 0x3 */
            ii(0x18_d60d, 4);  les(di, memw[ds, 0xaa0]);               /* les di, [0xaa0] */
            ii(0x18_d611, 4);  and(memb[es, bx + di], -0x11 /* 0xef */);/* and byte [es:bx+di], 0xef */
        l_0x18_d615:
            ii(0x18_d615, 1);  pop(si);                                /* pop si */
            ii(0x18_d616, 1);  pop(di);                                /* pop di */
            ii(0x18_d617, 1);  leave();                                /* leave */
            ii(0x18_d618, 1);  ret();                                  /* ret */
        }
    }
}
