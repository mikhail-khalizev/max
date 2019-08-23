using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb190-70e44246")]
        public void Method_0000_b190()
        {
            ii(0xb190, 4);    enter(0x28, 0);                           /* enter 0x28, 0x0 */
            ii(0xb194, 1);    push(di);                                 /* push di */
            ii(0xb195, 1);    push(si);                                 /* push si */
            ii(0xb196, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xb199, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xb19d, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0xb1a1, 2);    if(jae(0xb1a6, 0x3)) goto l_0xb1a6;       /* jae 0xb1a6 */
            ii(0xb1a3, 3);    jmp(0xb22c, 0x86); goto l_0xb22c;         /* jmp 0xb22c */
        l_0xb1a6:
            ii(0xb1a6, 2);    if(ja(0xb1ae, 0x6)) goto l_0xb1ae;        /* ja 0xb1ae */
            ii(0xb1a8, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0xb1ac, 2);    if(jbe(0xb1b5, 0x7)) goto l_0xb1b5;       /* jbe 0xb1b5 */
        l_0xb1ae:
            ii(0xb1ae, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xb1b3, 2);    if(jnz(0xb1b7, 0x2)) goto l_0xb1b7;       /* jnz 0xb1b7 */
        l_0xb1b5:
            ii(0xb1b5, 2);    jmp(0xb22c, 0x75); goto l_0xb22c;         /* jmp 0xb22c */
        l_0xb1b7:
            ii(0xb1b7, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0xb1ba, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0xb1bd, 1);    push(dx);                                 /* push dx */
            ii(0xb1be, 1);    push(ax);                                 /* push ax */
            ii(0xb1bf, 3);    call(0xadad, -0x415);                     /* call 0xadad */
            ii(0xb1c2, 1);    pop(bx);                                  /* pop bx */
            ii(0xb1c3, 1);    pop(bx);                                  /* pop bx */
            ii(0xb1c4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb1c6, 2);    if(jz(0xb21f, 0x57)) goto l_0xb21f;       /* jz 0xb21f */
        l_0xb1c8:
            ii(0xb1c8, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0xb1cb, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0xb1ce, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0xb1d1, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb1d4, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0xb1d7, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0xb1da, 4);    cmp(dx, memw[ds, 0x9e]);                  /* cmp dx, [0x9e] */
            ii(0xb1de, 2);    if(ja(0xb207, 0x27)) goto l_0xb207;       /* ja 0xb207 */
            ii(0xb1e0, 2);    if(jb(0xb1e8, 0x6)) goto l_0xb1e8;        /* jb 0xb1e8 */
            ii(0xb1e2, 4);    cmp(ax, memw[ds, 0x9c]);                  /* cmp ax, [0x9c] */
            ii(0xb1e6, 2);    if(jae(0xb207, 0x1f)) goto l_0xb207;      /* jae 0xb207 */
        l_0xb1e8:
            ii(0xb1e8, 1);    push(dx);                                 /* push dx */
            ii(0xb1e9, 1);    push(ax);                                 /* push ax */
            ii(0xb1ea, 3);    call(0xadad, -0x440);                     /* call 0xadad */
            ii(0xb1ed, 1);    pop(bx);                                  /* pop bx */
            ii(0xb1ee, 1);    pop(bx);                                  /* pop bx */
            ii(0xb1ef, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb1f1, 2);    if(jz(0xb21f, 0x2c)) goto l_0xb21f;       /* jz 0xb21f */
            ii(0xb1f3, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0xb1f6, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0xb1f9, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0xb1fc, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb1ff, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0xb202, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0xb205, 2);    jmp(0xb1c8, -0x3f); goto l_0xb1c8;        /* jmp 0xb1c8 */
        l_0xb207:
            ii(0xb207, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xb20a, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xb20e, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0xb211, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0xb214, 1);    push(dx);                                 /* push dx */
            ii(0xb215, 1);    push(ax);                                 /* push ax */
            ii(0xb216, 3);    call(0xadad, -0x46c);                     /* call 0xadad */
            ii(0xb219, 1);    pop(bx);                                  /* pop bx */
            ii(0xb21a, 1);    pop(bx);                                  /* pop bx */
            ii(0xb21b, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb21d, 2);    if(jnz(0xb22c, 0xd)) goto l_0xb22c;       /* jnz 0xb22c */
        l_0xb21f:
            ii(0xb21f, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0xb222, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0xb225, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0xb228, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0xb22c:
            ii(0xb22c, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xb22e, 3);    mov(memw[ds, 0xa6], ax);                  /* mov [0xa6], ax */
            ii(0xb231, 3);    mov(memw[ds, 0xa4], ax);                  /* mov [0xa4], ax */
            ii(0xb234, 3);    mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0xb237, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0xb23a, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0xb23d, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0xb240, 5);    cmp(memb[ds, 0x2e], 0x3);                 /* cmp byte [0x2e], 0x3 */
            ii(0xb245, 2);    if(jnz(0xb259, 0x12)) goto l_0xb259;      /* jnz 0xb259 */
            ii(0xb247, 3);    lea(ax, memw[ss, bp - 0x6]);              /* lea ax, [bp-0x6] */
            ii(0xb24a, 1);    push(ax);                                 /* push ax */
            ii(0xb24b, 3);    call(0xb09f, -0x1af);                     /* call 0xb09f */
            ii(0xb24e, 1);    pop(bx);                                  /* pop bx */
            ii(0xb24f, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0xb252, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0xb255, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xb257, 2);    if(jnz(0xb26b, 0x12)) goto l_0xb26b;      /* jnz 0xb26b */
        l_0xb259:
            ii(0xb259, 3);    lea(ax, memw[ss, bp - 0x6]);              /* lea ax, [bp-0x6] */
            ii(0xb25c, 1);    push(ax);                                 /* push ax */
            ii(0xb25d, 3);    call(0xb012, -0x24e);                     /* call 0xb012 */
            ii(0xb260, 1);    pop(bx);                                  /* pop bx */
            ii(0xb261, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0xb264, 3);    mov(memw[ss, bp - 0x18], dx);             /* mov [bp-0x18], dx */
            ii(0xb267, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xb269, 2);    if(jz(0xb2a2, 0x37)) goto l_0xb2a2;       /* jz 0xb2a2 */
        l_0xb26b:
            ii(0xb26b, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xb26e, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xb272, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0xb276, 2);    if(ja(0xb2a2, 0x2a)) goto l_0xb2a2;       /* ja 0xb2a2 */
            ii(0xb278, 2);    if(jb(0xb280, 0x6)) goto l_0xb280;        /* jb 0xb280 */
            ii(0xb27a, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0xb27e, 2);    if(ja(0xb2a2, 0x22)) goto l_0xb2a2;       /* ja 0xb2a2 */
        l_0xb280:
            ii(0xb280, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0xb283, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0xb286, 3);    mov(memw[ds, 0x98], ax);                  /* mov [0x98], ax */
            ii(0xb289, 4);    mov(memw[ds, 0x9a], dx);                  /* mov [0x9a], dx */
            ii(0xb28d, 3);    add(ax, memw[ss, bp - 0x6]);              /* add ax, [bp-0x6] */
            ii(0xb290, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb293, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0xb296, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
            ii(0xb29a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xb29c, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
            ii(0xb29f, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
        l_0xb2a2:
            ii(0xb2a2, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xb2a5, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xb2a9, 4);    cmp(memw[ds, 0x9e], dx);                  /* cmp [0x9e], dx */
            ii(0xb2ad, 2);    if(jae(0xb2b2, 0x3)) goto l_0xb2b2;       /* jae 0xb2b2 */
            ii(0xb2af, 3);    jmp(0xb3be, 0x10c); goto l_0xb3be;        /* jmp 0xb3be */
        l_0xb2b2:
            ii(0xb2b2, 2);    if(ja(0xb2bd, 0x9)) goto l_0xb2bd;        /* ja 0xb2bd */
            ii(0xb2b4, 4);    cmp(memw[ds, 0x9c], ax);                  /* cmp [0x9c], ax */
            ii(0xb2b8, 2);    if(ja(0xb2bd, 0x3)) goto l_0xb2bd;        /* ja 0xb2bd */
            ii(0xb2ba, 3);    jmp(0xb3be, 0x101); goto l_0xb3be;        /* jmp 0xb3be */
        l_0xb2bd:
            ii(0xb2bd, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0xb2c0, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb2c3, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0xb2c6, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0xb2c9, 3);    mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0xb2cc, 3);    mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0xb2cf, 6);    mov(memw[ds, 0x11d4], 0x9);               /* mov word [0x11d4], 0x9 */
            ii(0xb2d5, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xb2da, 2);    if(jnz(0xb316, 0x3a)) goto l_0xb316;      /* jnz 0xb316 */
            ii(0xb2dc, 1);    push(dx);                                 /* push dx */
            ii(0xb2dd, 1);    push(ax);                                 /* push ax */
            ii(0xb2de, 3);    call(0xd838, 0x2557);                     /* call 0xd838 */
            ii(0xb2e1, 1);    pop(bx);                                  /* pop bx */
            ii(0xb2e2, 1);    pop(bx);                                  /* pop bx */
            ii(0xb2e3, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb2e5, 2);    if(jnz(0xb2ed, 0x6)) goto l_0xb2ed;       /* jnz 0xb2ed */
            ii(0xb2e7, 2);    push(0x1b);                               /* push 0x1b */
            ii(0xb2e9, 3);    call(0x805d, -0x328f);                    /* call 0x805d */
            ii(0xb2ec, 1);    pop(bx);                                  /* pop bx */
        l_0xb2ed:
            ii(0xb2ed, 5);    test(memb[ds, 0xa16], 0x2);               /* test byte [0xa16], 0x2 */
            ii(0xb2f2, 2);    if(jz(0xb316, 0x22)) goto l_0xb316;       /* jz 0xb316 */
            ii(0xb2f4, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xb2f7, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xb2fb, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0xb2fe, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0xb301, 1);    push(dx);                                 /* push dx */
            ii(0xb302, 1);    push(ax);                                 /* push ax */
            ii(0xb303, 3);    call(0xd838, 0x2532);                     /* call 0xd838 */
            ii(0xb306, 1);    pop(bx);                                  /* pop bx */
            ii(0xb307, 1);    pop(bx);                                  /* pop bx */
            ii(0xb308, 3);    mov(ax, memw[ds, 0xac]);                  /* mov ax, [0xac] */
            ii(0xb30b, 4);    mov(dx, memw[ds, 0xae]);                  /* mov dx, [0xae] */
            ii(0xb30f, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0xb312, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0xb316:
            ii(0xb316, 2);    push(0x10);                               /* push 0x10 */
            ii(0xb318, 3);    lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0xb31b, 1);    push(ax);                                 /* push ax */
            ii(0xb31c, 3);    mov(ax, memw[ds, 0x98]);                  /* mov ax, [0x98] */
            ii(0xb31f, 4);    mov(dx, memw[ds, 0x9a]);                  /* mov dx, [0x9a] */
            ii(0xb323, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb325, 3);    call(0x8554, -0x2dd4);                    /* call 0x8554 */
            ii(0xb328, 1);    push(dx);                                 /* push dx */
            ii(0xb329, 1);    push(ax);                                 /* push ax */
            ii(0xb32a, 3);    call(0x6fd2, -0x435b);                    /* call 0x6fd2 */
            ii(0xb32d, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb330, 3);    mov(ax, memw[ds, 0x9c]);                  /* mov ax, [0x9c] */
            ii(0xb333, 4);    mov(dx, memw[ds, 0x9e]);                  /* mov dx, [0x9e] */
            ii(0xb337, 3);    sub(ax, memw[ss, bp - 0x16]);             /* sub ax, [bp-0x16] */
            ii(0xb33a, 3);    sbb(dx, memw[ss, bp - 0x14]);             /* sbb dx, [bp-0x14] */
            ii(0xb33d, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0xb340, 3);    mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0xb343, 3);    mov(memw[ds, 0xa4], ax);                  /* mov [0xa4], ax */
            ii(0xb346, 4);    mov(memw[ds, 0xa6], dx);                  /* mov [0xa6], dx */
            ii(0xb34a, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0xb34d, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0xb350, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0xb353, 3);    mov(memw[ss, bp - 0x14], dx);             /* mov [bp-0x14], dx */
            ii(0xb356, 2);    push(0x10);                               /* push 0x10 */
            ii(0xb358, 3);    lea(cx, memw[ss, bp - 0x16]);             /* lea cx, [bp-0x16] */
            ii(0xb35b, 1);    push(cx);                                 /* push cx */
            ii(0xb35c, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0xb35f, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0xb362, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb364, 3);    call(0x8554, -0x2e13);                    /* call 0x8554 */
            ii(0xb367, 1);    push(dx);                                 /* push dx */
            ii(0xb368, 1);    push(ax);                                 /* push ax */
            ii(0xb369, 3);    call(0x6fd2, -0x439a);                    /* call 0x6fd2 */
            ii(0xb36c, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb36f, 3);    mov(ax, memw[ss, bp - 0x18]);             /* mov ax, [bp-0x18] */
            ii(0xb372, 3);    or(ax, memw[ss, bp - 0x1a]);              /* or ax, [bp-0x1a] */
            ii(0xb375, 2);    if(jz(0xb3be, 0x47)) goto l_0xb3be;       /* jz 0xb3be */
            ii(0xb377, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xb379, 3);    mov(memw[ss, bp - 0x14], ax);             /* mov [bp-0x14], ax */
            ii(0xb37c, 3);    mov(memw[ss, bp - 0x16], ax);             /* mov [bp-0x16], ax */
            ii(0xb37f, 3);    mov(ax, memw[ss, bp - 0x6]);              /* mov ax, [bp-0x6] */
            ii(0xb382, 2);    sub(dx, dx);                              /* sub dx, dx */
            ii(0xb384, 3);    mov(memw[ss, bp - 0x12], ax);             /* mov [bp-0x12], ax */
            ii(0xb387, 3);    mov(memw[ss, bp - 0x10], dx);             /* mov [bp-0x10], dx */
            ii(0xb38a, 4);    add(memw[ds, 0xa4], ax);                  /* add [0xa4], ax */
            ii(0xb38e, 4);    adc(memw[ds, 0xa6], dx);                  /* adc [0xa6], dx */
            ii(0xb392, 2);    push(0x10);                               /* push 0x10 */
            ii(0xb394, 3);    lea(ax, memw[ss, bp - 0x16]);             /* lea ax, [bp-0x16] */
            ii(0xb397, 1);    push(ax);                                 /* push ax */
            ii(0xb398, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0xb39b, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0xb39e, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb3a0, 3);    call(0x8554, -0x2e4f);                    /* call 0x8554 */
            ii(0xb3a3, 1);    push(dx);                                 /* push dx */
            ii(0xb3a4, 1);    push(ax);                                 /* push ax */
            ii(0xb3a5, 3);    call(0x6fd2, -0x43d6);                    /* call 0x6fd2 */
            ii(0xb3a8, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xb3ab, 3);    mov(ax, memw[ss, bp - 0x1a]);             /* mov ax, [bp-0x1a] */
            ii(0xb3ae, 3);    mov(dx, memw[ss, bp - 0x18]);             /* mov dx, [bp-0x18] */
            ii(0xb3b1, 3);    add(ax, memw[ss, bp - 0x12]);             /* add ax, [bp-0x12] */
            ii(0xb3b4, 3);    adc(dx, memw[ss, bp - 0x10]);             /* adc dx, [bp-0x10] */
            ii(0xb3b7, 3);    mov(memw[ds, 0x9c], ax);                  /* mov [0x9c], ax */
            ii(0xb3ba, 4);    mov(memw[ds, 0x9e], dx);                  /* mov [0x9e], dx */
        l_0xb3be:
            ii(0xb3be, 5);    test(memb[ds, 0x47], 0x80);               /* test byte [0x47], 0x80 */
            ii(0xb3c3, 2);    if(jz(0xb412, 0x4d)) goto l_0xb412;       /* jz 0xb412 */
            ii(0xb3c5, 5);    mov(memb[ds, 0xa16], 0x1);                /* mov byte [0xa16], 0x1 */
            ii(0xb3ca, 5);    mov(memw[ss, bp - 0x28], 0xbfde);         /* mov word [bp-0x28], 0xbfde */
            ii(0xb3cf, 5);    mov(memw[ss, bp - 0x26], 0x4);            /* mov word [bp-0x26], 0x4 */
            ii(0xb3d4, 5);    mov(memw[ss, bp - 0x24], 0x1);            /* mov word [bp-0x24], 0x1 */
            ii(0xb3d9, 5);    cmp(memw[ds, 0xadc], 0);                  /* cmp word [0xadc], 0x0 */
            ii(0xb3de, 2);    if(jnz(0xb3e7, 0x7)) goto l_0xb3e7;       /* jnz 0xb3e7 */
            ii(0xb3e0, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xb3e5, 2);    if(jnz(0xb3ec, 0x5)) goto l_0xb3ec;       /* jnz 0xb3ec */
        l_0xb3e7:
            ii(0xb3e7, 5);    mov(memw[ss, bp - 0x24], 0);              /* mov word [bp-0x24], 0x0 */
        l_0xb3ec:
            ii(0xb3ec, 3);    lea(ax, memw[ss, bp - 0x28]);             /* lea ax, [bp-0x28] */
            ii(0xb3ef, 1);    push(ax);                                 /* push ax */
            ii(0xb3f0, 1);    push(ax);                                 /* push ax */
            ii(0xb3f1, 2);    push(0x15);                               /* push 0x15 */
            ii(0xb3f3, 3);    call(0xbe34, 0xa3e);                      /* call 0xbe34 */
            ii(0xb3f6, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xb3f9, 3);    mov(ax, memw[ss, bp - 0x22]);             /* mov ax, [bp-0x22] */
            ii(0xb3fc, 3);    mov(dx, memw[ss, bp - 0x24]);             /* mov dx, [bp-0x24] */
            ii(0xb3ff, 3);    mov(memw[ds, 0xa0], ax);                  /* mov [0xa0], ax */
            ii(0xb402, 4);    mov(memw[ds, 0xa2], dx);                  /* mov [0xa2], dx */
            ii(0xb406, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0xb408, 3);    mov(si, 0x98);                            /* mov si, 0x98 */
            ii(0xb40b, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0xb40d, 3);    mov(cx, 0xc);                             /* mov cx, 0xc */
            ii(0xb410, 2);    rep(() => movsw());                       /* rep movsw */
        l_0xb412:
            ii(0xb412, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0xb417, 2);    if(jz(0xb42c, 0x13)) goto l_0xb42c;       /* jz 0xb42c */
            ii(0xb419, 3);    mov(ax, memw[ds, 0xa4]);                  /* mov ax, [0xa4] */
            ii(0xb41c, 4);    mov(dx, memw[ds, 0xa6]);                  /* mov dx, [0xa6] */
            ii(0xb420, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0xb422, 3);    call(0x8554, -0x2ed1);                    /* call 0x8554 */
            ii(0xb425, 3);    mov(memw[ds, 0xaa8], ax);                 /* mov [0xaa8], ax */
            ii(0xb428, 4);    mov(memw[ds, 0xaaa], dx);                 /* mov [0xaaa], dx */
        l_0xb42c:
            ii(0xb42c, 1);    pop(si);                                  /* pop si */
            ii(0xb42d, 1);    pop(di);                                  /* pop di */
            ii(0xb42e, 1);    leave();                                  /* leave */
            ii(0xb42f, 1);    ret();                                    /* ret */
        }
    }
}
