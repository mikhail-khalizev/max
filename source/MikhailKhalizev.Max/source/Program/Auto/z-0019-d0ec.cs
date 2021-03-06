using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_d0ec-317b1f68")]
        public void Method_0019_d0ec()
        {
            ii(0x19_d0ec, 4);  enter(0xe, 0);                          /* enter 0xe, 0x0 */
            ii(0x19_d0f0, 3);  les(bx, memw[ss, bp + 16]);             /* les bx, [bp+0x10] */
            ii(0x19_d0f3, 4);  mov(ax, memw[es, bx + 60]);             /* mov ax, [es:bx+0x3c] */
            ii(0x19_d0f7, 4);  mov(dx, memw[es, bx + 62]);             /* mov dx, [es:bx+0x3e] */
            ii(0x19_d0fb, 4);  cmp(memw[ss, bp + 14], 0);              /* cmp word [bp+0xe], 0x0 */
            ii(0x19_d0ff, 2);  if(jnz(0x19_d104, 3)) goto l_0x19_d104; /* jnz 0xd104 */
            ii(0x19_d101, 3);  jmp(0x19_d196, 0x92); goto l_0x19_d196; /* jmp 0xd196 */
        l_0x19_d104:
            ii(0x19_d104, 4);  imul(bx, memw[ss, bp + 14], 0x18);      /* imul bx, [bp+0xe], 0x18 */
            ii(0x19_d108, 2);  add(bx, ax);                            /* add bx, ax */
            ii(0x19_d10a, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x19_d10c, 3);  sub(bx, 0x18);                          /* sub bx, 0x18 */
            ii(0x19_d10f, 3);  mov(memw[ss, bp - 10], bx);             /* mov [bp-0xa], bx */
            ii(0x19_d112, 3);  mov(memw[ss, bp - 8], es);              /* mov [bp-0x8], es */
            ii(0x19_d115, 4);  mov(ax, memw[es, bx + 8]);              /* mov ax, [es:bx+0x8] */
            ii(0x19_d119, 4);  mov(dx, memw[es, bx + 10]);             /* mov dx, [es:bx+0xa] */
            ii(0x19_d11d, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x19_d120, 4);  mov(cx, memw[es, bx + 20]);             /* mov cx, [es:bx+0x14] */
            ii(0x19_d124, 3);  mov(memw[ss, bp - 6], cx);              /* mov [bp-0x6], cx */
            ii(0x19_d127, 4);  cmp(memb[ss, bp + 4], 0);               /* cmp byte [bp+0x4], 0x0 */
            ii(0x19_d12b, 2);  if(jz(0x19_d154, 0x27)) goto l_0x19_d154;/* jz 0xd154 */
            ii(0x19_d12d, 3);  test(ah, 0x10);                         /* test ah, 0x10 */
            ii(0x19_d130, 2);  if(jz(0x19_d140, 0xe)) goto l_0x19_d140;/* jz 0xd140 */
            ii(0x19_d132, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d135, 3);  mov(memw[es, bx], cx);                  /* mov [es:bx], cx */
            ii(0x19_d138, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_d13b, 3);  mov(dx, memw[ss, bp + 12]);             /* mov dx, [bp+0xc] */
            ii(0x19_d13e, 2);  jmp(0x19_d19f, 0x5f); goto l_0x19_d19f; /* jmp 0xd19f */
        l_0x19_d140:
            ii(0x19_d140, 1);  push(ds);                               /* push ds */
            ii(0x19_d141, 3);  push(0x293d);                           /* push 0x293d */
            ii(0x19_d144, 3);  push(0xce6);                            /* push 0xce6 */
            ii(0x19_d147, 5);  call_far_abs(0x80, 0x220b);             /* call word 0x80:0x220b */
            ii(0x19_d14c, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_d14f, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x19_d152, 2);  jmp(0x19_d1a9, 0x55); goto l_0x19_d1a9; /* jmp 0xd1a9 */
        l_0x19_d154:
            ii(0x19_d154, 4);  test(memb[ss, bp - 14], 4);             /* test byte [bp-0xe], 0x4 */
            ii(0x19_d158, 2);  if(jz(0x19_d15f, 5)) goto l_0x19_d15f;  /* jz 0xd15f */
            ii(0x19_d15a, 3);  mov(ax, memw[ds, 0x19e4]);              /* mov ax, [0x19e4] */
            ii(0x19_d15d, 2);  jmp(0x19_d162, 3); goto l_0x19_d162;    /* jmp 0xd162 */
        l_0x19_d15f:
            ii(0x19_d15f, 3);  mov(ax, memw[ds, 0x19e6]);              /* mov ax, [0x19e6] */
        l_0x19_d162:
            ii(0x19_d162, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
            ii(0x19_d165, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x19_d168, 4);  test(memb[ss, bp - 13], 0x10);          /* test byte [bp-0xd], 0x10 */
            ii(0x19_d16c, 2);  if(jnz(0x19_d189, 0x1b)) goto l_0x19_d189;/* jnz 0xd189 */
            ii(0x19_d16e, 3);  les(bx, memw[ss, bp - 10]);             /* les bx, [bp-0xa] */
            ii(0x19_d171, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x19_d175, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x19_d179, 4);  sub(ax, memw[ds, 0x19ea]);              /* sub ax, [0x19ea] */
            ii(0x19_d17d, 4);  sbb(dx, memw[ds, 0x19ec]);              /* sbb dx, [0x19ec] */
            ii(0x19_d181, 3);  add(ax, memw[ss, bp + 10]);             /* add ax, [bp+0xa] */
            ii(0x19_d184, 3);  adc(dx, memw[ss, bp + 12]);             /* adc dx, [bp+0xc] */
            ii(0x19_d187, 2);  jmp(0x19_d19c, 0x13); goto l_0x19_d19c; /* jmp 0xd19c */
        l_0x19_d189:
            ii(0x19_d189, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_d18c, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x19_d18f, 1);  push(dx);                               /* push dx */
            ii(0x19_d190, 1);  push(ax);                               /* push ax */
            ii(0x19_d191, 3);  call(0x19_d9f4, 0x860);                 /* call 0xd9f4 */
            ii(0x19_d194, 2);  jmp(0x19_d19c, 6); goto l_0x19_d19c;    /* jmp 0xd19c */
        l_0x19_d196:
            ii(0x19_d196, 3);  mov(ax, memw[ss, bp + 10]);             /* mov ax, [bp+0xa] */
            ii(0x19_d199, 3);  mov(dx, memw[ss, bp + 12]);             /* mov dx, [bp+0xc] */
        l_0x19_d19c:
            ii(0x19_d19c, 3);  les(bx, memw[ss, bp + 6]);              /* les bx, [bp+0x6] */
        l_0x19_d19f:
            ii(0x19_d19f, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x19_d1a3, 4);  mov(memw[es, bx + 4], dx);              /* mov [es:bx+0x4], dx */
            ii(0x19_d1a7, 2);  sub(ax, ax);                            /* sub ax, ax */
        l_0x19_d1a9:
            ii(0x19_d1a9, 1);  leave();                                /* leave */
            ii(0x19_d1aa, 3);  ret(0x10);                              /* ret 0x10 */
        }
    }
}
