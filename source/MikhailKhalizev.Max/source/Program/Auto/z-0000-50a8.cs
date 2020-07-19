using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x50a8-25cf79fd")]
        public void Method_0000_50a8()
        {
            ii(0x50a8, 4);  enter(2, 0);                               /* enter 0x2, 0x0 */
            ii(0x50ac, 3);  les(bx, memw[ss, bp + 4]);                 /* les bx, [bp+0x4] */
            ii(0x50af, 5);  test(memb[es, bx + 5], 0x10);              /* test byte [es:bx+0x5], 0x10 */
            ii(0x50b4, 2);  if(jz(0x50f8, 0x42)) goto l_0x50f8;        /* jz 0x50f8 */
            ii(0x50b6, 4);  mov(al, memb[es, bx + 7]);                 /* mov al, [es:bx+0x7] */
            ii(0x50ba, 2);  sub(ah, ah);                               /* sub ah, ah */
            ii(0x50bc, 3);  mov(memw[ss, bp - 2], ax);                 /* mov [bp-0x2], ax */
            ii(0x50bf, 5);  test(memb[es, bx + 4], 0xf0);              /* test byte [es:bx+0x4], 0xf0 */
            ii(0x50c4, 2);  if(jnz(0x50ca, 4)) goto l_0x50ca;          /* jnz 0x50ca */
            ii(0x50c6, 2);  or(ax, ax);                                /* or ax, ax */
            ii(0x50c8, 2);  if(jz(0x50f8, 0x2e)) goto l_0x50f8;        /* jz 0x50f8 */
        l_0x50ca:
            ii(0x50ca, 3);  push(memw[es, bx]);                        /* push word [es:bx] */
            ii(0x50cd, 3);  call(0x47cd, -0x903);                      /* call 0x47cd */
            ii(0x50d0, 1);  pop(bx);                                   /* pop bx */
            ii(0x50d1, 2);  push(0);                                   /* push 0x0 */
            ii(0x50d3, 1);  push(ax);                                  /* push ax */
            ii(0x50d4, 3);  les(bx, memw[ss, bp + 4]);                 /* les bx, [bp+0x4] */
            ii(0x50d7, 4);  mov(ax, memw[es, bx + 2]);                 /* mov ax, [es:bx+0x2] */
            ii(0x50db, 4);  mov(dx, memw[es, bx + 4]);                 /* mov dx, [es:bx+0x4] */
            ii(0x50df, 2);  and(al, 0xf0);                             /* and al, 0xf0 */
            ii(0x50e1, 2);  sub(dh, dh);                               /* sub dh, dh */
            ii(0x50e3, 3);  mov(ch, memb[ss, bp - 2]);                 /* mov ch, [bp-0x2] */
            ii(0x50e6, 2);  sub(cl, cl);                               /* sub cl, cl */
            ii(0x50e8, 2);  sub(bx, bx);                               /* sub bx, bx */
            ii(0x50ea, 2);  add(ax, bx);                               /* add ax, bx */
            ii(0x50ec, 2);  adc(dx, cx);                               /* adc dx, cx */
            ii(0x50ee, 2);  mov(cl, 4);                                /* mov cl, 0x4 */
            ii(0x50f0, 3);  call(0x5da0, 0xcad);                       /* call 0x5da0 */
            ii(0x50f3, 1);  push(dx);                                  /* push dx */
            ii(0x50f4, 1);  push(ax);                                  /* push ax */
            ii(0x50f5, 3);  call(0x545d, 0x365);                       /* call 0x545d */
        l_0x50f8:
            ii(0x50f8, 1);  leave();                                   /* leave */
            ii(0x50f9, 1);  ret();                                     /* ret */
        }
    }
}
