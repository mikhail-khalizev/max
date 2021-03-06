using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4fae-adf5900d")]
        public void Method_0017_4fae()
        {
            ii(0x17_4fae, 4);  enter(0xc, 0);                          /* enter 0xc, 0x0 */
            ii(0x17_4fb2, 1);  push(di);                               /* push di */
            ii(0x17_4fb3, 1);  push(si);                               /* push si */
            ii(0x17_4fb4, 1);  push(ds);                               /* push ds */
            ii(0x17_4fb5, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_4fb8, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_4fba, 3);  mov(ax, 0x70);                          /* mov ax, 0x70 */
            ii(0x17_4fbd, 3);  mov(dx, 0x10);                          /* mov dx, 0x10 */
            ii(0x17_4fc0, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_4fc3, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_4fc6, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_4fc9, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_4fcc, 2);  mov(es, dx);                            /* mov es, dx */
            ii(0x17_4fce, 3);  mov(bx, 0x72);                          /* mov bx, 0x72 */
            ii(0x17_4fd1, 3);  mov(ax, memw[es, bx]);                  /* mov ax, [es:bx] */
            ii(0x17_4fd4, 3);  mov(bx, 0x70);                          /* mov bx, 0x70 */
            ii(0x17_4fd7, 3);  mov(cx, memw[es, bx]);                  /* mov cx, [es:bx] */
            ii(0x17_4fda, 4);  mov(memw[ds, 0x5131], cx);              /* mov [0x5131], cx */
            ii(0x17_4fde, 3);  mov(memw[ds, 0x5133], ax);              /* mov [0x5133], ax */
            ii(0x17_4fe1, 3);  mov(ax, 0x9e);                          /* mov ax, 0x9e */
            ii(0x17_4fe4, 1);  push(ds);                               /* push ds */
            ii(0x17_4fe5, 2);  mov(di, ax);                            /* mov di, ax */
            ii(0x17_4fe7, 2);  mov(si, bx);                            /* mov si, bx */
            ii(0x17_4fe9, 1);  push(ds);                               /* push ds */
            ii(0x17_4fea, 1);  pop(es);                                /* pop es */
            ii(0x17_4feb, 2);  mov(ds, dx);                            /* mov ds, dx */
            ii(0x17_4fed, 1);  movsw();                                /* movsw */
            ii(0x17_4fee, 1);  movsw();                                /* movsw */
            ii(0x17_4fef, 1);  movsw();                                /* movsw */
            ii(0x17_4ff0, 1);  movsw();                                /* movsw */
            ii(0x17_4ff1, 1);  pop(ds);                                /* pop ds */
            ii(0x17_4ff2, 2);  push(0x68);                             /* push 0x68 */
            ii(0x17_4ff4, 1);  nop();                                  /* nop */
            ii(0x17_4ff5, 1);  push(cs);                               /* push cs */
            ii(0x17_4ff6, 3);  call(0x16_e7a8, -0x6851);               /* call 0xe7a8 */
            ii(0x17_4ff9, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_4ffc, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_4fff, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_5002, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5004, 3);  or(ax, memw[ss, bp - 8]);               /* or ax, [bp-0x8] */
            ii(0x17_5007, 2);  if(jnz(0x17_501e, 0x15)) goto l_0x17_501e;/* jnz 0x501e */
            ii(0x17_5009, 1);  push(ds);                               /* push ds */
            ii(0x17_500a, 3);  push(0x145);                            /* push 0x145 */
            ii(0x17_500d, 1);  nop();                                  /* nop */
            ii(0x17_500e, 1);  push(cs);                               /* push cs */
            ii(0x17_500f, 3);  call(0x17_104f, -0x3fc3);               /* call 0x104f */
            ii(0x17_5012, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5015, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5018, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5019, 1);  pop(si);                                /* pop si */
            ii(0x17_501a, 1);  pop(di);                                /* pop di */
            ii(0x17_501b, 1);  leave();                                /* leave */
            ii(0x17_501c, 1);  retf(); return;                         /* retf */
        //  ii(0x17_501d, 1);  Недостижимый код.
        l_0x17_501e:
            ii(0x17_501e, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5020, 3);  mov(memw[ds, 0x50c2], ax);              /* mov [0x50c2], ax */
            ii(0x17_5023, 2);  push(0x68);                             /* push 0x68 */
            ii(0x17_5025, 1);  push(ax);                               /* push ax */
            ii(0x17_5026, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x17_5029, 1);  nop();                                  /* nop */
            ii(0x17_502a, 1);  push(cs);                               /* push cs */
            ii(0x17_502b, 3);  call(0x17_8ed0, 0x3ea2);                /* call 0x8ed0 */
            ii(0x17_502e, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_5031, 5);  cmp(memw[ds, 0x51a0], 0);               /* cmp word [0x51a0], 0x0 */
            ii(0x17_5036, 2);  if(jnz(0x17_5061, 0x29)) goto l_0x17_5061;/* jnz 0x5061 */
            ii(0x17_5038, 1);  cli();                                  /* cli */
            ii(0x17_5039, 4);  push(memw[ds, 0x1efa]);                 /* push word [0x1efa] */
            ii(0x17_503d, 1);  push(cs);                               /* push cs */
            ii(0x17_503e, 3);  call(0x17_5622, 0x5e1);                 /* call 0x5622 */
            ii(0x17_5041, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5044, 1);  nop();                                  /* nop */
            ii(0x17_5045, 1);  push(cs);                               /* push cs */
            ii(0x17_5046, 3);  call(0x17_8e80, 0x3e37);                /* call 0x8e80 */
            ii(0x17_5049, 4);  les(bx, memw[ds, 0x1ef8]);              /* les bx, [0x1ef8] */
            ii(0x17_504d, 4);  mov(memw[es, bx + 28], ax);             /* mov [es:bx+0x1c], ax */
            ii(0x17_5051, 4);  mov(memw[es, bx + 30], dx);             /* mov [es:bx+0x1e], dx */
            ii(0x17_5055, 4);  push(memw[ds, 0x1efa]);                 /* push word [0x1efa] */
            ii(0x17_5059, 1);  push(cs);                               /* push cs */
            ii(0x17_505a, 3);  call(0x17_55f0, 0x593);                 /* call 0x55f0 */
            ii(0x17_505d, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5060, 1);  sti();                                  /* sti */
        l_0x17_5061:
            ii(0x17_5061, 1);  nop();                                  /* nop */
            ii(0x17_5062, 1);  push(cs);                               /* push cs */
            ii(0x17_5063, 3);  call(0x17_8e80, 0x3e1a);                /* call 0x8e80 */
            ii(0x17_5066, 3);  les(bx, memw[ss, bp - 8]);              /* les bx, [bp-0x8] */
            ii(0x17_5069, 4);  mov(memw[es, bx + 28], ax);             /* mov [es:bx+0x1c], ax */
            ii(0x17_506d, 4);  mov(memw[es, bx + 30], dx);             /* mov [es:bx+0x1e], dx */
            ii(0x17_5071, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x17_5074, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x17_5077, 1);  push(cs);                               /* push cs */
            ii(0x17_5078, 3);  call(0x17_54b4, 0x439);                 /* call 0x54b4 */
            ii(0x17_507b, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_507e, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x17_5081, 1);  push(cs);                               /* push cs */
            ii(0x17_5082, 3);  call(0x17_55f0, 0x56b);                 /* call 0x55f0 */
            ii(0x17_5085, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_5088, 3);  mov(ax, memw[ss, bp - 6]);              /* mov ax, [bp-0x6] */
            ii(0x17_508b, 3);  les(bx, memw[ss, bp - 4]);              /* les bx, [bp-0x4] */
            ii(0x17_508e, 4);  mov(memw[es, bx + 2], ax);              /* mov [es:bx+0x2], ax */
            ii(0x17_5092, 4);  mov(al, memb[es, bx + 5]);              /* mov al, [es:bx+0x5] */
            ii(0x17_5096, 2);  and(al, 0xe5);                          /* and al, 0xe5 */
            ii(0x17_5098, 2);  or(al, 5);                              /* or al, 0x5 */
            ii(0x17_509a, 4);  mov(memb[es, bx + 5], al);              /* mov [es:bx+0x5], al */
            ii(0x17_509e, 5);  and(memb[es, bx + 5], -0x61 /* 0x9f */);/* and byte [es:bx+0x5], 0x9f */
            ii(0x17_50a3, 5);  or(memb[es, bx + 5], -0x80 /* 0x80 */); /* or byte [es:bx+0x5], 0x80 */
            ii(0x17_50a8, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_50aa, 1);  pop(ds);                                /* pop ds */
            ii(0x17_50ab, 1);  pop(si);                                /* pop si */
            ii(0x17_50ac, 1);  pop(di);                                /* pop di */
            ii(0x17_50ad, 1);  leave();                                /* leave */
            ii(0x17_50ae, 1);  retf();                                 /* retf */
        }
    }
}
