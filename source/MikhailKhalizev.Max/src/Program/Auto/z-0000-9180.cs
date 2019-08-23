using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9180-70e44246")]
        public void Method_0000_9180()
        {
            ii(0x9180, 4);    enterw(0x28, 0);                          /* enter 0x28, 0x0 */
            ii(0x9184, 1);    pushw(di);                                /* push di */
            ii(0x9185, 1);    pushw(si);                                /* push si */
            ii(0x9186, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x9189, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x918d, 4);    cmp(memw_a16[ds, 0x9e], dx);              /* cmp [0x9e], dx */
            ii(0x9191, 2);    if(jaew(0x9196, 0x3)) goto l_0x9196;      /* jae 0x9196 */
            ii(0x9193, 3);    jmpw(0x921c, 0x86); goto l_0x921c;        /* jmp 0x921c */
        l_0x9196:
            ii(0x9196, 2);    if(jaw(0x919e, 0x6)) goto l_0x919e;       /* ja 0x919e */
            ii(0x9198, 4);    cmp(memw_a16[ds, 0x9c], ax);              /* cmp [0x9c], ax */
            ii(0x919c, 2);    if(jbew(0x91a5, 0x7)) goto l_0x91a5;      /* jbe 0x91a5 */
        l_0x919e:
            ii(0x919e, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x91a3, 2);    if(jnzw(0x91a7, 0x2)) goto l_0x91a7;      /* jnz 0x91a7 */
        l_0x91a5:
            ii(0x91a5, 2);    jmpw(0x921c, 0x75); goto l_0x921c;        /* jmp 0x921c */
        l_0x91a7:
            ii(0x91a7, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x91aa, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x91ad, 1);    pushw(dx);                                /* push dx */
            ii(0x91ae, 1);    pushw(ax);                                /* push ax */
            ii(0x91af, 3);    callw(0x8d9d, -0x415);                    /* call 0x8d9d */
            ii(0x91b2, 1);    popw(bx);                                 /* pop bx */
            ii(0x91b3, 1);    popw(bx);                                 /* pop bx */
            ii(0x91b4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x91b6, 2);    if(jzw(0x920f, 0x57)) goto l_0x920f;      /* jz 0x920f */
        l_0x91b8:
            ii(0x91b8, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x91bb, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x91be, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0x91c1, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x91c4, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x91c7, 3);    mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x91ca, 4);    cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0x91ce, 2);    if(jaw(0x91f7, 0x27)) goto l_0x91f7;      /* ja 0x91f7 */
            ii(0x91d0, 2);    if(jbw(0x91d8, 0x6)) goto l_0x91d8;       /* jb 0x91d8 */
            ii(0x91d2, 4);    cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0x91d6, 2);    if(jaew(0x91f7, 0x1f)) goto l_0x91f7;     /* jae 0x91f7 */
        l_0x91d8:
            ii(0x91d8, 1);    pushw(dx);                                /* push dx */
            ii(0x91d9, 1);    pushw(ax);                                /* push ax */
            ii(0x91da, 3);    callw(0x8d9d, -0x440);                    /* call 0x8d9d */
            ii(0x91dd, 1);    popw(bx);                                 /* pop bx */
            ii(0x91de, 1);    popw(bx);                                 /* pop bx */
            ii(0x91df, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x91e1, 2);    if(jzw(0x920f, 0x2c)) goto l_0x920f;      /* jz 0x920f */
            ii(0x91e3, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x91e6, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x91e9, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x91ec, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x91ef, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x91f2, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x91f5, 2);    jmpw(0x91b8, -0x3f); goto l_0x91b8;       /* jmp 0x91b8 */
        l_0x91f7:
            ii(0x91f7, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x91fa, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x91fe, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x9201, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x9204, 1);    pushw(dx);                                /* push dx */
            ii(0x9205, 1);    pushw(ax);                                /* push ax */
            ii(0x9206, 3);    callw(0x8d9d, -0x46c);                    /* call 0x8d9d */
            ii(0x9209, 1);    popw(bx);                                 /* pop bx */
            ii(0x920a, 1);    popw(bx);                                 /* pop bx */
            ii(0x920b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x920d, 2);    if(jnzw(0x921c, 0xd)) goto l_0x921c;      /* jnz 0x921c */
        l_0x920f:
            ii(0x920f, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x9212, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x9215, 3);    mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x9218, 4);    mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
        l_0x921c:
            ii(0x921c, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x921e, 3);    mov(memw_a16[ds, 0xa6], ax);              /* mov [0xa6], ax */
            ii(0x9221, 3);    mov(memw_a16[ds, 0xa4], ax);              /* mov [0xa4], ax */
            ii(0x9224, 3);    mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x9227, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x922a, 3);    mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x922d, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x9230, 5);    cmp(memb_a16[ds, 0x2e], 0x3);             /* cmp byte [0x2e], 0x3 */
            ii(0x9235, 2);    if(jnzw(0x9249, 0x12)) goto l_0x9249;     /* jnz 0x9249 */
            ii(0x9237, 3);    lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x923a, 1);    pushw(ax);                                /* push ax */
            ii(0x923b, 3);    callw(0x908f, -0x1af);                    /* call 0x908f */
            ii(0x923e, 1);    popw(bx);                                 /* pop bx */
            ii(0x923f, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x9242, 3);    mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x9245, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x9247, 2);    if(jnzw(0x925b, 0x12)) goto l_0x925b;     /* jnz 0x925b */
        l_0x9249:
            ii(0x9249, 3);    lea(ax, bp - 0x6);                        /* lea ax, [bp-0x6] */
            ii(0x924c, 1);    pushw(ax);                                /* push ax */
            ii(0x924d, 3);    callw(0x9002, -0x24e);                    /* call 0x9002 */
            ii(0x9250, 1);    popw(bx);                                 /* pop bx */
            ii(0x9251, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x9254, 3);    mov(memw_a16[ss, bp - 0x18], dx);         /* mov [bp-0x18], dx */
            ii(0x9257, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0x9259, 2);    if(jzw(0x9292, 0x37)) goto l_0x9292;      /* jz 0x9292 */
        l_0x925b:
            ii(0x925b, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x925e, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x9262, 4);    cmp(memw_a16[ds, 0x9e], dx);              /* cmp [0x9e], dx */
            ii(0x9266, 2);    if(jaw(0x9292, 0x2a)) goto l_0x9292;      /* ja 0x9292 */
            ii(0x9268, 2);    if(jbw(0x9270, 0x6)) goto l_0x9270;       /* jb 0x9270 */
            ii(0x926a, 4);    cmp(memw_a16[ds, 0x9c], ax);              /* cmp [0x9c], ax */
            ii(0x926e, 2);    if(jaw(0x9292, 0x22)) goto l_0x9292;      /* ja 0x9292 */
        l_0x9270:
            ii(0x9270, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x9273, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x9276, 3);    mov(memw_a16[ds, 0x98], ax);              /* mov [0x98], ax */
            ii(0x9279, 4);    mov(memw_a16[ds, 0x9a], dx);              /* mov [0x9a], dx */
            ii(0x927d, 3);    add(ax, memw_a16[ss, bp - 0x6]);          /* add ax, [bp-0x6] */
            ii(0x9280, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x9283, 3);    mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x9286, 4);    mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
            ii(0x928a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x928c, 3);    mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x928f, 3);    mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
        l_0x9292:
            ii(0x9292, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x9295, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x9299, 4);    cmp(memw_a16[ds, 0x9e], dx);              /* cmp [0x9e], dx */
            ii(0x929d, 2);    if(jaew(0x92a2, 0x3)) goto l_0x92a2;      /* jae 0x92a2 */
            ii(0x929f, 3);    jmpw(0x93ae, 0x10c); goto l_0x93ae;       /* jmp 0x93ae */
        l_0x92a2:
            ii(0x92a2, 2);    if(jaw(0x92ad, 0x9)) goto l_0x92ad;       /* ja 0x92ad */
            ii(0x92a4, 4);    cmp(memw_a16[ds, 0x9c], ax);              /* cmp [0x9c], ax */
            ii(0x92a8, 2);    if(jaw(0x92ad, 0x3)) goto l_0x92ad;       /* ja 0x92ad */
            ii(0x92aa, 3);    jmpw(0x93ae, 0x101); goto l_0x93ae;       /* jmp 0x93ae */
        l_0x92ad:
            ii(0x92ad, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0x92b0, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x92b3, 3);    mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x92b6, 3);    mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x92b9, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0x92bc, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0x92bf, 6);    mov(memw_a16[ds, 0x11d4], 0x9);           /* mov word [0x11d4], 0x9 */
            ii(0x92c5, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x92ca, 2);    if(jnzw(0x9306, 0x3a)) goto l_0x9306;     /* jnz 0x9306 */
            ii(0x92cc, 1);    pushw(dx);                                /* push dx */
            ii(0x92cd, 1);    pushw(ax);                                /* push ax */
            ii(0x92ce, 3);    callw(0xb828, 0x2557);                    /* call 0xb828 */
            ii(0x92d1, 1);    popw(bx);                                 /* pop bx */
            ii(0x92d2, 1);    popw(bx);                                 /* pop bx */
            ii(0x92d3, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x92d5, 2);    if(jnzw(0x92dd, 0x6)) goto l_0x92dd;      /* jnz 0x92dd */
            ii(0x92d7, 2);    pushw(0x1b);                              /* push 0x1b */
            ii(0x92d9, 3);    callw(0x604d, -0x328f);                   /* call 0x604d */
            ii(0x92dc, 1);    popw(bx);                                 /* pop bx */
        l_0x92dd:
            ii(0x92dd, 5);    test(memb_a16[ds, 0xa16], 0x2);           /* test byte [0xa16], 0x2 */
            ii(0x92e2, 2);    if(jzw(0x9306, 0x22)) goto l_0x9306;      /* jz 0x9306 */
            ii(0x92e4, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x92e7, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x92eb, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0x92ee, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0x92f1, 1);    pushw(dx);                                /* push dx */
            ii(0x92f2, 1);    pushw(ax);                                /* push ax */
            ii(0x92f3, 3);    callw(0xb828, 0x2532);                    /* call 0xb828 */
            ii(0x92f6, 1);    popw(bx);                                 /* pop bx */
            ii(0x92f7, 1);    popw(bx);                                 /* pop bx */
            ii(0x92f8, 3);    mov(ax, memw_a16[ds, 0xac]);              /* mov ax, [0xac] */
            ii(0x92fb, 4);    mov(dx, memw_a16[ds, 0xae]);              /* mov dx, [0xae] */
            ii(0x92ff, 3);    mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x9302, 4);    mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
        l_0x9306:
            ii(0x9306, 2);    pushw(0x10);                              /* push 0x10 */
            ii(0x9308, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x930b, 1);    pushw(ax);                                /* push ax */
            ii(0x930c, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0x930f, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0x9313, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x9315, 3);    callw(0x6544, -0x2dd4);                   /* call 0x6544 */
            ii(0x9318, 1);    pushw(dx);                                /* push dx */
            ii(0x9319, 1);    pushw(ax);                                /* push ax */
            ii(0x931a, 3);    callw(0x4fc2, -0x435b);                   /* call 0x4fc2 */
            ii(0x931d, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x9320, 3);    mov(ax, memw_a16[ds, 0x9c]);              /* mov ax, [0x9c] */
            ii(0x9323, 4);    mov(dx, memw_a16[ds, 0x9e]);              /* mov dx, [0x9e] */
            ii(0x9327, 3);    sub(ax, memw_a16[ss, bp - 0x16]);         /* sub ax, [bp-0x16] */
            ii(0x932a, 3);    sbb(dx, memw_a16[ss, bp - 0x14]);         /* sbb dx, [bp-0x14] */
            ii(0x932d, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x9330, 3);    mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x9333, 3);    mov(memw_a16[ds, 0xa4], ax);              /* mov [0xa4], ax */
            ii(0x9336, 4);    mov(memw_a16[ds, 0xa6], dx);              /* mov [0xa6], dx */
            ii(0x933a, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x933d, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x9340, 3);    mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x9343, 3);    mov(memw_a16[ss, bp - 0x14], dx);         /* mov [bp-0x14], dx */
            ii(0x9346, 2);    pushw(0x10);                              /* push 0x10 */
            ii(0x9348, 3);    lea(cx, bp - 0x16);                       /* lea cx, [bp-0x16] */
            ii(0x934b, 1);    pushw(cx);                                /* push cx */
            ii(0x934c, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x934f, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x9352, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x9354, 3);    callw(0x6544, -0x2e13);                   /* call 0x6544 */
            ii(0x9357, 1);    pushw(dx);                                /* push dx */
            ii(0x9358, 1);    pushw(ax);                                /* push ax */
            ii(0x9359, 3);    callw(0x4fc2, -0x439a);                   /* call 0x4fc2 */
            ii(0x935c, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x935f, 3);    mov(ax, memw_a16[ss, bp - 0x18]);         /* mov ax, [bp-0x18] */
            ii(0x9362, 3);    or(ax, memw_a16[ss, bp - 0x1a]);          /* or ax, [bp-0x1a] */
            ii(0x9365, 2);    if(jzw(0x93ae, 0x47)) goto l_0x93ae;      /* jz 0x93ae */
            ii(0x9367, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x9369, 3);    mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x936c, 3);    mov(memw_a16[ss, bp - 0x16], ax);         /* mov [bp-0x16], ax */
            ii(0x936f, 3);    mov(ax, memw_a16[ss, bp - 0x6]);          /* mov ax, [bp-0x6] */
            ii(0x9372, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0x9374, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x9377, 3);    mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0x937a, 4);    add(memw_a16[ds, 0xa4], ax);              /* add [0xa4], ax */
            ii(0x937e, 4);    adc(memw_a16[ds, 0xa6], dx);              /* adc [0xa6], dx */
            ii(0x9382, 2);    pushw(0x10);                              /* push 0x10 */
            ii(0x9384, 3);    lea(ax, bp - 0x16);                       /* lea ax, [bp-0x16] */
            ii(0x9387, 1);    pushw(ax);                                /* push ax */
            ii(0x9388, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x938b, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x938e, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x9390, 3);    callw(0x6544, -0x2e4f);                   /* call 0x6544 */
            ii(0x9393, 1);    pushw(dx);                                /* push dx */
            ii(0x9394, 1);    pushw(ax);                                /* push ax */
            ii(0x9395, 3);    callw(0x4fc2, -0x43d6);                   /* call 0x4fc2 */
            ii(0x9398, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x939b, 3);    mov(ax, memw_a16[ss, bp - 0x1a]);         /* mov ax, [bp-0x1a] */
            ii(0x939e, 3);    mov(dx, memw_a16[ss, bp - 0x18]);         /* mov dx, [bp-0x18] */
            ii(0x93a1, 3);    add(ax, memw_a16[ss, bp - 0x12]);         /* add ax, [bp-0x12] */
            ii(0x93a4, 3);    adc(dx, memw_a16[ss, bp - 0x10]);         /* adc dx, [bp-0x10] */
            ii(0x93a7, 3);    mov(memw_a16[ds, 0x9c], ax);              /* mov [0x9c], ax */
            ii(0x93aa, 4);    mov(memw_a16[ds, 0x9e], dx);              /* mov [0x9e], dx */
        l_0x93ae:
            ii(0x93ae, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0x93b3, 2);    if(jzw(0x9402, 0x4d)) goto l_0x9402;      /* jz 0x9402 */
            ii(0x93b5, 5);    mov(memb_a16[ds, 0xa16], 0x1);            /* mov byte [0xa16], 0x1 */
            ii(0x93ba, 5);    mov(memw_a16[ss, bp - 0x28], 0xbfde);     /* mov word [bp-0x28], 0xbfde */
            ii(0x93bf, 5);    mov(memw_a16[ss, bp - 0x26], 0x4);        /* mov word [bp-0x26], 0x4 */
            ii(0x93c4, 5);    mov(memw_a16[ss, bp - 0x24], 0x1);        /* mov word [bp-0x24], 0x1 */
            ii(0x93c9, 5);    cmp(memw_a16[ds, 0xadc], 0);              /* cmp word [0xadc], 0x0 */
            ii(0x93ce, 2);    if(jnzw(0x93d7, 0x7)) goto l_0x93d7;      /* jnz 0x93d7 */
            ii(0x93d0, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x93d5, 2);    if(jnzw(0x93dc, 0x5)) goto l_0x93dc;      /* jnz 0x93dc */
        l_0x93d7:
            ii(0x93d7, 5);    mov(memw_a16[ss, bp - 0x24], 0);          /* mov word [bp-0x24], 0x0 */
        l_0x93dc:
            ii(0x93dc, 3);    lea(ax, bp - 0x28);                       /* lea ax, [bp-0x28] */
            ii(0x93df, 1);    pushw(ax);                                /* push ax */
            ii(0x93e0, 1);    pushw(ax);                                /* push ax */
            ii(0x93e1, 2);    pushw(0x15);                              /* push 0x15 */
            ii(0x93e3, 3);    callw(0x9e24, 0xa3e);                     /* call 0x9e24 */
            ii(0x93e6, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x93e9, 3);    mov(ax, memw_a16[ss, bp - 0x22]);         /* mov ax, [bp-0x22] */
            ii(0x93ec, 3);    mov(dx, memw_a16[ss, bp - 0x24]);         /* mov dx, [bp-0x24] */
            ii(0x93ef, 3);    mov(memw_a16[ds, 0xa0], ax);              /* mov [0xa0], ax */
            ii(0x93f2, 4);    mov(memw_a16[ds, 0xa2], dx);              /* mov [0xa2], dx */
            ii(0x93f6, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x93f8, 3);    mov(si, 0x98);                            /* mov si, 0x98 */
            ii(0x93fb, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x93fd, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0x9400, 2);    rep_a16(() => movsw_a16());               /* rep movsw */
        l_0x9402:
            ii(0x9402, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x9407, 2);    if(jzw(0x941c, 0x13)) goto l_0x941c;      /* jz 0x941c */
            ii(0x9409, 3);    mov(ax, memw_a16[ds, 0xa4]);              /* mov ax, [0xa4] */
            ii(0x940c, 4);    mov(dx, memw_a16[ds, 0xa6]);              /* mov dx, [0xa6] */
            ii(0x9410, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x9412, 3);    callw(0x6544, -0x2ed1);                   /* call 0x6544 */
            ii(0x9415, 3);    mov(memw_a16[ds, 0xaa8], ax);             /* mov [0xaa8], ax */
            ii(0x9418, 4);    mov(memw_a16[ds, 0xaaa], dx);             /* mov [0xaaa], dx */
        l_0x941c:
            ii(0x941c, 1);    popw(si);                                 /* pop si */
            ii(0x941d, 1);    popw(di);                                 /* pop di */
            ii(0x941e, 1);    leavew();                                 /* leave */
            ii(0x941f, 1);    retw();                                   /* ret */
        }
    }
}
