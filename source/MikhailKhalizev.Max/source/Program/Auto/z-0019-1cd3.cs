using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_1cd3-791c6188")]
        public void Method_0019_1cd3()
        {
            ii(0x19_1cd3, 4);  enter(0xa, 0);                          /* enter 0xa, 0x0 */
            ii(0x19_1cd7, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x19_1cd9, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x19_1cdc, 3);  mov(memw[ss, bp - 10], ax);             /* mov [bp-0xa], ax */
            ii(0x19_1cdf, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_1ce2, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x19_1ce5, 4);  mov(dx, memw[es, bx + 2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_1ce9, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_1cec, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_1cef, 2);  jmp(0x19_1d18, 0x27); goto l_0x19_1d18; /* jmp 0x1d18 */
        l_0x19_1cf1:
            ii(0x19_1cf1, 2);  cmp(al, 0x30);                          /* cmp al, 0x30 */
            ii(0x19_1cf3, 2);  if(jl(0x19_1d25, 0x30)) goto l_0x19_1d25;/* jl 0x1d25 */
            ii(0x19_1cf5, 2);  cmp(al, 0x39);                          /* cmp al, 0x39 */
            ii(0x19_1cf7, 2);  if(jg(0x19_1d25, 0x2c)) goto l_0x19_1d25;/* jg 0x1d25 */
            ii(0x19_1cf9, 2);  push(0);                                /* push 0x0 */
            ii(0x19_1cfb, 2);  push(0xa);                              /* push 0xa */
            ii(0x19_1cfd, 3);  lea(cx, memw[ss, bp - 10]);             /* lea cx, [bp-0xa] */
            ii(0x19_1d00, 1);  push(ss);                               /* push ss */
            ii(0x19_1d01, 1);  push(cx);                               /* push cx */
            ii(0x19_1d02, 1);  nop();                                  /* nop */
            ii(0x19_1d03, 1);  push(cs);                               /* push cs */
            ii(0x19_1d04, 3);  call(0x19_36a0, 0x1999);                /* call 0x36a0 */
            ii(0x19_1d07, 3);  mov(al, memb[ss, bp - 6]);              /* mov al, [bp-0x6] */
            ii(0x19_1d0a, 1);  cbw();                                  /* cbw */
            ii(0x19_1d0b, 3);  sub(ax, 0x30);                          /* sub ax, 0x30 */
            ii(0x19_1d0e, 1);  cwd();                                  /* cwd */
            ii(0x19_1d0f, 3);  add(memw[ss, bp - 10], ax);             /* add [bp-0xa], ax */
            ii(0x19_1d12, 3);  adc(memw[ss, bp - 8], dx);              /* adc [bp-0x8], dx */
            ii(0x19_1d15, 3);  inc(memw[ss, bp - 4]);                  /* inc word [bp-0x4] */
        l_0x19_1d18:
            ii(0x19_1d18, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x19_1d1b, 3);  mov(al, memb[es, bx]);                  /* mov al, [es:bx] */
            ii(0x19_1d1e, 3);  mov(memb[ss, bp - 6], al);              /* mov [bp-0x6], al */
            ii(0x19_1d21, 2);  or(al, al);                             /* or al, al */
            ii(0x19_1d23, 2);  if(jnz(0x19_1cf1, -0x34)) goto l_0x19_1cf1;/* jnz 0x1cf1 */
        l_0x19_1d25:
            ii(0x19_1d25, 2);  mov(ax, bx);                            /* mov ax, bx */
            ii(0x19_1d27, 2);  mov(dx, es);                            /* mov dx, es */
            ii(0x19_1d29, 3);  les(bx, memw[ss, bp + 4]);              /* les bx, [bp+0x4] */
            ii(0x19_1d2c, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_1d2f, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x19_1d33, 3);  mov(ax, memw[ss, bp - 10]);             /* mov ax, [bp-0xa] */
            ii(0x19_1d36, 3);  mov(dx, memw[ss, bp - 8]);              /* mov dx, [bp-0x8] */
            ii(0x19_1d39, 1);  leave();                                /* leave */
            ii(0x19_1d3a, 1);  ret();                                  /* ret */
        }
    }
}
