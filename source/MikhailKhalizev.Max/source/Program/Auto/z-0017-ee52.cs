using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_ee52-57a6945d")]
        public void Method_0017_ee52()
        {
            ii(0x17_ee52, 4);  enter(0x4a, 0);                         /* enter 0x4a, 0x0 */
            ii(0x17_ee56, 1);  push(ds);                               /* push ds */
            ii(0x17_ee57, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_ee5a, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_ee5c, 5);  mov(memw[ss, bp - 6], 0xd00);           /* mov word [bp-0x6], 0xd00 */
            ii(0x17_ee61, 5);  mov(memw[ss, bp - 8], 0xffff);          /* mov word [bp-0x8], 0xffff */
            ii(0x17_ee66, 3);  lea(ax, memw[ss, bp - 70]);             /* lea ax, [bp-0x46] */
            ii(0x17_ee69, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_ee6c, 3);  mov(memw[ss, bp - 26], ss);             /* mov [bp-0x1a], ss */
            ii(0x17_ee6f, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x17_ee72, 1);  push(ss);                               /* push ss */
            ii(0x17_ee73, 2);  push(0);                                /* push 0x0 */
            ii(0x17_ee75, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_ee78, 1);  push(ss);                               /* push ss */
            ii(0x17_ee79, 1);  push(ax);                               /* push ax */
            ii(0x17_ee7a, 3);  push(0xff00);                           /* push 0xff00 */
            ii(0x17_ee7d, 1);  nop();                                  /* nop */
            ii(0x17_ee7e, 1);  push(cs);                               /* push cs */
            ii(0x17_ee7f, 3);  call(0x17_eb40, -0x342);                /* call 0xeb40 */
            ii(0x17_ee82, 3);  add(sp, 0xa);                           /* add sp, 0xa */
            ii(0x17_ee85, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_ee87, 2);  if(jnz(0x17_ee8c, 3)) goto l_0x17_ee8c; /* jnz 0xee8c */
            ii(0x17_ee89, 3);  jmp(0x17_ef22, 0x96); goto l_0x17_ef22; /* jmp 0xef22 */
        l_0x17_ee8c:
            ii(0x17_ee8c, 4);  cmp(memw[ss, bp + 6], 0);               /* cmp word [bp+0x6], 0x0 */
            ii(0x17_ee90, 2);  if(jz(0x17_ee9a, 8)) goto l_0x17_ee9a;  /* jz 0xee9a */
            ii(0x17_ee92, 5);  mov(memw[ss, bp - 2], 0xff01);          /* mov word [bp-0x2], 0xff01 */
            ii(0x17_ee97, 2);  jmp(0x17_eed5, 0x3c); goto l_0x17_eed5; /* jmp 0xeed5 */
        //  ii(0x17_ee99, 1);  Недостижимый код.
        l_0x17_ee9a:
            ii(0x17_ee9a, 4);  mov(es, memw[ds, 0x1dce]);              /* mov es, [0x1dce] */
            ii(0x17_ee9e, 4);  mov(ax, memw[es, 0x142c]);              /* mov ax, [es:0x142c] */
            ii(0x17_eea2, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_eea5, 4);  mov(es, memw[ds, 0x1dd0]);              /* mov es, [0x1dd0] */
            ii(0x17_eea9, 4);  mov(ax, memw[es, 2]);                   /* mov ax, [es:0x2] */
            ii(0x17_eead, 3);  mov(memw[ss, bp - 6], ax);              /* mov [bp-0x6], ax */
            ii(0x17_eeb0, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_eeb3, 1);  push(ss);                               /* push ss */
            ii(0x17_eeb4, 1);  push(ax);                               /* push ax */
            ii(0x17_eeb5, 2);  sub(cx, cx);                            /* sub cx, cx */
            ii(0x17_eeb7, 3);  mov(memw[ss, bp - 18], cx);             /* mov [bp-0x12], cx */
            ii(0x17_eeba, 3);  mov(memw[ss, bp - 20], cx);             /* mov [bp-0x14], cx */
            ii(0x17_eebd, 3);  mov(memw[ss, bp - 8], cx);              /* mov [bp-0x8], cx */
            ii(0x17_eec0, 1);  push(cx);                               /* push cx */
            ii(0x17_eec1, 3);  mov(ax, 0x205);                         /* mov ax, 0x205 */
            ii(0x17_eec4, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_eec7, 1);  push(ax);                               /* push ax */
            ii(0x17_eec8, 1);  nop();                                  /* nop */
            ii(0x17_eec9, 1);  push(cs);                               /* push cs */
            ii(0x17_eeca, 3);  call(0x17_eb64, -0x369);                /* call 0xeb64 */
            ii(0x17_eecd, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_eed0, 5);  mov(memw[ss, bp - 2], 0xff00);          /* mov word [bp-0x2], 0xff00 */
        l_0x17_eed5:
            ii(0x17_eed5, 5);  mov(memw[ss, bp - 6], 0x1000);          /* mov word [bp-0x6], 0x1000 */
            ii(0x17_eeda, 4);  mov(es, memw[ds, 0x1dce]);              /* mov es, [0x1dce] */
            ii(0x17_eede, 4);  mov(ax, memw[es, 0x1418]);              /* mov ax, [es:0x1418] */
            ii(0x17_eee2, 2);  sub(bx, bx);                            /* sub bx, bx */
            ii(0x17_eee4, 2);  mov(es, ax);                            /* mov es, ax */
            ii(0x17_eee6, 5);  test(memb[es, bx + 71], 4);             /* test byte [es:bx+0x47], 0x4 */
            ii(0x17_eeeb, 2);  if(jz(0x17_eef8, 0xb)) goto l_0x17_eef8;/* jz 0xeef8 */
            ii(0x17_eeed, 3);  mov(ax, memw[ss, bp - 36]);             /* mov ax, [bp-0x24] */
            ii(0x17_eef0, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_eef3, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x17_eef6, 2);  jmp(0x17_ef01, 9); goto l_0x17_ef01;    /* jmp 0xef01 */
        l_0x17_eef8:
            ii(0x17_eef8, 3);  mov(ax, memw[ss, bp - 40]);             /* mov ax, [bp-0x28] */
            ii(0x17_eefb, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_eefe, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
        l_0x17_ef01:
            ii(0x17_ef01, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_ef04, 3);  mov(ax, memw[ss, bp - 68]);             /* mov ax, [bp-0x44] */
            ii(0x17_ef07, 3);  mov(memw[ss, bp - 14], ax);             /* mov [bp-0xe], ax */
            ii(0x17_ef0a, 3);  mov(ax, memw[ss, bp - 56]);             /* mov ax, [bp-0x38] */
            ii(0x17_ef0d, 3);  mov(memw[ss, bp - 16], ax);             /* mov [bp-0x10], ax */
            ii(0x17_ef10, 1);  push(bx);                               /* push bx */
            ii(0x17_ef11, 1);  push(bx);                               /* push bx */
            ii(0x17_ef12, 3);  lea(ax, memw[ss, bp - 20]);             /* lea ax, [bp-0x14] */
            ii(0x17_ef15, 1);  push(ss);                               /* push ss */
            ii(0x17_ef16, 1);  push(ax);                               /* push ax */
            ii(0x17_ef17, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_ef1a, 1);  nop();                                  /* nop */
            ii(0x17_ef1b, 1);  push(cs);                               /* push cs */
            ii(0x17_ef1c, 3);  call(0x17_eb40, -0x3df);                /* call 0xeb40 */
            ii(0x17_ef1f, 3);  add(sp, 0xa);                           /* add sp, 0xa */
        l_0x17_ef22:
            ii(0x17_ef22, 1);  pop(ds);                                /* pop ds */
            ii(0x17_ef23, 1);  leave();                                /* leave */
            ii(0x17_ef24, 1);  retf();                                 /* retf */
        }
    }
}
