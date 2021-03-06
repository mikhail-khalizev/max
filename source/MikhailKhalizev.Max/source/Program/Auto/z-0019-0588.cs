using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_0588-4305e0a4")]
        public void Method_0019_0588()
        {
            ii(0x19_0588, 4);  enter(4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_058c, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_058e, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x19_0591, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_0594, 1);  push(ds);                               /* push ds */
            ii(0x19_0595, 1);  push(es);                               /* push es */
            ii(0x19_0596, 2);  mov(ah, 0xff);                          /* mov ah, 0xff */
            ii(0x19_0598, 2);  mov(dh, 0x1a);                          /* mov dh, 0x1a */
            ii(0x19_059a, 3);  mov(dl, memb[ss, bp + 6]);              /* mov dl, [bp+0x6] */
            ii(0x19_059d, 3);  mov(bx, memw[ss, bp + 10]);             /* mov bx, [bp+0xa] */
            ii(0x19_05a0, 3);  mov(cx, memw[ss, bp + 8]);              /* mov cx, [bp+0x8] */
            ii(0x19_05a3, 2);  @int(0x21);                             /* int 0x21 */
            ii(0x19_05a5, 2);  if(jb(0x19_05ad, 6)) goto l_0x19_05ad;  /* jb 0x5ad */
            ii(0x19_05a7, 3);  mov(memw[ss, bp - 2], bx);              /* mov [bp-0x2], bx */
            ii(0x19_05aa, 3);  mov(memw[ss, bp - 4], cx);              /* mov [bp-0x4], cx */
        l_0x19_05ad:
            ii(0x19_05ad, 1);  pop(es);                                /* pop es */
            ii(0x19_05ae, 1);  pop(ds);                                /* pop ds */
            ii(0x19_05af, 4);  mov(es, memw[ds, 0x3fb8]);              /* mov es, [0x3fb8] */
            ii(0x19_05b3, 4);  mov(ax, memw[es, 0x3b8c]);              /* mov ax, [es:0x3b8c] */
            ii(0x19_05b7, 3);  cmp(memw[ss, bp + 10], ax);             /* cmp [bp+0xa], ax */
            ii(0x19_05ba, 2);  if(jbe(0x19_05e3, 0x27)) goto l_0x19_05e3;/* jbe 0x5e3 */
            ii(0x19_05bc, 3);  mov(ax, 0xa);                           /* mov ax, 0xa */
            ii(0x19_05bf, 3);  mov(bx, memw[ss, bp + 10]);             /* mov bx, [bp+0xa] */
            ii(0x19_05c2, 2);  @int(0x31);                             /* int 0x31 */
            ii(0x19_05c4, 2);  if(jb(0x19_05e3, 0x1d)) goto l_0x19_05e3;/* jb 0x5e3 */
            ii(0x19_05c6, 3);  mov(memw[ss, bp + 10], ax);             /* mov [bp+0xa], ax */
            ii(0x19_05c9, 3);  les(bx, memw[ss, bp + 8]);              /* les bx, [bp+0x8] */
            ii(0x19_05cc, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x19_05cf, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_05d2, 4);  mov(memw[es, bx - 2], dx);              /* mov [es:bx-0x2], dx */
            ii(0x19_05d6, 4);  mov(memw[es, bx - 4], ax);              /* mov [es:bx-0x4], ax */
            ii(0x19_05da, 2);  mov(bx, es);                            /* mov bx, es */
            ii(0x19_05dc, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_05de, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_05e0, 1);  inc(ax);                                /* inc ax */
            ii(0x19_05e1, 2);  @int(0x31);                             /* int 0x31 */
        l_0x19_05e3:
            ii(0x19_05e3, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x19_05e6, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x19_05e9, 1);  leave();                                /* leave */
            ii(0x19_05ea, 1);  retf();                                 /* retf */
        }
    }
}
