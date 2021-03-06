using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_f9ac-d37cd248")]
        public void Method_0019_f9ac()
        {
            ii(0x19_f9ac, 4);  enter(0xe, 0);                          /* enter 0xe, 0x0 */
            ii(0x19_f9b0, 4);  mov(es, memw[ds, 0x3fde]);              /* mov es, [0x3fde] */
            ii(0x19_f9b4, 4);  mov(ax, memw[es, 0x3b78]);              /* mov ax, [es:0x3b78] */
            ii(0x19_f9b8, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x19_f9ba, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x19_f9bc, 4);  mov(ax, memw[es, bx + 66]);             /* mov ax, [es:bx+0x42] */
            ii(0x19_f9c0, 4);  mov(dx, memw[es, bx + 68]);             /* mov dx, [es:bx+0x44] */
            ii(0x19_f9c4, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_f9c7, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_f9ca, 3);  mov(memw[ss, bp - 10], bx);             /* mov [bp-0xa], bx */
        l_0x19_f9cd:
            ii(0x19_f9cd, 3);  mov(ax, memw[ss, bp - 2]);              /* mov ax, [bp-0x2] */
            ii(0x19_f9d0, 3);  or(ax, memw[ss, bp - 4]);               /* or ax, [bp-0x4] */
            ii(0x19_f9d3, 2);  if(jz(0x19_fa13, 0x3e)) goto l_0x19_fa13;/* jz 0xfa13 */
            ii(0x19_f9d5, 3);  push(memw[ss, bp + 8]);                 /* push word [bp+0x8] */
            ii(0x19_f9d8, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x19_f9db, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x19_f9de, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x19_f9e1, 5);  call_far_abs(0x80, 0x5a20);             /* call word 0x80:0x5a20 */
            ii(0x19_f9e6, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x19_f9e9, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_f9ec, 3);  mov(memw[ss, bp - 12], dx);             /* mov [bp-0xc], dx */
            ii(0x19_f9ef, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x19_f9f1, 2);  if(jz(0x19_fa01, 0xe)) goto l_0x19_fa01;/* jz 0xfa01 */
            ii(0x19_f9f3, 3);  push(memw[ss, bp + 12]);                /* push word [bp+0xc] */
            ii(0x19_f9f6, 3);  push(memw[ss, bp + 10]);                /* push word [bp+0xa] */
            ii(0x19_f9f9, 3);  call_far_ind(memw[ss, bp - 14]);        /* call far word [bp-0xe] */
            ii(0x19_f9fc, 1);  pop(bx);                                /* pop bx */
            ii(0x19_f9fd, 1);  pop(bx);                                /* pop bx */
            ii(0x19_f9fe, 3);  inc(memw[ss, bp - 10]);                 /* inc word [bp-0xa] */
        l_0x19_fa01:
            ii(0x19_fa01, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_fa04, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_fa07, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_fa0b, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_fa0e, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_fa11, 2);  jmp(0x19_f9cd, -0x46); goto l_0x19_f9cd;/* jmp 0xf9cd */
        l_0x19_fa13:
            ii(0x19_fa13, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_fa16, 1);  leave();                                /* leave */
            ii(0x19_fa17, 1);  retf();                                 /* retf */
        }
    }
}
