using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a2c12a6-fcbb-4c90-bcd9-30041007613d")]
        public void Method_0015_b2cb()
        {
            ii(0x15_b2cb, 4); enterw(0xde, 0);                          /* enter 0xde, 0x0 */
            ii(0x15_b2cf, 1); pushw(di);                                /* push di */
            ii(0x15_b2d0, 1); pushw(si);                                /* push si */
            ii(0x15_b2d1, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b2d4, 5); mov(ax, memw_a16[es, bx + 0x12a]);        /* mov ax, [es:bx+0x12a] */
            ii(0x15_b2d9, 4); mov(memw_a16[ss, bp - 0xca], ax);         /* mov [bp-0xca], ax */
            ii(0x15_b2dd, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x15_b2e0, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x15_b2e3, 1); pushw(es);                                /* push es */
            ii(0x15_b2e4, 1); pushw(ds);                                /* push ds */
            ii(0x15_b2e5, 4); lea(di, bp - 0xc8);                       /* lea di, [bp-0xc8] */
            ii(0x15_b2e9, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_b2eb, 1); pushw(ss);                                /* push ss */
            ii(0x15_b2ec, 1); popw(es);                                 /* pop es */
            ii(0x15_b2ed, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x15_b2ef, 3); mov(cx, 0x62);                            /* mov cx, 0x62 */
            ii(0x15_b2f2, 2); rep_a16(() => movsw_a16());               /* rep movsw */
            ii(0x15_b2f4, 1); popw(ds);                                 /* pop ds */
            ii(0x15_b2f5, 1); popw(es);                                 /* pop es */
            ii(0x15_b2f6, 5); mov(cx, memw_a16[es, bx + 0xb6]);         /* mov cx, [es:bx+0xb6] */
            ii(0x15_b2fb, 5); mov(si, memw_a16[es, bx + 0xb8]);         /* mov si, [es:bx+0xb8] */
            ii(0x15_b300, 3); add(memw_a16[ss, bp - 0x48], cx);         /* add [bp-0x48], cx */
            ii(0x15_b303, 3); adc(memw_a16[ss, bp - 0x46], si);         /* adc [bp-0x46], si */
            ii(0x15_b306, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_b308, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_b30a, 5); add(memw_a16[es, bx + 0x80], cx);         /* add [es:bx+0x80], cx */
            ii(0x15_b30f, 5); adc(memw_a16[es, bx + 0x82], si);         /* adc [es:bx+0x82], si */
            ii(0x15_b314, 3); mov(ax, memw_a16[ss, bp - 0x60]);         /* mov ax, [bp-0x60] */
            ii(0x15_b317, 3); mov(dx, memw_a16[ss, bp - 0x5e]);         /* mov dx, [bp-0x5e] */
            ii(0x15_b31a, 4); sub(ax, memw_a16[ss, bp - 0x88]);         /* sub ax, [bp-0x88] */
            ii(0x15_b31e, 4); sbb(dx, memw_a16[ss, bp - 0x86]);         /* sbb dx, [bp-0x86] */
            ii(0x15_b322, 4); mov(memw_a16[ss, bp - 0x90], ax);         /* mov [bp-0x90], ax */
            ii(0x15_b326, 4); mov(memw_a16[ss, bp - 0x8e], dx);         /* mov [bp-0x8e], dx */
            ii(0x15_b32a, 3); add(ax, memw_a16[ss, bp - 0x3c]);         /* add ax, [bp-0x3c] */
            ii(0x15_b32d, 3); adc(dx, memw_a16[ss, bp - 0x3a]);         /* adc dx, [bp-0x3a] */
            ii(0x15_b330, 3); add(ax, 0xc4);                            /* add ax, 0xc4 */
            ii(0x15_b333, 3); adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x15_b336, 3); mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x15_b339, 3); mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x15_b33c, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b33f, 4); mov(memw_a16[es, bx + 0x5e], ax);         /* mov [es:bx+0x5e], ax */
            ii(0x15_b343, 4); mov(memw_a16[es, bx + 0x60], dx);         /* mov [es:bx+0x60], dx */
            ii(0x15_b347, 1); pushw(es);                                /* push es */
            ii(0x15_b348, 1); pushw(bx);                                /* push bx */
            ii(0x15_b349, 2); pushw(-0x2 /* 0xfe */);                   /* push 0xfffe */
            ii(0x15_b34b, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_b34d, 1); pushw(dx);                                /* push dx */
            ii(0x15_b34e, 1); pushw(ax);                                /* push ax */
            ii(0x15_b34f, 3); callw(0x15_c975, 0x1623);                 /* call 0xc975 */
            ii(0x15_b352, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_b356, 4); mov(memw_a16[ss, bp - 0xd8], dx);         /* mov [bp-0xd8], dx */
            ii(0x15_b35a, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_b35c, 2); if(jnzw(0x15_b364, 0x6)) goto l_0x15_b364; /* jnz 0xb364 */
        l_0x15_b35e:
            ii(0x15_b35e, 3); mov(ax, 0x51b);                           /* mov ax, 0x51b */
            ii(0x15_b361, 3); jmpw(0x15_b5cb, 0x267); goto l_0x15_b5cb; /* jmp 0xb5cb */
        l_0x15_b364:
            ii(0x15_b364, 4); mov(dx, memw_a16[ss, bp - 0xd8]);         /* mov dx, [bp-0xd8] */
            ii(0x15_b368, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b36b, 5); mov(memw_a16[es, bx + 0xba], ax);         /* mov [es:bx+0xba], ax */
            ii(0x15_b370, 5); mov(memw_a16[es, bx + 0xbc], dx);         /* mov [es:bx+0xbc], dx */
            ii(0x15_b375, 1); pushw(dx);                                /* push dx */
            ii(0x15_b376, 1); pushw(ax);                                /* push ax */
            ii(0x15_b377, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x15_b37a, 3); pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x15_b37d, 3); callw(0x15_fb9f, 0x481f);                 /* call 0xfb9f */
            ii(0x15_b380, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_b382, 2); if(jnzw(0x15_b38a, 0x6)) goto l_0x15_b38a; /* jnz 0xb38a */
        l_0x15_b384:
            ii(0x15_b384, 3); mov(ax, 0x522);                           /* mov ax, 0x522 */
            ii(0x15_b387, 3); jmpw(0x15_b5cb, 0x241); goto l_0x15_b5cb; /* jmp 0xb5cb */
        l_0x15_b38a:
            ii(0x15_b38a, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b38e, 4); pushw(memw_a16[ss, bp - 0xd8]);           /* push word [bp-0xd8] */
            ii(0x15_b392, 4); pushw(memw_a16[ss, bp - 0xda]);           /* push word [bp-0xda] */
            ii(0x15_b396, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b398, 3); pushw(0xc4);                              /* push 0xc4 */
            ii(0x15_b39b, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_b39e, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x15_b3a1, 3); add(ax, 0x1c);                            /* add ax, 0x1c */
            ii(0x15_b3a4, 1); pushw(dx);                                /* push dx */
            ii(0x15_b3a5, 1); pushw(ax);                                /* push ax */
            ii(0x15_b3a6, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_b3a8, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_b3aa, 3); callw(0x15_b282, -0x12b);                 /* call 0xb282 */
            ii(0x15_b3ad, 3); pushw(0xc4);                              /* push 0xc4 */
            ii(0x15_b3b0, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_b3b3, 3); pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0x15_b3b6, 2); mov(es, di);                              /* mov es, di */
            ii(0x15_b3b8, 4); pushw(memw_a16[es, si + 0x2]);            /* push word [es:si+0x2] */
            ii(0x15_b3bc, 3); pushw(memw_a16[es, si]);                  /* push word [es:si] */
            ii(0x15_b3bf, 1); nop();                                    /* nop */
            ii(0x15_b3c0, 1); pushw(cs);                                /* push cs */
            ii(0x15_b3c1, 3); callw(0x16_0f5f, 0x5b9b);                 /* call 0xf5f */
            ii(0x15_b3c4, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x15_b3c7, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b3ca, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_b3cf, 4); mov(ax, memw_a16[es, bx + 0x6e]);         /* mov ax, [es:bx+0x6e] */
            ii(0x15_b3d3, 4); mov(dx, memw_a16[es, bx + 0x70]);         /* mov dx, [es:bx+0x70] */
            ii(0x15_b3d7, 4); add(ax, memw_a16[ss, bp - 0x88]);         /* add ax, [bp-0x88] */
            ii(0x15_b3db, 4); adc(dx, memw_a16[ss, bp - 0x86]);         /* adc dx, [bp-0x86] */
            ii(0x15_b3df, 1); pushw(dx);                                /* push dx */
            ii(0x15_b3e0, 1); pushw(ax);                                /* push ax */
            ii(0x15_b3e1, 6); add(memw_a16[ss, bp - 0xda], 0xc4);       /* add word [bp-0xda], 0xc4 */
            ii(0x15_b3e7, 5); adc(memw_a16[ss, bp - 0xd8], 0);          /* adc word [bp-0xd8], 0x0 */
            ii(0x15_b3ec, 4); mov(ax, memw_a16[ss, bp - 0xda]);         /* mov ax, [bp-0xda] */
            ii(0x15_b3f0, 4); mov(dx, memw_a16[ss, bp - 0xd8]);         /* mov dx, [bp-0xd8] */
            ii(0x15_b3f4, 1); pushw(dx);                                /* push dx */
            ii(0x15_b3f5, 1); pushw(ax);                                /* push ax */
            ii(0x15_b3f6, 4); pushw(memw_a16[ss, bp - 0x8e]);           /* push word [bp-0x8e] */
            ii(0x15_b3fa, 4); pushw(memw_a16[ss, bp - 0x90]);           /* push word [bp-0x90] */
            ii(0x15_b3fe, 3); callw(0x15_c4e3, 0x10e2);                 /* call 0xc4e3 */
            ii(0x15_b401, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b405, 4); pushw(memw_a16[ss, bp - 0xd8]);           /* push word [bp-0xd8] */
            ii(0x15_b409, 4); pushw(memw_a16[ss, bp - 0xda]);           /* push word [bp-0xda] */
            ii(0x15_b40d, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_b40f, 2); pushw(0x18);                              /* push 0x18 */
            ii(0x15_b411, 4); pushw(memw_a16[ss, bp - 0x82]);           /* push word [bp-0x82] */
            ii(0x15_b415, 4); pushw(memw_a16[ss, bp - 0x84]);           /* push word [bp-0x84] */
            ii(0x15_b419, 5); callw_far_abs(0x80, 0x4252);              /* call word 0x80:0x4252 */
            ii(0x15_b41e, 1); pushw(dx);                                /* push dx */
            ii(0x15_b41f, 1); pushw(ax);                                /* push ax */
            ii(0x15_b420, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_b423, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_b426, 3); add(cx, 0x3c);                            /* add cx, 0x3c */
            ii(0x15_b429, 1); pushw(bx);                                /* push bx */
            ii(0x15_b42a, 1); pushw(cx);                                /* push cx */
            ii(0x15_b42b, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_b42d, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_b42f, 3); callw(0x15_b282, -0x1b0);                 /* call 0xb282 */
            ii(0x15_b432, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b436, 4); add(si, memw_a16[ss, bp - 0xda]);         /* add si, [bp-0xda] */
            ii(0x15_b43a, 4); adc(di, memw_a16[ss, bp - 0xd8]);         /* adc di, [bp-0xd8] */
            ii(0x15_b43e, 4); mov(memw_a16[ss, bp - 0xda], si);         /* mov [bp-0xda], si */
            ii(0x15_b442, 4); mov(memw_a16[ss, bp - 0xd8], di);         /* mov [bp-0xd8], di */
            ii(0x15_b446, 1); pushw(di);                                /* push di */
            ii(0x15_b447, 1); pushw(si);                                /* push si */
            ii(0x15_b448, 3); mov(ax, memw_a16[ss, bp - 0x70]);         /* mov ax, [bp-0x70] */
            ii(0x15_b44b, 3); mov(dx, memw_a16[ss, bp - 0x6e]);         /* mov dx, [bp-0x6e] */
            ii(0x15_b44e, 3); sub(ax, memw_a16[ss, bp - 0x80]);         /* sub ax, [bp-0x80] */
            ii(0x15_b451, 3); sbb(dx, memw_a16[ss, bp - 0x7e]);         /* sbb dx, [bp-0x7e] */
            ii(0x15_b454, 1); pushw(dx);                                /* push dx */
            ii(0x15_b455, 1); pushw(ax);                                /* push ax */
            ii(0x15_b456, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_b459, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_b45c, 3); add(cx, 0x40);                            /* add cx, 0x40 */
            ii(0x15_b45f, 1); pushw(bx);                                /* push bx */
            ii(0x15_b460, 1); pushw(cx);                                /* push cx */
            ii(0x15_b461, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_b463, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_b465, 3); callw(0x15_b282, -0x1e6);                 /* call 0xb282 */
            ii(0x15_b468, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b46c, 4); add(si, memw_a16[ss, bp - 0xda]);         /* add si, [bp-0xda] */
            ii(0x15_b470, 4); adc(di, memw_a16[ss, bp - 0xd8]);         /* adc di, [bp-0xd8] */
            ii(0x15_b474, 4); mov(memw_a16[ss, bp - 0xda], si);         /* mov [bp-0xda], si */
            ii(0x15_b478, 4); mov(memw_a16[ss, bp - 0xd8], di);         /* mov [bp-0xd8], di */
            ii(0x15_b47c, 1); pushw(di);                                /* push di */
            ii(0x15_b47d, 1); pushw(si);                                /* push si */
            ii(0x15_b47e, 3); mov(ax, memw_a16[ss, bp - 0x6c]);         /* mov ax, [bp-0x6c] */
            ii(0x15_b481, 3); mov(dx, memw_a16[ss, bp - 0x6a]);         /* mov dx, [bp-0x6a] */
            ii(0x15_b484, 3); sub(ax, memw_a16[ss, bp - 0x70]);         /* sub ax, [bp-0x70] */
            ii(0x15_b487, 3); sbb(dx, memw_a16[ss, bp - 0x6e]);         /* sbb dx, [bp-0x6e] */
            ii(0x15_b48a, 1); pushw(dx);                                /* push dx */
            ii(0x15_b48b, 1); pushw(ax);                                /* push ax */
            ii(0x15_b48c, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_b48f, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_b492, 3); add(cx, 0x20);                            /* add cx, 0x20 */
            ii(0x15_b495, 1); pushw(bx);                                /* push bx */
            ii(0x15_b496, 1); pushw(cx);                                /* push cx */
            ii(0x15_b497, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x15_b499, 2); mov(di, dx);                              /* mov di, dx */
            ii(0x15_b49b, 3); callw(0x15_b282, -0x21c);                 /* call 0xb282 */
            ii(0x15_b49e, 3); mov(ax, memw_a16[ss, bp - 0x60]);         /* mov ax, [bp-0x60] */
            ii(0x15_b4a1, 3); mov(dx, memw_a16[ss, bp - 0x5e]);         /* mov dx, [bp-0x5e] */
            ii(0x15_b4a4, 3); sub(ax, memw_a16[ss, bp - 0x6c]);         /* sub ax, [bp-0x6c] */
            ii(0x15_b4a7, 3); sbb(dx, memw_a16[ss, bp - 0x6a]);         /* sbb dx, [bp-0x6a] */
            ii(0x15_b4aa, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_b4ae, 4); mov(memw_a16[ss, bp - 0xd4], dx);         /* mov [bp-0xd4], dx */
            ii(0x15_b4b2, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b4b6, 4); add(si, memw_a16[ss, bp - 0xda]);         /* add si, [bp-0xda] */
            ii(0x15_b4ba, 4); adc(di, memw_a16[ss, bp - 0xd8]);         /* adc di, [bp-0xd8] */
            ii(0x15_b4be, 4); mov(memw_a16[ss, bp - 0xda], si);         /* mov [bp-0xda], si */
            ii(0x15_b4c2, 4); mov(memw_a16[ss, bp - 0xd8], di);         /* mov [bp-0xd8], di */
            ii(0x15_b4c6, 1); pushw(di);                                /* push di */
            ii(0x15_b4c7, 1); pushw(si);                                /* push si */
            ii(0x15_b4c8, 1); pushw(dx);                                /* push dx */
            ii(0x15_b4c9, 1); pushw(ax);                                /* push ax */
            ii(0x15_b4ca, 3); mov(cx, memw_a16[ss, bp + 0x8]);          /* mov cx, [bp+0x8] */
            ii(0x15_b4cd, 3); mov(bx, memw_a16[ss, bp + 0xa]);          /* mov bx, [bp+0xa] */
            ii(0x15_b4d0, 3); add(cx, 0x34);                            /* add cx, 0x34 */
            ii(0x15_b4d3, 1); pushw(bx);                                /* push bx */
            ii(0x15_b4d4, 1); pushw(cx);                                /* push cx */
            ii(0x15_b4d5, 3); callw(0x15_b282, -0x256);                 /* call 0xb282 */
            ii(0x15_b4d8, 4); add(si, memw_a16[ss, bp - 0xd6]);         /* add si, [bp-0xd6] */
            ii(0x15_b4dc, 4); adc(di, memw_a16[ss, bp - 0xd4]);         /* adc di, [bp-0xd4] */
            ii(0x15_b4e0, 4); mov(memw_a16[ss, bp - 0xda], si);         /* mov [bp-0xda], si */
            ii(0x15_b4e4, 4); mov(memw_a16[ss, bp - 0xd8], di);         /* mov [bp-0xd8], di */
            ii(0x15_b4e8, 3); mov(ax, memw_a16[ss, bp - 0x3a]);         /* mov ax, [bp-0x3a] */
            ii(0x15_b4eb, 3); or(ax, memw_a16[ss, bp - 0x3c]);          /* or ax, [bp-0x3c] */
            ii(0x15_b4ee, 2); if(jzw(0x15_b529, 0x39)) goto l_0x15_b529; /* jz 0xb529 */
            ii(0x15_b4f0, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b4f4, 1); pushw(di);                                /* push di */
            ii(0x15_b4f5, 1); pushw(si);                                /* push si */
            ii(0x15_b4f6, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_b4f9, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_b4fc, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x15_b4ff, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x15_b502, 3); add(ax, 0x24);                            /* add ax, 0x24 */
            ii(0x15_b505, 1); pushw(dx);                                /* push dx */
            ii(0x15_b506, 1); pushw(ax);                                /* push ax */
            ii(0x15_b507, 3); callw(0x15_b282, -0x288);                 /* call 0xb282 */
            ii(0x15_b50a, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b50d, 5); pushw(memw_a16[es, bx + 0xb4]);           /* push word [es:bx+0xb4] */
            ii(0x15_b512, 3); pushw(memw_a16[ss, bp - 0x3e]);           /* push word [bp-0x3e] */
            ii(0x15_b515, 3); pushw(memw_a16[ss, bp - 0x40]);           /* push word [bp-0x40] */
            ii(0x15_b518, 4); pushw(memw_a16[ss, bp - 0xd8]);           /* push word [bp-0xd8] */
            ii(0x15_b51c, 4); pushw(memw_a16[ss, bp - 0xda]);           /* push word [bp-0xda] */
            ii(0x15_b520, 3); pushw(memw_a16[ss, bp - 0x3a]);           /* push word [bp-0x3a] */
            ii(0x15_b523, 3); pushw(memw_a16[ss, bp - 0x3c]);           /* push word [bp-0x3c] */
            ii(0x15_b526, 3); callw(0x15_c4e3, 0xfba);                  /* call 0xc4e3 */
        l_0x15_b529:
            ii(0x15_b529, 5); cmp(memb_a16[ds, 0x19f4], 0x1);           /* cmp byte [0x19f4], 0x1 */
            ii(0x15_b52e, 2); if(jzw(0x15_b533, 0x3)) goto l_0x15_b533; /* jz 0xb533 */
            ii(0x15_b530, 3); jmpw(0x15_b5c9, 0x96); goto l_0x15_b5c9;  /* jmp 0xb5c9 */
        l_0x15_b533:
            ii(0x15_b533, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_b536, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_b539, 2); pushw(-0x7 /* 0xf9 */);                   /* push 0xfff9 */
            ii(0x15_b53b, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_b53d, 3); mov(ax, 0x28);                            /* mov ax, 0x28 */
            ii(0x15_b540, 1); cwd();                                    /* cwd */
            ii(0x15_b541, 4); mov(memw_a16[ss, bp - 0xd6], ax);         /* mov [bp-0xd6], ax */
            ii(0x15_b545, 4); mov(memw_a16[ss, bp - 0xd4], dx);         /* mov [bp-0xd4], dx */
            ii(0x15_b549, 1); pushw(dx);                                /* push dx */
            ii(0x15_b54a, 1); pushw(ax);                                /* push ax */
            ii(0x15_b54b, 3); callw(0x15_c975, 0x1427);                 /* call 0xc975 */
            ii(0x15_b54e, 4); mov(memw_a16[ss, bp - 0xda], ax);         /* mov [bp-0xda], ax */
            ii(0x15_b552, 4); mov(memw_a16[ss, bp - 0xd8], dx);         /* mov [bp-0xd8], dx */
            ii(0x15_b556, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_b558, 2); if(jnzw(0x15_b55d, 0x3)) goto l_0x15_b55d; /* jnz 0xb55d */
            ii(0x15_b55a, 3); jmpw(0x15_b35e, -0x1ff); goto l_0x15_b35e; /* jmp 0xb35e */
        l_0x15_b55d:
            ii(0x15_b55d, 4); pushw(memw_a16[ss, bp - 0xd8]);           /* push word [bp-0xd8] */
            ii(0x15_b561, 1); pushw(ax);                                /* push ax */
            ii(0x15_b562, 4); pushw(memw_a16[ss, bp - 0xd4]);           /* push word [bp-0xd4] */
            ii(0x15_b566, 4); pushw(memw_a16[ss, bp - 0xd6]);           /* push word [bp-0xd6] */
            ii(0x15_b56a, 3); callw(0x15_fb9f, 0x4632);                 /* call 0xfb9f */
            ii(0x15_b56d, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_b56f, 2); if(jnzw(0x15_b574, 0x3)) goto l_0x15_b574; /* jnz 0xb574 */
            ii(0x15_b571, 3); jmpw(0x15_b384, -0x1f0); goto l_0x15_b384; /* jmp 0xb384 */
        l_0x15_b574:
            ii(0x15_b574, 4); pushw(memw_a16[ss, bp - 0xca]);           /* push word [bp-0xca] */
            ii(0x15_b578, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x15_b57a, 4); pushw(memw_a16[ss, bp - 0xd8]);           /* push word [bp-0xd8] */
            ii(0x15_b57e, 4); pushw(memw_a16[ss, bp - 0xda]);           /* push word [bp-0xda] */
            ii(0x15_b582, 4); pushw(memw_a16[ss, bp - 0xd4]);           /* push word [bp-0xd4] */
            ii(0x15_b586, 4); pushw(memw_a16[ss, bp - 0xd6]);           /* push word [bp-0xd6] */
            ii(0x15_b58a, 3); callw(0x15_de46, 0x28b9);                 /* call 0xde46 */
            ii(0x15_b58d, 2); mov(es, dx);                              /* mov es, dx */
            ii(0x15_b58f, 2); mov(bx, ax);                              /* mov bx, ax */
            ii(0x15_b591, 2); mov(ax, es);                              /* mov ax, es */
            ii(0x15_b593, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x15_b596, 5); mov(cx, memw_a16[es, si + 0xc4]);         /* mov cx, [es:si+0xc4] */
            ii(0x15_b59b, 5); mov(dx, memw_a16[es, si + 0xc6]);         /* mov dx, [es:si+0xc6] */
            ii(0x15_b5a0, 4); mov(memw_a16[es, si + 0x38], bx);         /* mov [es:si+0x38], bx */
            ii(0x15_b5a4, 4); mov(memw_a16[es, si + 0x3a], ax);         /* mov [es:si+0x3a], ax */
            ii(0x15_b5a8, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x15_b5aa, 3); mov(memw_a16[es, bx], cx);                /* mov [es:bx], cx */
            ii(0x15_b5ad, 4); mov(memw_a16[es, bx + 0x2], dx);          /* mov [es:bx+0x2], dx */
            ii(0x15_b5b1, 3); lea(ax, bx + 0x6);                        /* lea ax, [bx+0x6] */
            ii(0x15_b5b4, 1); pushw(es);                                /* push es */
            ii(0x15_b5b5, 1); pushw(ax);                                /* push ax */
            ii(0x15_b5b6, 3); callw(0x15_e2de, 0x2d25);                 /* call 0xe2de */
            ii(0x15_b5b9, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x15_b5bc, 5); mov(ax, memw_a16[es, bx + 0xb4]);         /* mov ax, [es:bx+0xb4] */
            ii(0x15_b5c1, 4); les(bx, es, bx + 0x38);                   /* les bx, [es:bx+0x38] */
            ii(0x15_b5c5, 4); mov(memw_a16[es, bx + 0x4], ax);          /* mov [es:bx+0x4], ax */
        l_0x15_b5c9:
            ii(0x15_b5c9, 2); sub(ax, ax);                              /* sub ax, ax */
        l_0x15_b5cb:
            ii(0x15_b5cb, 1); popw(si);                                 /* pop si */
            ii(0x15_b5cc, 1); popw(di);                                 /* pop di */
            ii(0x15_b5cd, 1); leavew();                                 /* leave */
            ii(0x15_b5ce, 3); retw(0x8); return;                        /* ret 0x8 */
        }
    }
}
