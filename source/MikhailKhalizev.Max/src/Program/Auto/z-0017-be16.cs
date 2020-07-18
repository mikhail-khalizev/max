using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_be16-f200d743")]
        public void Method_0017_be16()
        {
            ii(0x17_be16, 4);  enter(0x10, 0);                         /* enter 0x10, 0x0 */
            ii(0x17_be1a, 1);  push(ds);                               /* push ds */
            ii(0x17_be1b, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_be1e, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_be20, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_be22, 3);  mov(memw[ss, bp - 2], ax);              /* mov [bp-0x2], ax */
            ii(0x17_be25, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_be28, 3);  push(memw[ss, bp + 6]);                 /* push word [bp+0x6] */
            ii(0x17_be2b, 1);  push(cs);                               /* push cs */
            ii(0x17_be2c, 3);  call(0x17_c79c, 0x96d);                 /* call 0xc79c */
            ii(0x17_be2f, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_be32, 3);  mov(memw[ss, bp - 12], ax);             /* mov [bp-0xc], ax */
            ii(0x17_be35, 3);  mov(memw[ss, bp - 10], dx);             /* mov [bp-0xa], dx */
            ii(0x17_be38, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_be3b, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_be3e, 3);  cmp(ax, 0xffff);                        /* cmp ax, 0xffff */
            ii(0x17_be41, 2);  if(jnz(0x17_be4a, 7)) goto l_0x17_be4a; /* jnz 0xbe4a */
            ii(0x17_be43, 2);  cmp(dx, ax);                            /* cmp dx, ax */
            ii(0x17_be45, 2);  if(jnz(0x17_be4a, 3)) goto l_0x17_be4a; /* jnz 0xbe4a */
            ii(0x17_be47, 3);  jmp(0x17_bee8, 0x9e); goto l_0x17_bee8; /* jmp 0xbee8 */
        l_0x17_be4a:
            ii(0x17_be4a, 3);  push(memw[ss, bp - 10]);                /* push word [bp-0xa] */
            ii(0x17_be4d, 3);  push(memw[ss, bp - 12]);                /* push word [bp-0xc] */
            ii(0x17_be50, 4);  add(memw[ss, bp - 12], 1);              /* add word [bp-0xc], 0x1 */
            ii(0x17_be54, 4);  adc(memw[ss, bp - 10], 0);              /* adc word [bp-0xa], 0x0 */
            ii(0x17_be58, 4);  push(memw[ds, 0x4ff6]);                 /* push word [0x4ff6] */
            ii(0x17_be5c, 4);  push(memw[ds, 0x4ff4]);                 /* push word [0x4ff4] */
            ii(0x17_be60, 3);  call(0x17_90c4, -0x2d9f);               /* call 0x90c4 */
            ii(0x17_be63, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_be66, 3);  cmp(ax, memw[ss, bp + 6]);              /* cmp ax, [bp+0x6] */
            ii(0x17_be69, 2);  if(jnz(0x17_be76, 0xb)) goto l_0x17_be76;/* jnz 0xbe76 */
            ii(0x17_be6b, 4);  add(memw[ss, bp - 4], 1);               /* add word [bp-0x4], 0x1 */
            ii(0x17_be6f, 4);  adc(memw[ss, bp - 2], 0);               /* adc word [bp-0x2], 0x0 */
            ii(0x17_be73, 2);  jmp(0x17_be4a, -0x2b); goto l_0x17_be4a;/* jmp 0xbe4a */
        //  ii(0x17_be75, 1);  Недостижимый код.
        l_0x17_be76:
            ii(0x17_be76, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_be79, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_be7c, 3);  push(memw[ss, bp - 6]);                 /* push word [bp-0x6] */
            ii(0x17_be7f, 3);  push(memw[ss, bp - 8]);                 /* push word [bp-0x8] */
            ii(0x17_be82, 1);  push(cs);                               /* push cs */
            ii(0x17_be83, 3);  call(0x17_c560, 0x6da);                 /* call 0xc560 */
            ii(0x17_be86, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_be89, 3);  mov(ax, memw[ss, bp - 4]);              /* mov ax, [bp-0x4] */
            ii(0x17_be8c, 3);  mov(dx, memw[ss, bp - 2]);              /* mov dx, [bp-0x2] */
            ii(0x17_be8f, 4);  add(memw[ds, 0x1fac], ax);              /* add [0x1fac], ax */
            ii(0x17_be93, 4);  adc(memw[ds, 0x1fae], dx);              /* adc [0x1fae], dx */
            ii(0x17_be97, 4);  add(memw[ds, 0x1fc4], ax);              /* add [0x1fc4], ax */
            ii(0x17_be9b, 4);  adc(memw[ds, 0x1fc6], dx);              /* adc [0x1fc6], dx */
            ii(0x17_be9f, 4);  add(memw[ds, 0x1fbc], ax);              /* add [0x1fbc], ax */
            ii(0x17_bea3, 4);  adc(memw[ds, 0x1fbe], dx);              /* adc [0x1fbe], dx */
            ii(0x17_bea7, 3);  mov(ax, memw[ss, bp - 8]);              /* mov ax, [bp-0x8] */
            ii(0x17_beaa, 3);  mov(dx, memw[ss, bp - 6]);              /* mov dx, [bp-0x6] */
            ii(0x17_bead, 3);  add(ax, 0);                             /* add ax, 0x0 */
            ii(0x17_beb0, 3);  adc(dx, 1);                             /* adc dx, 0x1 */
            ii(0x17_beb3, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_beb5, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_beb7, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_beb9, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_bebb, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_bebd, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_bebf, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_bec1, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_bec3, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_bec5, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_bec7, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_bec9, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_becb, 1);  push(dx);                               /* push dx */
            ii(0x17_becc, 1);  push(ax);                               /* push ax */
            ii(0x17_becd, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_bed0, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_bed3, 1);  push(ds);                               /* push ds */
            ii(0x17_bed4, 3);  push(0x13d5);                           /* push 0x13d5 */
            ii(0x17_bed7, 1);  nop();                                  /* nop */
            ii(0x17_bed8, 1);  push(cs);                               /* push cs */
            ii(0x17_bed9, 3);  call(0x18_104f, 0x5173);                /* call 0x104f */
            ii(0x17_bedc, 3);  add(sp, 0xc);                           /* add sp, 0xc */
            ii(0x17_bedf, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_bee1, 1);  pop(ds);                                /* pop ds */
            ii(0x17_bee2, 1);  leave();                                /* leave */
            ii(0x17_bee3, 1);  retf(); return;                         /* retf */
        //  ii(0x17_bee4, 4);  Недостижимый код.
        l_0x17_bee8:
            ii(0x17_bee8, 3);  mov(ax, 0x8023);                        /* mov ax, 0x8023 */
            ii(0x17_beeb, 1);  pop(ds);                                /* pop ds */
            ii(0x17_beec, 1);  leave();                                /* leave */
            ii(0x17_beed, 1);  retf();                                 /* retf */
        }
    }
}
