using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_5242-c5ff94ac")]
        public void Method_0017_5242()
        {
            ii(0x17_5242, 4);  enter(0x2a, 0);                         /* enter 0x2a, 0x0 */
            ii(0x17_5246, 1);  push(ds);                               /* push ds */
            ii(0x17_5247, 3);  mov(ax, 0x3e68);                        /* mov ax, 0x3e68 */
            ii(0x17_524a, 2);  mov(ds, ax);                            /* mov ds, ax */
            ii(0x17_524c, 1);  push(ds);                               /* push ds */
            ii(0x17_524d, 3);  push(0x2a2);                            /* push 0x2a2 */
            ii(0x17_5250, 1);  nop();                                  /* nop */
            ii(0x17_5251, 1);  push(cs);                               /* push cs */
            ii(0x17_5252, 3);  call(0x16_edf0, -0x6465);               /* call 0xedf0 */
            ii(0x17_5255, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_5258, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_525b, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_525e, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_5260, 2);  if(jnz(0x17_5268, 6)) goto l_0x17_5268; /* jnz 0x5268 */
            ii(0x17_5262, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5265, 3);  jmp(0x17_54b0, 0x248); goto l_0x17_54b0;/* jmp 0x54b0 */
        l_0x17_5268:
            ii(0x17_5268, 1);  push(ds);                               /* push ds */
            ii(0x17_5269, 3);  push(0x2ab);                            /* push 0x2ab */
            ii(0x17_526c, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_526f, 1);  push(ax);                               /* push ax */
            ii(0x17_5270, 1);  nop();                                  /* nop */
            ii(0x17_5271, 1);  push(cs);                               /* push cs */
            ii(0x17_5272, 3);  call(0x16_ec70, -0x6605);               /* call 0xec70 */
            ii(0x17_5275, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5278, 3);  mov(memw[ss, bp - 32], ax);             /* mov [bp-0x20], ax */
            ii(0x17_527b, 3);  mov(memw[ss, bp - 30], dx);             /* mov [bp-0x1e], dx */
            ii(0x17_527e, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_5280, 2);  if(jz(0x17_52c4, 0x42)) goto l_0x17_52c4;/* jz 0x52c4 */
            ii(0x17_5282, 1);  push(ds);                               /* push ds */
            ii(0x17_5283, 3);  push(0x2b9);                            /* push 0x2b9 */
            ii(0x17_5286, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5289, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_528c, 1);  nop();                                  /* nop */
            ii(0x17_528d, 1);  push(cs);                               /* push cs */
            ii(0x17_528e, 3);  call(0x16_ec70, -0x6621);               /* call 0xec70 */
            ii(0x17_5291, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5294, 3);  mov(memw[ds, 0x1efc], ax);              /* mov [0x1efc], ax */
            ii(0x17_5297, 4);  mov(memw[ds, 0x1efe], dx);              /* mov [0x1efe], dx */
            ii(0x17_529b, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_529d, 4);  or(ax, memw[ds, 0x1efc]);               /* or ax, [0x1efc] */
            ii(0x17_52a1, 2);  if(jz(0x17_52c4, 0x21)) goto l_0x17_52c4;/* jz 0x52c4 */
            ii(0x17_52a3, 1);  push(ds);                               /* push ds */
            ii(0x17_52a4, 3);  push(0x2c5);                            /* push 0x2c5 */
            ii(0x17_52a7, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_52aa, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_52ad, 1);  nop();                                  /* nop */
            ii(0x17_52ae, 1);  push(cs);                               /* push cs */
            ii(0x17_52af, 3);  call(0x16_ec70, -0x6642);               /* call 0xec70 */
            ii(0x17_52b2, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_52b5, 3);  mov(memw[ds, 0x4fc8], ax);              /* mov [0x4fc8], ax */
            ii(0x17_52b8, 4);  mov(memw[ds, 0x4fca], dx);              /* mov [0x4fca], dx */
            ii(0x17_52bc, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_52be, 4);  or(ax, memw[ds, 0x4fc8]);               /* or ax, [0x4fc8] */
            ii(0x17_52c2, 2);  if(jnz(0x17_52d4, 0x10)) goto l_0x17_52d4;/* jnz 0x52d4 */
        l_0x17_52c4:
            ii(0x17_52c4, 3);  push(0x8f6);                            /* push 0x8f6 */
            ii(0x17_52c7, 1);  push(cs);                               /* push cs */
            ii(0x17_52c8, 3);  call(0x17_75b4, 0x22e9);                /* call 0x75b4 */
            ii(0x17_52cb, 3);  add(sp, 2);                             /* add sp, 0x2 */
            ii(0x17_52ce, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_52d1, 3);  jmp(0x17_54b0, 0x1dc); goto l_0x17_54b0;/* jmp 0x54b0 */
        l_0x17_52d4:
            ii(0x17_52d4, 1);  push(ds);                               /* push ds */
            ii(0x17_52d5, 3);  push(0x2ce);                            /* push 0x2ce */
            ii(0x17_52d8, 1);  nop();                                  /* nop */
            ii(0x17_52d9, 1);  push(cs);                               /* push cs */
            ii(0x17_52da, 3);  call(0x16_edf0, -0x64ed);               /* call 0xedf0 */
            ii(0x17_52dd, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_52e0, 3);  mov(memw[ss, bp - 4], ax);              /* mov [bp-0x4], ax */
            ii(0x17_52e3, 3);  mov(memw[ss, bp - 2], dx);              /* mov [bp-0x2], dx */
            ii(0x17_52e6, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_52e8, 2);  if(jnz(0x17_52f0, 6)) goto l_0x17_52f0; /* jnz 0x52f0 */
            ii(0x17_52ea, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_52ed, 3);  jmp(0x17_54b0, 0x1c0); goto l_0x17_54b0;/* jmp 0x54b0 */
        l_0x17_52f0:
            ii(0x17_52f0, 1);  push(ds);                               /* push ds */
            ii(0x17_52f1, 3);  push(0x2de);                            /* push 0x2de */
            ii(0x17_52f4, 1);  push(ds);                               /* push ds */
            ii(0x17_52f5, 3);  push(0x2d9);                            /* push 0x2d9 */
            ii(0x17_52f8, 3);  call(0x16_f569, -0x5d92);               /* call 0xf569 */
            ii(0x17_52fb, 3);  mov(memw[ss, bp - 8], ax);              /* mov [bp-0x8], ax */
            ii(0x17_52fe, 3);  mov(memw[ss, bp - 6], dx);              /* mov [bp-0x6], dx */
            ii(0x17_5301, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_5303, 2);  if(jz(0x17_531a, 0x15)) goto l_0x17_531a;/* jz 0x531a */
            ii(0x17_5305, 3);  call_far_ind(memw[ss, bp - 8]);         /* call far word [bp-0x8] */
            ii(0x17_5308, 1);  push(dx);                               /* push dx */
            ii(0x17_5309, 1);  push(ax);                               /* push ax */
            ii(0x17_530a, 1);  push(ds);                               /* push ds */
            ii(0x17_530b, 3);  push(0x2e9);                            /* push 0x2e9 */
            ii(0x17_530e, 3);  call(0x16_f6b0, -0x5c61);               /* call 0xf6b0 */
            ii(0x17_5311, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_5313, 2);  if(jge(0x17_531a, 5)) goto l_0x17_531a; /* jge 0x531a */
            ii(0x17_5315, 5);  mov(memb[ds, 5], 1);                    /* mov byte [0x5], 0x1 */
        l_0x17_531a:
            ii(0x17_531a, 1);  push(ds);                               /* push ds */
            ii(0x17_531b, 3);  push(0x2f1);                            /* push 0x2f1 */
            ii(0x17_531e, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5321, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5324, 1);  nop();                                  /* nop */
            ii(0x17_5325, 1);  push(cs);                               /* push cs */
            ii(0x17_5326, 3);  call(0x16_ec70, -0x66b9);               /* call 0xec70 */
            ii(0x17_5329, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_532c, 3);  mov(memw[ds, 0x1fdc], ax);              /* mov [0x1fdc], ax */
            ii(0x17_532f, 4);  mov(memw[ds, 0x1fde], dx);              /* mov [0x1fde], dx */
            ii(0x17_5333, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5335, 4);  or(ax, memw[ds, 0x1fdc]);               /* or ax, [0x1fdc] */
            ii(0x17_5339, 2);  if(jz(0x17_534a, 0xf)) goto l_0x17_534a;/* jz 0x534a */
            ii(0x17_533b, 4);  call_far_ind(memw[ds, 0x1fdc]);         /* call far word [0x1fdc] */
            ii(0x17_533f, 2);  or(ax, ax);                             /* or ax, ax */
            ii(0x17_5341, 2);  if(jz(0x17_534a, 7)) goto l_0x17_534a;  /* jz 0x534a */
            ii(0x17_5343, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5346, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5347, 1);  leave();                                /* leave */
            ii(0x17_5348, 1);  retf(); return;                         /* retf */
        //  ii(0x17_5349, 1);  Недостижимый код.
        l_0x17_534a:
            ii(0x17_534a, 1);  push(ds);                               /* push ds */
            ii(0x17_534b, 3);  push(0x2f6);                            /* push 0x2f6 */
            ii(0x17_534e, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5351, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_5354, 1);  nop();                                  /* nop */
            ii(0x17_5355, 1);  push(cs);                               /* push cs */
            ii(0x17_5356, 3);  call(0x16_ec70, -0x66e9);               /* call 0xec70 */
            ii(0x17_5359, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_535c, 3);  mov(memw[ds, 0x4fac], ax);              /* mov [0x4fac], ax */
            ii(0x17_535f, 4);  mov(memw[ds, 0x4fae], dx);              /* mov [0x4fae], dx */
            ii(0x17_5363, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_5365, 4);  or(ax, memw[ds, 0x4fac]);               /* or ax, [0x4fac] */
            ii(0x17_5369, 2);  if(jnz(0x17_5372, 7)) goto l_0x17_5372; /* jnz 0x5372 */
            ii(0x17_536b, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_536e, 1);  pop(ds);                                /* pop ds */
            ii(0x17_536f, 1);  leave();                                /* leave */
            ii(0x17_5370, 1);  retf(); return;                         /* retf */
        //  ii(0x17_5371, 1);  Недостижимый код.
        l_0x17_5372:
            ii(0x17_5372, 1);  push(ds);                               /* push ds */
            ii(0x17_5373, 3);  push(0x306);                            /* push 0x306 */
            ii(0x17_5376, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_5379, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_537c, 1);  nop();                                  /* nop */
            ii(0x17_537d, 1);  push(cs);                               /* push cs */
            ii(0x17_537e, 3);  call(0x16_ec70, -0x6711);               /* call 0xec70 */
            ii(0x17_5381, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_5384, 3);  mov(memw[ds, 0x4fb0], ax);              /* mov [0x4fb0], ax */
            ii(0x17_5387, 4);  mov(memw[ds, 0x4fb2], dx);              /* mov [0x4fb2], dx */
            ii(0x17_538b, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_538d, 4);  or(ax, memw[ds, 0x4fb0]);               /* or ax, [0x4fb0] */
            ii(0x17_5391, 2);  if(jnz(0x17_539a, 7)) goto l_0x17_539a; /* jnz 0x539a */
            ii(0x17_5393, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_5396, 1);  pop(ds);                                /* pop ds */
            ii(0x17_5397, 1);  leave();                                /* leave */
            ii(0x17_5398, 1);  retf(); return;                         /* retf */
        //  ii(0x17_5399, 1);  Недостижимый код.
        l_0x17_539a:
            ii(0x17_539a, 1);  push(ds);                               /* push ds */
            ii(0x17_539b, 3);  push(0x314);                            /* push 0x314 */
            ii(0x17_539e, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_53a1, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_53a4, 1);  nop();                                  /* nop */
            ii(0x17_53a5, 1);  push(cs);                               /* push cs */
            ii(0x17_53a6, 3);  call(0x16_ec70, -0x6739);               /* call 0xec70 */
            ii(0x17_53a9, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_53ac, 3);  mov(memw[ds, 0x1f54], ax);              /* mov [0x1f54], ax */
            ii(0x17_53af, 4);  mov(memw[ds, 0x1f56], dx);              /* mov [0x1f56], dx */
            ii(0x17_53b3, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_53b5, 4);  or(ax, memw[ds, 0x1f54]);               /* or ax, [0x1f54] */
            ii(0x17_53b9, 2);  if(jnz(0x17_53c2, 7)) goto l_0x17_53c2; /* jnz 0x53c2 */
            ii(0x17_53bb, 3);  mov(ax, 1);                             /* mov ax, 0x1 */
            ii(0x17_53be, 1);  pop(ds);                                /* pop ds */
            ii(0x17_53bf, 1);  leave();                                /* leave */
            ii(0x17_53c0, 1);  retf(); return;                         /* retf */
        //  ii(0x17_53c1, 1);  Недостижимый код.
        l_0x17_53c2:
            ii(0x17_53c2, 1);  push(ds);                               /* push ds */
            ii(0x17_53c3, 3);  push(0x31c);                            /* push 0x31c */
            ii(0x17_53c6, 3);  push(memw[ss, bp - 2]);                 /* push word [bp-0x2] */
            ii(0x17_53c9, 3);  push(memw[ss, bp - 4]);                 /* push word [bp-0x4] */
            ii(0x17_53cc, 1);  nop();                                  /* nop */
            ii(0x17_53cd, 1);  push(cs);                               /* push cs */
            ii(0x17_53ce, 3);  call(0x16_ec70, -0x6761);               /* call 0xec70 */
            ii(0x17_53d1, 3);  add(sp, 8);                             /* add sp, 0x8 */
            ii(0x17_53d4, 3);  mov(memw[ss, bp - 42], ax);             /* mov [bp-0x2a], ax */
            ii(0x17_53d7, 3);  mov(memw[ss, bp - 40], dx);             /* mov [bp-0x28], dx */
            ii(0x17_53da, 2);  or(dx, ax);                             /* or dx, ax */
            ii(0x17_53dc, 2);  if(jz(0x17_544a, 0x6c)) goto l_0x17_544a;/* jz 0x544a */
            ii(0x17_53de, 3);  push(0x3e58);                           /* push 0x3e58 */
            ii(0x17_53e1, 3);  push(0x468a);                           /* push 0x468a */
            ii(0x17_53e4, 1);  nop();                                  /* nop */
            ii(0x17_53e5, 1);  push(cs);                               /* push cs */
            ii(0x17_53e6, 3);  call(0x16_e630, -0x6db9);               /* call 0xe630 */
            ii(0x17_53e9, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_53ec, 3);  mov(memw[ss, bp - 38], ax);             /* mov [bp-0x26], ax */
            ii(0x17_53ef, 3);  mov(memw[ss, bp - 36], dx);             /* mov [bp-0x24], dx */
            ii(0x17_53f2, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_53f4, 3);  or(ax, memw[ss, bp - 38]);              /* or ax, [bp-0x26] */
            ii(0x17_53f7, 2);  if(jz(0x17_544a, 0x51)) goto l_0x17_544a;/* jz 0x544a */
            ii(0x17_53f9, 2);  mov(ax, dx);                            /* mov ax, dx */
            ii(0x17_53fb, 3);  mov(memw[ss, bp - 34], ax);             /* mov [bp-0x22], ax */
            ii(0x17_53fe, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x17_5401, 3);  mov(dx, memw[ss, bp - 30]);             /* mov dx, [bp-0x1e] */
            ii(0x17_5404, 3);  les(bx, memw[ss, bp - 38]);             /* les bx, [bp-0x26] */
            ii(0x17_5407, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x17_540a, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x17_540e, 5);  mov(memw[ss, bp - 38], 0x468e);         /* mov word [bp-0x26], 0x468e */
            ii(0x17_5413, 5);  mov(memw[ss, bp - 36], 0x3e58);         /* mov word [bp-0x24], 0x3e58 */
            ii(0x17_5418, 3);  mov(ax, memw[ss, bp - 34]);             /* mov ax, [bp-0x22] */
            ii(0x17_541b, 3);  mov(memw[ss, bp - 36], ax);             /* mov [bp-0x24], ax */
            ii(0x17_541e, 3);  mov(ax, memw[ss, bp - 42]);             /* mov ax, [bp-0x2a] */
            ii(0x17_5421, 3);  mov(dx, memw[ss, bp - 40]);             /* mov dx, [bp-0x28] */
            ii(0x17_5424, 3);  les(bx, memw[ss, bp - 38]);             /* les bx, [bp-0x26] */
            ii(0x17_5427, 3);  mov(memw[es, bx], ax);                  /* mov [es:bx], ax */
            ii(0x17_542a, 4);  mov(memw[es, bx + 2], dx);              /* mov [es:bx+0x2], dx */
            ii(0x17_542e, 3);  push(memw[ss, bp - 36]);                /* push word [bp-0x24] */
            ii(0x17_5431, 3);  push(memw[ss, bp - 38]);                /* push word [bp-0x26] */
            ii(0x17_5434, 1);  nop();                                  /* nop */
            ii(0x17_5435, 1);  push(cs);                               /* push cs */
            ii(0x17_5436, 3);  call(0x16_e758, -0x6ce1);               /* call 0xe758 */
            ii(0x17_5439, 3);  add(sp, 4);                             /* add sp, 0x4 */
            ii(0x17_543c, 6);  mov(memw[ds, 0x1fe0], 0x4692);          /* mov word [0x1fe0], 0x4692 */
            ii(0x17_5442, 6);  mov(memw[ds, 0x1fe2], 0x3e58);          /* mov word [0x1fe2], 0x3e58 */
            ii(0x17_5448, 2);  jmp(0x17_5457, 0xd); goto l_0x17_5457;  /* jmp 0x5457 */
        l_0x17_544a:
            ii(0x17_544a, 3);  mov(ax, memw[ss, bp - 32]);             /* mov ax, [bp-0x20] */
            ii(0x17_544d, 3);  mov(dx, memw[ss, bp - 30]);             /* mov dx, [bp-0x1e] */
            ii(0x17_5450, 3);  mov(memw[ds, 0x1fe0], ax);              /* mov [0x1fe0], ax */
            ii(0x17_5453, 4);  mov(memw[ds, 0x1fe2], dx);              /* mov [0x1fe2], dx */
        l_0x17_5457:
            ii(0x17_5457, 1);  push(cs);                               /* push cs */
            ii(0x17_5458, 3);  call(0x17_7408, 0x1fad);                /* call 0x7408 */
            ii(0x17_545b, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_545d, 3);  mov(memw[ss, bp - 26], ax);             /* mov [bp-0x1a], ax */
            ii(0x17_5460, 3);  mov(memw[ss, bp - 28], ax);             /* mov [bp-0x1c], ax */
            ii(0x17_5463, 5);  mov(memw[ss, bp - 10], 0xff00);         /* mov word [bp-0xa], 0xff00 */
            ii(0x17_5468, 5);  mov(memw[ss, bp - 14], 0xe00);          /* mov word [bp-0xe], 0xe00 */
            ii(0x17_546d, 3);  lea(ax, memw[ss, bp - 28]);             /* lea ax, [bp-0x1c] */
            ii(0x17_5470, 1);  push(ss);                               /* push ss */
            ii(0x17_5471, 1);  push(ax);                               /* push ax */
            ii(0x17_5472, 2);  push(-1 /* 0xff */);                    /* push 0xffff */
            ii(0x17_5474, 1);  nop();                                  /* nop */
            ii(0x17_5475, 1);  push(cs);                               /* push cs */
            ii(0x17_5476, 3);  call(0x16_eaed, -0x698c);               /* call 0xeaed */
            ii(0x17_5479, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x17_547c, 3);  mov(bx, memw[ss, bp - 10]);             /* mov bx, [bp-0xa] */
            ii(0x17_547f, 3);  mov(cx, memw[ss, bp - 14]);             /* mov cx, [bp-0xe] */
            ii(0x17_5482, 2);  mov(es, cx);                            /* mov es, cx */
            ii(0x17_5484, 4);  mov(memw[ds, 0x2018], bx);              /* mov [0x2018], bx */
            ii(0x17_5488, 4);  mov(memw[ds, 0x201a], es);              /* mov [0x201a], es */
            ii(0x17_548c, 4);  mov(ax, memw[es, bx + 4]);              /* mov ax, [es:bx+0x4] */
            ii(0x17_5490, 4);  mov(dx, memw[es, bx + 6]);              /* mov dx, [es:bx+0x6] */
            ii(0x17_5494, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_5496, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_5498, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_549a, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_549c, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_549e, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_54a0, 2);  shl(ax, 1);                             /* shl ax, 1 */
            ii(0x17_54a2, 2);  rcl(dx, 1);                             /* rcl dx, 1 */
            ii(0x17_54a4, 3);  mov(memw[ds, 0x8c], ax);                /* mov [0x8c], ax */
            ii(0x17_54a7, 4);  mov(memw[ds, 0x8e], dx);                /* mov [0x8e], dx */
            ii(0x17_54ab, 2);  sub(ax, ax);                            /* sub ax, ax */
            ii(0x17_54ad, 1);  pop(ds);                                /* pop ds */
            ii(0x17_54ae, 1);  leave();                                /* leave */
            ii(0x17_54af, 1);  retf(); return;                         /* retf */
        l_0x17_54b0:
            ii(0x17_54b0, 1);  pop(ds);                                /* pop ds */
            ii(0x17_54b1, 1);  leave();                                /* leave */
            ii(0x17_54b2, 1);  retf();                                 /* retf */
        }
    }
}
