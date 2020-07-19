using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_5122-93f669a9")]
        public void Method_0017_5122()
        {
            ii(0x17_5122, 1);  push(ds);                               /* push ds */
            ii(0x17_5123, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_5126, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_5128, 1);  push(ds);                               /* push ds */
            ii(0x17_5129, 3);  push(0x192);                            /* push 0x192 */
            ii(0x17_512c, 1);  nop();                                  /* nop */
            ii(0x17_512d, 1);  push(cs);                               /* push cs */
            ii(0x17_512e, 3);  call(0x17_100a, -0x4127);               /* call 0x100a */
            ii(0x17_5131, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5134, 1);  push(ds);                               /* push ds */
            ii(0x17_5135, 3);  push(0x1b7);                            /* push 0x1b7 */
            ii(0x17_5138, 1);  nop();                                  /* nop */
            ii(0x17_5139, 1);  push(cs);                               /* push cs */
            ii(0x17_513a, 3);  call(0x17_100a, -0x4133);               /* call 0x100a */
            ii(0x17_513d, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5140, 5);  cmp(memb[ds, 0x39], 0);                 /* cmp byte [0x39], 0x0 */
            ii(0x17_5145, 2);  if(jz(0x17_514c, 5)) goto l_0x17_514c;  /* jz 0x514c */
            ii(0x17_5147, 3);  mov(ax, 0x1ca);                         /* mov ax, 0x1ca */
            ii(0x17_514a, 2);  jmp(0x17_514f, 3); goto l_0x17_514f;    /* jmp 0x514f */
        l_0x17_514c:
            ii(0x17_514c, 3);  mov(ax, 0x1ce);                         /* mov ax, 0x1ce */
        l_0x17_514f:
            ii(0x17_514f, 1);  push(ds);                               /* push ds */
            ii(0x17_5150, 1);  push(ax);                               /* push ax */
            ii(0x17_5151, 1);  nop();                                  /* nop */
            ii(0x17_5152, 1);  push(cs);                               /* push cs */
            ii(0x17_5153, 3);  call(0x17_100a, -0x414c);               /* call 0x100a */
            ii(0x17_5156, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5159, 4);  push(memw[ds, 0x26]);                   /* push word [0x26] */
            ii(0x17_515d, 4);  push(memw[ds, 0x24]);                   /* push word [0x24] */
            ii(0x17_5161, 1);  push(ds);                               /* push ds */
            ii(0x17_5162, 3);  push(0x1d3);                            /* push 0x1d3 */
            ii(0x17_5165, 1);  nop();                                  /* nop */
            ii(0x17_5166, 1);  push(cs);                               /* push cs */
            ii(0x17_5167, 3);  call(0x17_100a, -0x4160);               /* call 0x100a */
            ii(0x17_516a, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_516d, 4);  push(memw[ds, 0x32]);                   /* push word [0x32] */
            ii(0x17_5171, 4);  push(memw[ds, 0x30]);                   /* push word [0x30] */
            ii(0x17_5175, 1);  push(ds);                               /* push ds */
            ii(0x17_5176, 3);  push(0x1ea);                            /* push 0x1ea */
            ii(0x17_5179, 1);  nop();                                  /* nop */
            ii(0x17_517a, 1);  push(cs);                               /* push cs */
            ii(0x17_517b, 3);  call(0x17_100a, -0x4174);               /* call 0x100a */
            ii(0x17_517e, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5181, 4);  push(memw[ds, 0x36]);                   /* push word [0x36] */
            ii(0x17_5185, 4);  push(memw[ds, 0x34]);                   /* push word [0x34] */
            ii(0x17_5189, 1);  push(ds);                               /* push ds */
            ii(0x17_518a, 3);  push(0x201);                            /* push 0x201 */
            ii(0x17_518d, 1);  nop();                                  /* nop */
            ii(0x17_518e, 1);  push(cs);                               /* push cs */
            ii(0x17_518f, 3);  call(0x17_100a, -0x4188);               /* call 0x100a */
            ii(0x17_5192, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5195, 4);  push(memw[ds, 0x16]);                   /* push word [0x16] */
            ii(0x17_5199, 4);  push(memw[ds, 0x14]);                   /* push word [0x14] */
            ii(0x17_519d, 1);  push(ds);                               /* push ds */
            ii(0x17_519e, 3);  push(0x218);                            /* push 0x218 */
            ii(0x17_51a1, 1);  nop();                                  /* nop */
            ii(0x17_51a2, 1);  push(cs);                               /* push cs */
            ii(0x17_51a3, 3);  call(0x17_100a, -0x419c);               /* call 0x100a */
            ii(0x17_51a6, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_51a9, 4);  push(memw[ds, 0x1a]);                   /* push word [0x1a] */
            ii(0x17_51ad, 4);  push(memw[ds, 0x18]);                   /* push word [0x18] */
            ii(0x17_51b1, 1);  push(ds);                               /* push ds */
            ii(0x17_51b2, 3);  push(0x22e);                            /* push 0x22e */
            ii(0x17_51b5, 1);  nop();                                  /* nop */
            ii(0x17_51b6, 1);  push(cs);                               /* push cs */
            ii(0x17_51b7, 3);  call(0x17_100a, -0x41b0);               /* call 0x100a */
            ii(0x17_51ba, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_51bd, 2);  push(0);                                /* push 0x0 */
            ii(0x17_51bf, 3);  push(0x400);                            /* push 0x400 */
            ii(0x17_51c2, 3);  mov(ax, memw[ds, 0x1fc0]);              /* mov ax, [0x1fc0] */
            ii(0x17_51c5, 4);  mov(dx, memw[ds, 0x1fc2]);              /* mov dx, [0x1fc2] */
            ii(0x17_51c9, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_51cb, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_51cd, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_51cf, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_51d1, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_51d3, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_51d5, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_51d7, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_51d9, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_51db, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_51dd, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_51df, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_51e1, 1);  push(dx);                               /* push dx */
            ii(0x17_51e2, 1);  push(ax);                               /* push ax */
            ii(0x17_51e3, 1);  nop();                                  /* nop */
            ii(0x17_51e4, 1);  push(cs);                               /* push cs */
            ii(0x17_51e5, 3);  call(0x16_dddc, -0x740c);               /* call 0xdddc */
            ii(0x17_51e8, 1);  push(dx);                               /* push dx */
            ii(0x17_51e9, 1);  push(ax);                               /* push ax */
            ii(0x17_51ea, 1);  push(ds);                               /* push ds */
            ii(0x17_51eb, 3);  push(0x244);                            /* push 0x244 */
            ii(0x17_51ee, 1);  nop();                                  /* nop */
            ii(0x17_51ef, 1);  push(cs);                               /* push cs */
            ii(0x17_51f0, 3);  call(0x17_100a, -0x41e9);               /* call 0x100a */
            ii(0x17_51f3, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_51f6, 2);  push(0);                                /* push 0x0 */
            ii(0x17_51f8, 3);  push(0x400);                            /* push 0x400 */
            ii(0x17_51fb, 3);  mov(ax, memw[ds, 0x1fc8]);              /* mov ax, [0x1fc8] */
            ii(0x17_51fe, 4);  mov(dx, memw[ds, 0x1fca]);              /* mov dx, [0x1fca] */
            ii(0x17_5202, 2);  mov(dh, dl);                            /* mov dh, dl */
            ii(0x17_5204, 2);  mov(dl, ah);                            /* mov dl, ah */
            ii(0x17_5206, 2);  mov(ah, al);                            /* mov ah, al */
            ii(0x17_5208, 2);  sub(al, al);                            /* sub al, al */
            ii(0x17_520a, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_520c, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_520e, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5210, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5212, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5214, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5216, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5218, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_521a, 1);  push(dx);                               /* push dx */
            ii(0x17_521b, 1);  push(ax);                               /* push ax */
            ii(0x17_521c, 1);  nop();                                  /* nop */
            ii(0x17_521d, 1);  push(cs);                               /* push cs */
            ii(0x17_521e, 3);  call(0x16_dddc, -0x7445);               /* call 0xdddc */
            ii(0x17_5221, 1);  push(dx);                               /* push dx */
            ii(0x17_5222, 1);  push(ax);                               /* push ax */
            ii(0x17_5223, 1);  push(ds);                               /* push ds */
            ii(0x17_5224, 3);  push(0x272);                            /* push 0x272 */
            ii(0x17_5227, 1);  nop();                                  /* nop */
            ii(0x17_5228, 1);  push(cs);                               /* push cs */
            ii(0x17_5229, 3);  call(0x17_100a, -0x4222);               /* call 0x100a */
            ii(0x17_522c, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_522f, 1);  push(ds);                               /* push ds */
            ii(0x17_5230, 3);  push(0x3c);                             /* push 0x3c */
            ii(0x17_5233, 1);  push(ds);                               /* push ds */
            ii(0x17_5234, 3);  push(0x289);                            /* push 0x289 */
            ii(0x17_5237, 1);  nop();                                  /* nop */
            ii(0x17_5238, 1);  push(cs);                               /* push cs */
            ii(0x17_5239, 3);  call(0x17_100a, -0x4232);               /* call 0x100a */
            ii(0x17_523c, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_523f, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5240, 1);  retf();                                 /* retf */
        }
    }
}
