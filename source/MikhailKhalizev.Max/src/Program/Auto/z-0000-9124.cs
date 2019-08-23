using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9124-28a311f8")]
        public void Method_0000_9124()
        {
            ii(0x9124, 3);    mov(al, memb[ss, bp - 0xa]);              /* mov al, [bp-0xa] */
            ii(0x9127, 3);    mov(memb[ds, 0x980], al);                 /* mov [0x980], al */
            ii(0x912a, 3);    call(0xb436, 0x2309);                     /* call 0xb436 */
            ii(0x912d, 2);    jmp(0x9132, 0x3); goto l_0x9132;          /* jmp 0x9132 */
        //  ii(0x912f, 3);    call(0x9736, 0x604);                      /* call 0x9736 */
        l_0x9132:
            ii(0x9132, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x9136, 2);    if(jge(0x9142, 0xa)) goto l_0x9142;       /* jge 0x9142 */
            ii(0x9138, 5);    mov(memw[ss, bp + 0x4], 0);               /* mov word [bp+0x4], 0x0 */
            ii(0x913d, 5);    and(memb[ds, 0x14], -0x9 /* 0xf7 */);     /* and byte [0x14], 0xf7 */
        l_0x9142:
            ii(0x9142, 4);    test(memb[ss, bp - 0x12], 0x2);           /* test byte [bp-0x12], 0x2 */
            ii(0x9146, 2);    if(jz(0x9152, 0xa)) goto l_0x9152;        /* jz 0x9152 */
            ii(0x9148, 5);    mov(memw[ss, bp + 0x4], 0xffff);          /* mov word [bp+0x4], 0xffff */
            ii(0x914d, 5);    or(memb[ds, 0x14], 0x8);                  /* or byte [0x14], 0x8 */
        l_0x9152:
            ii(0x9152, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x9156, 2);    if(jz(0x9199, 0x41)) goto l_0x9199;       /* jz 0x9199 */
            ii(0x9158, 3);    mov(ax, memw[ds, 0x11f2]);                /* mov ax, [0x11f2] */
            ii(0x915b, 2);    neg(ax);                                  /* neg ax */
            ii(0x915d, 3);    mov(memw[ss, bp - 0x44], ax);             /* mov [bp-0x44], ax */
            ii(0x9160, 4);    test(memb[ss, bp - 0x12], 0x1);           /* test byte [bp-0x12], 0x1 */
            ii(0x9164, 2);    if(jz(0x918a, 0x24)) goto l_0x918a;       /* jz 0x918a */
            ii(0x9166, 3);    mov(ax, memw[ss, bp - 0x3e]);             /* mov ax, [bp-0x3e] */
            ii(0x9169, 1);    inc(ax);                                  /* inc ax */
            ii(0x916a, 3);    shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x916d, 3);    mul(memw[ss, bp + 0x4]);                  /* mul word [bp+0x4] */
            ii(0x9170, 2);    neg(ax);                                  /* neg ax */
            ii(0x9172, 1);    push(ax);                                 /* push ax */
            ii(0x9173, 3);    call(0x997c, 0x806);                      /* call 0x997c */
            ii(0x9176, 1);    pop(bx);                                  /* pop bx */
            ii(0x9177, 3);    shl(ax, 0x3);                             /* shl ax, 0x3 */
            ii(0x917a, 3);    mov(memw[ds, 0x11f2], ax);                /* mov [0x11f2], ax */
            ii(0x917d, 3);    mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x9180, 3);    mov(memw[ds, bx + 0x8], ax);              /* mov [bx+0x8], ax */
            ii(0x9183, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9185, 2);    if(jnz(0x918a, 0x3)) goto l_0x918a;       /* jnz 0x918a */
            ii(0x9187, 3);    jmp(0x95c9, 0x43f); goto l_0x95c9;        /* jmp 0x95c9 */
        l_0x918a:
            ii(0x918a, 3);    mov(ax, memw[ds, 0x11f2]);                /* mov ax, [0x11f2] */
            ii(0x918d, 3);    add(memw[ss, bp - 0x44], ax);             /* add [bp-0x44], ax */
            ii(0x9190, 3);    mov(ax, memw[ss, bp - 0x44]);             /* mov ax, [bp-0x44] */
            ii(0x9193, 3);    add(memw[ss, bp - 0x2e], ax);             /* add [bp-0x2e], ax */
            ii(0x9196, 3);    add(memw[ss, bp - 0x26], ax);             /* add [bp-0x26], ax */
        l_0x9199:
            ii(0x9199, 3);    mov(ax, memw[ss, bp - 0x16]);             /* mov ax, [bp-0x16] */
            ii(0x919c, 4);    or(memw[ds, 0x14], ax);                   /* or [0x14], ax */
            ii(0x91a0, 3);    mov(ax, memw[ds, 0x11da]);                /* mov ax, [0x11da] */
            ii(0x91a3, 4);    mov(dx, memw[ds, 0x11dc]);                /* mov dx, [0x11dc] */
            ii(0x91a7, 3);    add(ax, 0x80);                            /* add ax, 0x80 */
            ii(0x91aa, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x91ad, 1);    push(dx);                                 /* push dx */
            ii(0x91ae, 1);    push(ax);                                 /* push ax */
            ii(0x91af, 3);    call(0xbd7a, 0x2bc8);                     /* call 0xbd7a */
            ii(0x91b2, 1);    pop(bx);                                  /* pop bx */
            ii(0x91b3, 1);    pop(bx);                                  /* pop bx */
            ii(0x91b4, 3);    call(0x773a, -0x1a7d);                    /* call 0x773a */
            ii(0x91b7, 3);    mov(ax, memw[ss, bp - 0x3e]);             /* mov ax, [bp-0x3e] */
            ii(0x91ba, 3);    sub(ax, 0x7f);                            /* sub ax, 0x7f */
            ii(0x91bd, 3);    mov(memw[ds, 0x11ee], ax);                /* mov [0x11ee], ax */
            ii(0x91c0, 1);    push(ax);                                 /* push ax */
            ii(0x91c1, 4);    push(memw[ds, 0x11f2]);                   /* push word [0x11f2] */
            ii(0x91c5, 2);    push(0x8);                                /* push 0x8 */
            ii(0x91c7, 3);    call(0x9839, 0x66f);                      /* call 0x9839 */
            ii(0x91ca, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x91cd, 3);    mov(ax, memw[ds, 0x11f2]);                /* mov ax, [0x11f2] */
            ii(0x91d0, 4);    add(memw[ds, 0x11ee], ax);                /* add [0x11ee], ax */
            ii(0x91d4, 5);    mov(memw[ss, bp - 0x6], 0);               /* mov word [bp-0x6], 0x0 */
            ii(0x91d9, 5);    mov(memw[ss, bp - 0x4], 0x8);             /* mov word [bp-0x4], 0x8 */
            ii(0x91de, 5);    mov(memw[ss, bp - 0x42], 0);              /* mov word [bp-0x42], 0x0 */
            ii(0x91e3, 5);    mov(memw[ss, bp - 0x40], 0x50);           /* mov word [bp-0x40], 0x50 */
            ii(0x91e8, 3);    mov(es, memw[ss, bp - 0x4]);              /* mov es, [bp-0x4] */
        l_0x91eb:
            ii(0x91eb, 5);    sub(memw[ds, 0x11ee], 0x8);               /* sub word [0x11ee], 0x8 */
            ii(0x91f0, 4);    mov(bx, memw[ds, 0x11ee]);                /* mov bx, [0x11ee] */
            ii(0x91f4, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x91f7, 3);    add(bx, memw[ss, bp - 0x6]);              /* add bx, [bp-0x6] */
            ii(0x91fa, 5);    cmp(memb[es, bx + 0x5], 0);               /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x91ff, 2);    if(jz(0x91eb, -0x16)) goto l_0x91eb;      /* jz 0x91eb */
            ii(0x9201, 3);    mov(ax, memw[ds, 0x11f2]);                /* mov ax, [0x11f2] */
            ii(0x9204, 3);    mov(memw[ss, bp - 0x18], ax);             /* mov [bp-0x18], ax */
        l_0x9207:
            ii(0x9207, 3);    mov(ax, memw[ss, bp - 0x18]);             /* mov ax, [bp-0x18] */
            ii(0x920a, 3);    mov(memw[ss, bp - 0x1c], ax);             /* mov [bp-0x1c], ax */
            ii(0x920d, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x920f, 3);    add(ax, memw[ss, bp - 0x6]);              /* add ax, [bp-0x6] */
            ii(0x9212, 3);    mov(dx, memw[ss, bp - 0x4]);              /* mov dx, [bp-0x4] */
            ii(0x9215, 3);    mov(bx, 0x11e4);                          /* mov bx, 0x11e4 */
            ii(0x9218, 1);    push(si);                                 /* push si */
            ii(0x9219, 1);    push(di);                                 /* push di */
            ii(0x921a, 1);    push(ds);                                 /* push ds */
            ii(0x921b, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0x921d, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0x921f, 1);    push(ds);                                 /* push ds */
            ii(0x9220, 1);    pop(es);                                  /* pop es */
            ii(0x9221, 2);    mov(ds, dx);                              /* mov ds, dx */
            ii(0x9223, 1);    movsw();                                  /* movsw */
            ii(0x9224, 1);    movsw();                                  /* movsw */
            ii(0x9225, 1);    movsw();                                  /* movsw */
            ii(0x9226, 1);    movsw();                                  /* movsw */
            ii(0x9227, 1);    pop(ds);                                  /* pop ds */
            ii(0x9228, 1);    pop(di);                                  /* pop di */
            ii(0x9229, 1);    pop(si);                                  /* pop si */
            ii(0x922a, 4);    mov(si, memw[ds, 0x11e4]);                /* mov si, [0x11e4] */
            ii(0x922e, 3);    mov(al, memb[ds, 0x11e9]);                /* mov al, [0x11e9] */
            ii(0x9231, 2);    sub(ah, ah);                              /* sub ah, ah */
            ii(0x9233, 3);    mov(memw[ss, bp - 0x2], ax);              /* mov [bp-0x2], ax */
            ii(0x9236, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9238, 2);    if(jnz(0x923d, 0x3)) goto l_0x923d;       /* jnz 0x923d */
            ii(0x923a, 3);    jmp(0x945f, 0x222); goto l_0x945f;        /* jmp 0x945f */
        l_0x923d:
            ii(0x923d, 3);    mov(ax, memw[ds, 0x11ea]);                /* mov ax, [0x11ea] */
            ii(0x9240, 3);    and(ah, 0x1f);                            /* and ah, 0x1f */
            ii(0x9243, 3);    mov(memw[ss, bp - 0x4a], ax);             /* mov [bp-0x4a], ax */
            ii(0x9246, 2);    sub(di, di);                              /* sub di, di */
            ii(0x9248, 2);    or(si, si);                               /* or si, si */
            ii(0x924a, 2);    if(jz(0x9253, 0x7)) goto l_0x9253;        /* jz 0x9253 */
            ii(0x924c, 1);    push(si);                                 /* push si */
            ii(0x924d, 3);    call(0x6f8d, -0x22c3);                    /* call 0x6f8d */
            ii(0x9250, 1);    pop(bx);                                  /* pop bx */
            ii(0x9251, 2);    mov(di, ax);                              /* mov di, ax */
        l_0x9253:
            ii(0x9253, 5);    test(memb[ds, 0x11eb], 0x20);             /* test byte [0x11eb], 0x20 */
            ii(0x9258, 2);    if(jz(0x925c, 0x2)) goto l_0x925c;        /* jz 0x925c */
            ii(0x925a, 2);    sub(si, si);                              /* sub si, si */
        l_0x925c:
            ii(0x925c, 3);    cmp(memw[ss, bp - 0x4a], di);             /* cmp [bp-0x4a], di */
            ii(0x925f, 2);    if(jbe(0x9264, 0x3)) goto l_0x9264;       /* jbe 0x9264 */
            ii(0x9261, 3);    mov(di, memw[ss, bp - 0x4a]);             /* mov di, [bp-0x4a] */
        l_0x9264:
            ii(0x9264, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x9266, 3);    mov(memw[ds, 0x1204], ax);                /* mov [0x1204], ax */
            ii(0x9269, 3);    mov(memw[ds, 0x1202], ax);                /* mov [0x1202], ax */
            ii(0x926c, 2);    or(di, di);                               /* or di, di */
            ii(0x926e, 2);    if(jnz(0x9273, 0x3)) goto l_0x9273;       /* jnz 0x9273 */
            ii(0x9270, 3);    jmp(0x9378, 0x105); goto l_0x9378;        /* jmp 0x9378 */
        l_0x9273:
            ii(0x9273, 5);    test(memb[ds, 0x11eb], 0x80);             /* test byte [0x11eb], 0x80 */
            ii(0x9278, 2);    if(jnz(0x927d, 0x3)) goto l_0x927d;       /* jnz 0x927d */
            ii(0x927a, 3);    jmp(0x935b, 0xde); goto l_0x935b;         /* jmp 0x935b */
        l_0x927d:
            ii(0x927d, 3);    mov(ax, memw[ss, bp - 0x2e]);             /* mov ax, [bp-0x2e] */
            ii(0x9280, 3);    cmp(memw[ss, bp - 0x18], ax);             /* cmp [bp-0x18], ax */
            ii(0x9283, 2);    if(jz(0x928e, 0x9)) goto l_0x928e;        /* jz 0x928e */
            ii(0x9285, 3);    mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x9288, 2);    and(al, 0x18);                            /* and al, 0x18 */
            ii(0x928a, 2);    cmp(al, 0x18);                            /* cmp al, 0x18 */
            ii(0x928c, 2);    if(jnz(0x9295, 0x7)) goto l_0x9295;       /* jnz 0x9295 */
        l_0x928e:
            ii(0x928e, 5);    mov(memw[ss, bp - 0x20], 0x7);            /* mov word [bp-0x20], 0x7 */
            ii(0x9293, 2);    jmp(0x929e, 0x9); goto l_0x929e;          /* jmp 0x929e */
        l_0x9295:
            ii(0x9295, 5);    mov(memw[ss, bp - 0x20], 0);              /* mov word [bp-0x20], 0x0 */
            ii(0x929a, 4);    or(memb[ss, bp - 0x2], 0x60);             /* or byte [bp-0x2], 0x60 */
        l_0x929e:
            ii(0x929e, 3);    call(0x6f71, -0x2330);                    /* call 0x6f71 */
            ii(0x92a1, 3);    mov(ax, memw[ss, bp - 0x20]);             /* mov ax, [bp-0x20] */
            ii(0x92a4, 2);    add(ax, di);                              /* add ax, di */
            ii(0x92a6, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x92a9, 3);    cmp(ax, 0x8);                             /* cmp ax, 0x8 */
            ii(0x92ac, 2);    if(jae(0x92b3, 0x5)) goto l_0x92b3;       /* jae 0x92b3 */
            ii(0x92ae, 5);    mov(memw[ss, bp - 0x1a], 0x8);            /* mov word [bp-0x1a], 0x8 */
        l_0x92b3:
            ii(0x92b3, 3);    push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x92b6, 3);    call(0x970c, 0x453);                      /* call 0x970c */
            ii(0x92b9, 1);    pop(bx);                                  /* pop bx */
            ii(0x92ba, 3);    mov(memw[ds, 0x1202], ax);                /* mov [0x1202], ax */
            ii(0x92bd, 4);    mov(memw[ds, 0x1204], dx);                /* mov [0x1204], dx */
            ii(0x92c1, 3);    mov(memw[ss, bp - 0x1a], ax);             /* mov [bp-0x1a], ax */
            ii(0x92c4, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x92c6, 2);    if(jnz(0x92ce, 0x6)) goto l_0x92ce;       /* jnz 0x92ce */
            ii(0x92c8, 2);    push(0x3);                                /* push 0x3 */
            ii(0x92ca, 3);    call(0x805d, -0x1270);                    /* call 0x805d */
            ii(0x92cd, 1);    pop(bx);                                  /* pop bx */
        l_0x92ce:
            ii(0x92ce, 3);    mov(ax, memw[ds, 0x1202]);                /* mov ax, [0x1202] */
            ii(0x92d1, 3);    add(ax, memw[ss, bp - 0x20]);             /* add ax, [bp-0x20] */
            ii(0x92d4, 3);    mov(cx, memw[ss, bp - 0x20]);             /* mov cx, [bp-0x20] */
            ii(0x92d7, 2);    not(cx);                                  /* not cx */
            ii(0x92d9, 2);    and(cx, ax);                              /* and cx, ax */
            ii(0x92db, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x92dd, 4);    mov(memw[ds, 0x1202], cx);                /* mov [0x1202], cx */
            ii(0x92e1, 3);    mov(memw[ds, 0x1204], ax);                /* mov [0x1204], ax */
            ii(0x92e4, 3);    mov(memw[ss, bp - 0x1c], cx);             /* mov [bp-0x1c], cx */
            ii(0x92e7, 4);    cmp(cx, memw[ds, 0x97c]);                 /* cmp cx, [0x97c] */
            ii(0x92eb, 2);    if(jb(0x92f3, 0x6)) goto l_0x92f3;        /* jb 0x92f3 */
        l_0x92ed:
            ii(0x92ed, 2);    push(0x4);                                /* push 0x4 */
            ii(0x92ef, 3);    call(0x805d, -0x1295);                    /* call 0x805d */
            ii(0x92f2, 1);    pop(bx);                                  /* pop bx */
        l_0x92f3:
            ii(0x92f3, 3);    push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x92f6, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x92f9, 3);    call(0xbd5c, 0x2a60);                     /* call 0xbd5c */
            ii(0x92fc, 1);    pop(bx);                                  /* pop bx */
            ii(0x92fd, 1);    pop(bx);                                  /* pop bx */
            ii(0x92fe, 3);    mov(cx, 0x1210);                          /* mov cx, 0x1210 */
            ii(0x9301, 3);    add(cx, 0x64);                            /* add cx, 0x64 */
            ii(0x9304, 2);    cmp(ax, cx);                              /* cmp ax, cx */
            ii(0x9306, 2);    if(jg(0x930e, 0x6)) goto l_0x930e;        /* jg 0x930e */
            ii(0x9308, 2);    push(0x5);                                /* push 0x5 */
            ii(0x930a, 3);    call(0xbdcd, 0x2ac0);                     /* call 0xbdcd */
            ii(0x930d, 1);    pop(bx);                                  /* pop bx */
        l_0x930e:
            ii(0x930e, 3);    call(0x773a, -0x1bd7);                    /* call 0x773a */
            ii(0x9311, 3);    mov(bx, memw[ss, bp - 0x1c]);             /* mov bx, [bp-0x1c] */
            ii(0x9314, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x9317, 3);    add(bx, memw[ss, bp - 0x6]);              /* add bx, [bp-0x6] */
            ii(0x931a, 3);    mov(es, memw[ss, bp - 0x4]);              /* mov es, [bp-0x4] */
            ii(0x931d, 5);    cmp(memb[es, bx + 0x5], 0);               /* cmp byte [es:bx+0x5], 0x0 */
            ii(0x9322, 2);    if(jz(0x9329, 0x5)) goto l_0x9329;        /* jz 0x9329 */
            ii(0x9324, 3);    call(0x6f71, -0x23b6);                    /* call 0x6f71 */
            ii(0x9327, 2);    jmp(0x92ed, -0x3c); goto l_0x92ed;        /* jmp 0x92ed */
        l_0x9329:
            ii(0x9329, 4);    cmp(memw[ss, bp - 0x20], 0);              /* cmp word [bp-0x20], 0x0 */
            ii(0x932d, 2);    if(jz(0x9356, 0x27)) goto l_0x9356;       /* jz 0x9356 */
            ii(0x932f, 3);    mov(ax, memw[ss, bp - 0x2e]);             /* mov ax, [bp-0x2e] */
            ii(0x9332, 3);    cmp(memw[ss, bp - 0x18], ax);             /* cmp [bp-0x18], ax */
            ii(0x9335, 2);    if(jnz(0x933d, 0x6)) goto l_0x933d;       /* jnz 0x933d */
            ii(0x9337, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x933a, 3);    mov(memw[ss, bp - 0x2e], ax);             /* mov [bp-0x2e], ax */
        l_0x933d:
            ii(0x933d, 3);    mov(ax, memw[ss, bp - 0x26]);             /* mov ax, [bp-0x26] */
            ii(0x9340, 3);    cmp(memw[ss, bp - 0x18], ax);             /* cmp [bp-0x18], ax */
            ii(0x9343, 2);    if(jnz(0x934b, 0x6)) goto l_0x934b;       /* jnz 0x934b */
            ii(0x9345, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x9348, 3);    mov(memw[ss, bp - 0x26], ax);             /* mov [bp-0x26], ax */
        l_0x934b:
            ii(0x934b, 3);    push(memw[ss, bp - 0x1a]);                /* push word [bp-0x1a] */
            ii(0x934e, 3);    push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x9351, 3);    call(0x7c31, -0x1723);                    /* call 0x7c31 */
            ii(0x9354, 1);    pop(bx);                                  /* pop bx */
            ii(0x9355, 1);    pop(bx);                                  /* pop bx */
        l_0x9356:
            ii(0x9356, 3);    inc(memw[ss, bp - 0x1e]);                 /* inc word [bp-0x1e] */
            ii(0x9359, 2);    jmp(0x9378, 0x1d); goto l_0x9378;         /* jmp 0x9378 */
        l_0x935b:
            ii(0x935b, 1);    push(di);                                 /* push di */
            ii(0x935c, 3);    call(0x96b1, 0x352);                      /* call 0x96b1 */
            ii(0x935f, 1);    pop(bx);                                  /* pop bx */
            ii(0x9360, 3);    mov(memw[ds, 0x1202], ax);                /* mov [0x1202], ax */
            ii(0x9363, 4);    mov(memw[ds, 0x1204], dx);                /* mov [0x1204], dx */
            ii(0x9367, 2);    mov(ax, dx);                              /* mov ax, dx */
            ii(0x9369, 4);    or(ax, memw[ds, 0x1202]);                 /* or ax, [0x1202] */
            ii(0x936d, 2);    if(jnz(0x9378, 0x9)) goto l_0x9378;       /* jnz 0x9378 */
            ii(0x936f, 3);    call(0x6f71, -0x2401);                    /* call 0x6f71 */
            ii(0x9372, 2);    push(0x6);                                /* push 0x6 */
            ii(0x9374, 3);    call(0x805d, -0x131a);                    /* call 0x805d */
            ii(0x9377, 1);    pop(bx);                                  /* pop bx */
        l_0x9378:
            ii(0x9378, 5);    mov(memb[ds, 0x11e9], 0xf2);              /* mov byte [0x11e9], 0xf2 */
            ii(0x937d, 6);    mov(memw[ds, 0x11e4], 0);                 /* mov word [0x11e4], 0x0 */
            ii(0x9383, 2);    or(di, di);                               /* or di, di */
            ii(0x9385, 2);    if(jz(0x93a0, 0x19)) goto l_0x93a0;       /* jz 0x93a0 */
            ii(0x9387, 2);    mov(ax, di);                              /* mov ax, di */
            ii(0x9389, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x938c, 1);    dec(ax);                                  /* dec ax */
            ii(0x938d, 3);    mov(memw[ds, 0x11e4], ax);                /* mov [0x11e4], ax */
            ii(0x9390, 3);    mov(bx, memw[ss, bp - 0x1c]);             /* mov bx, [bp-0x1c] */
            ii(0x9393, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x9396, 3);    add(bx, memw[ss, bp - 0x42]);             /* add bx, [bp-0x42] */
            ii(0x9399, 3);    mov(es, memw[ss, bp - 0x40]);             /* mov es, [bp-0x40] */
            ii(0x939c, 4);    mov(memb[es, bx], 0x1);                   /* mov byte [es:bx], 0x1 */
        l_0x93a0:
            ii(0x93a0, 5);    test(memb[ds, 0x11eb], 0x40);             /* test byte [0x11eb], 0x40 */
            ii(0x93a5, 2);    if(jz(0x93b7, 0x10)) goto l_0x93b7;       /* jz 0x93b7 */
            ii(0x93a7, 3);    mov(bx, memw[ss, bp - 0x1c]);             /* mov bx, [bp-0x1c] */
            ii(0x93aa, 3);    shr(bx, 0x3);                             /* shr bx, 0x3 */
            ii(0x93ad, 3);    add(bx, memw[ss, bp - 0x42]);             /* add bx, [bp-0x42] */
            ii(0x93b0, 3);    mov(es, memw[ss, bp - 0x40]);             /* mov es, [bp-0x40] */
            ii(0x93b3, 4);    or(memb[es, bx], 0x2);                    /* or byte [es:bx], 0x2 */
        l_0x93b7:
            ii(0x93b7, 3);    mov(ax, memw[ds, 0x1202]);                /* mov ax, [0x1202] */
            ii(0x93ba, 3);    shl(ax, 0x4);                             /* shl ax, 0x4 */
            ii(0x93bd, 3);    mov(memw[ds, 0x11e6], ax);                /* mov [0x11e6], ax */
            ii(0x93c0, 3);    mov(ax, memw[ds, 0x1202]);                /* mov ax, [0x1202] */
            ii(0x93c3, 4);    mov(dx, memw[ds, 0x1204]);                /* mov dx, [0x1204] */
            ii(0x93c7, 2);    mov(cl, 0xc);                             /* mov cl, 0xc */
            ii(0x93c9, 3);    call(0x8560, -0xe6c);                     /* call 0x8560 */
            ii(0x93cc, 3);    mov(memb[ds, 0x11e8], al);                /* mov [0x11e8], al */
            ii(0x93cf, 3);    mov(ax, memw[ds, 0x1204]);                /* mov ax, [0x1204] */
            ii(0x93d2, 3);    sar(ax, 0x4);                             /* sar ax, 0x4 */
            ii(0x93d5, 2);    mov(ah, al);                              /* mov ah, al */
            ii(0x93d7, 2);    sub(al, al);                              /* sub al, al */
            ii(0x93d9, 3);    mov(memw[ds, 0x11ea], ax);                /* mov [0x11ea], ax */
            ii(0x93dc, 3);    mov(ax, memw[ss, bp - 0x1c]);             /* mov ax, [bp-0x1c] */
            ii(0x93df, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x93e1, 3);    add(ax, memw[ss, bp - 0x6]);              /* add ax, [bp-0x6] */
            ii(0x93e4, 3);    mov(dx, memw[ss, bp - 0x4]);              /* mov dx, [bp-0x4] */
            ii(0x93e7, 1);    push(si);                                 /* push si */
            ii(0x93e8, 1);    push(di);                                 /* push di */
            ii(0x93e9, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x93eb, 3);    mov(si, 0x11e4);                          /* mov si, 0x11e4 */
            ii(0x93ee, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x93f0, 1);    movsw();                                  /* movsw */
            ii(0x93f1, 1);    movsw();                                  /* movsw */
            ii(0x93f2, 1);    movsw();                                  /* movsw */
            ii(0x93f3, 1);    movsw();                                  /* movsw */
            ii(0x93f4, 1);    pop(di);                                  /* pop di */
            ii(0x93f5, 1);    pop(si);                                  /* pop si */
            ii(0x93f6, 2);    or(si, si);                               /* or si, si */
            ii(0x93f8, 2);    if(jz(0x940d, 0x13)) goto l_0x940d;       /* jz 0x940d */
            ii(0x93fa, 4);    test(si, 0xf);                            /* test si, 0xf */
            ii(0x93fe, 2);    if(jz(0x9401, 0x1)) goto l_0x9401;        /* jz 0x9401 */
            ii(0x9400, 1);    inc(si);                                  /* inc si */
        l_0x9401:
            ii(0x9401, 1);    push(si);                                 /* push si */
            ii(0x9402, 2);    push(0);                                  /* push 0x0 */
            ii(0x9404, 3);    push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x9407, 3);    call(0x9839, 0x42f);                      /* call 0x9839 */
            ii(0x940a, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
        l_0x940d:
            ii(0x940d, 4);    cmp(memw[ss, bp - 0x4a], 0);              /* cmp word [bp-0x4a], 0x0 */
            ii(0x9411, 2);    if(jz(0x942a, 0x17)) goto l_0x942a;       /* jz 0x942a */
            ii(0x9413, 3);    mov(di, memw[ss, bp - 0x4a]);             /* mov di, [bp-0x4a] */
            ii(0x9416, 3);    shl(di, 0x4);                             /* shl di, 0x4 */
            ii(0x9419, 2);    sub(di, si);                              /* sub di, si */
            ii(0x941b, 2);    if(jz(0x942a, 0xd)) goto l_0x942a;        /* jz 0x942a */
            ii(0x941d, 2);    push(0);                                  /* push 0x0 */
            ii(0x941f, 1);    push(di);                                 /* push di */
            ii(0x9420, 1);    push(si);                                 /* push si */
            ii(0x9421, 3);    push(memw[ss, bp - 0x1c]);                /* push word [bp-0x1c] */
            ii(0x9424, 3);    call(0x7c27, -0x1800);                    /* call 0x7c27 */
            ii(0x9427, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
        l_0x942a:
            ii(0x942a, 3);    mov(al, memb[ss, bp - 0x2]);              /* mov al, [bp-0x2] */
            ii(0x942d, 3);    mov(memb[ds, 0x11e9], al);                /* mov [0x11e9], al */
            ii(0x9430, 3);    mov(bx, memw[ss, bp - 0x1c]);             /* mov bx, [bp-0x1c] */
            ii(0x9433, 3);    and(bl, 0xf8);                            /* and bl, 0xf8 */
            ii(0x9436, 3);    add(bx, memw[ss, bp - 0x6]);              /* add bx, [bp-0x6] */
            ii(0x9439, 3);    mov(es, memw[ss, bp - 0x4]);              /* mov es, [bp-0x4] */
            ii(0x943c, 4);    mov(memb[es, bx + 0x5], al);              /* mov [es:bx+0x5], al */
            ii(0x9440, 3);    mov(ax, memw[ss, bp - 0x18]);             /* mov ax, [bp-0x18] */
            ii(0x9443, 3);    cmp(memw[ss, bp - 0x1c], ax);             /* cmp [bp-0x1c], ax */
            ii(0x9446, 2);    if(jz(0x945f, 0x17)) goto l_0x945f;       /* jz 0x945f */
            ii(0x9448, 2);    and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x944a, 3);    add(ax, memw[ss, bp - 0x6]);              /* add ax, [bp-0x6] */
            ii(0x944d, 3);    mov(dx, memw[ss, bp - 0x4]);              /* mov dx, [bp-0x4] */
            ii(0x9450, 1);    push(si);                                 /* push si */
            ii(0x9451, 1);    push(di);                                 /* push di */
            ii(0x9452, 2);    mov(di, ax);                              /* mov di, ax */
            ii(0x9454, 3);    mov(si, 0x11e4);                          /* mov si, 0x11e4 */
            ii(0x9457, 2);    mov(es, dx);                              /* mov es, dx */
            ii(0x9459, 1);    movsw();                                  /* movsw */
            ii(0x945a, 1);    movsw();                                  /* movsw */
            ii(0x945b, 1);    movsw();                                  /* movsw */
            ii(0x945c, 1);    movsw();                                  /* movsw */
            ii(0x945d, 1);    pop(di);                                  /* pop di */
            ii(0x945e, 1);    pop(si);                                  /* pop si */
        l_0x945f:
            ii(0x945f, 3);    mov(ax, memw[ds, 0x11ee]);                /* mov ax, [0x11ee] */
            ii(0x9462, 4);    add(memw[ss, bp - 0x18], 0x8);            /* add word [bp-0x18], 0x8 */
            ii(0x9466, 3);    cmp(memw[ss, bp - 0x18], ax);             /* cmp [bp-0x18], ax */
            ii(0x9469, 2);    if(ja(0x946e, 0x3)) goto l_0x946e;        /* ja 0x946e */
            ii(0x946b, 3);    jmp(0x9207, -0x267); goto l_0x9207;       /* jmp 0x9207 */
        l_0x946e:
            ii(0x946e, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x9472, 2);    if(jg(0x947e, 0xa)) goto l_0x947e;        /* jg 0x947e */
            ii(0x9474, 3);    shr(ax, 0x3);                             /* shr ax, 0x3 */
            ii(0x9477, 3);    les(bx, ss, bp - 0x6);                    /* les bx, [bp-0x6] */
            ii(0x947a, 4);    mov(memw[es, bx + 0x2], ax);              /* mov [es:bx+0x2], ax */
        l_0x947e:
            ii(0x947e, 3);    mov(ax, memw[ss, bp - 0x2c]);             /* mov ax, [bp-0x2c] */
            ii(0x9481, 3);    sub(ax, 0xc);                             /* sub ax, 0xc */
            ii(0x9484, 2);    and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x9486, 3);    mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x9489, 3);    mov(memw[ds, bx + 0xe], ax);              /* mov [bx+0xe], ax */
            ii(0x948c, 3);    mov(ax, memw[ss, bp - 0x2e]);             /* mov ax, [bp-0x2e] */
            ii(0x948f, 3);    mov(memw[ds, bx + 0x2], ax);              /* mov [bx+0x2], ax */
            ii(0x9492, 3);    mov(ax, memw[ss, bp - 0x26]);             /* mov ax, [bp-0x26] */
            ii(0x9495, 3);    mov(memw[ds, bx + 0x22], ax);             /* mov [bx+0x22], ax */
            ii(0x9498, 3);    mov(ax, memw[ss, bp - 0x28]);             /* mov ax, [bp-0x28] */
            ii(0x949b, 3);    mov(memw[ds, bx + 0x1e], ax);             /* mov [bx+0x1e], ax */
            ii(0x949e, 3);    mov(ax, memw[ds, 0x11f2]);                /* mov ax, [0x11f2] */
            ii(0x94a1, 3);    mov(memw[ds, bx + 0xa], ax);              /* mov [bx+0xa], ax */
            ii(0x94a4, 3);    mov(ax, memw[ss, bp - 0x18]);             /* mov ax, [bp-0x18] */
            ii(0x94a7, 3);    sub(ax, 0x18);                            /* sub ax, 0x18 */
            ii(0x94aa, 3);    mov(memw[ds, bx + 0x8], ax);              /* mov [bx+0x8], ax */
            ii(0x94ad, 3);    call(0x6f71, -0x253f);                    /* call 0x6f71 */
            ii(0x94b0, 3);    push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x94b3, 3);    push(memw[ss, bp + 0x4]);                 /* push word [bp+0x4] */
            ii(0x94b6, 3);    call(0x8d54, -0x765);                     /* call 0x8d54 */
            ii(0x94b9, 1);    pop(bx);                                  /* pop bx */
            ii(0x94ba, 1);    pop(bx);                                  /* pop bx */
            ii(0x94bb, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x94bf, 2);    if(jl(0x94ce, 0xd)) goto l_0x94ce;        /* jl 0x94ce */
            ii(0x94c1, 3);    call(0xbda7, 0x28e3);                     /* call 0xbda7 */
            ii(0x94c4, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x94c6, 3);    mov(memw[ds, 0x11dc], ax);                /* mov [0x11dc], ax */
            ii(0x94c9, 3);    mov(memw[ds, 0x11da], ax);                /* mov [0x11da], ax */
            ii(0x94cc, 2);    jmp(0x94dc, 0xe); goto l_0x94dc;          /* jmp 0x94dc */
        l_0x94ce:
            ii(0x94ce, 3);    mov(ax, memw[ds, 0x11f4]);                /* mov ax, [0x11f4] */
            ii(0x94d1, 4);    mov(dx, memw[ds, 0x11f6]);                /* mov dx, [0x11f6] */
            ii(0x94d5, 3);    mov(memw[ds, 0x11da], ax);                /* mov [0x11da], ax */
            ii(0x94d8, 4);    mov(memw[ds, 0x11dc], dx);                /* mov [0x11dc], dx */
        l_0x94dc:
            ii(0x94dc, 4);    sub(memw[ss, bp - 0x18], 0x8);            /* sub word [bp-0x18], 0x8 */
            ii(0x94e0, 4);    cmp(memw[ss, bp - 0x2a], 0);              /* cmp word [bp-0x2a], 0x0 */
            ii(0x94e4, 2);    if(jz(0x9537, 0x51)) goto l_0x9537;       /* jz 0x9537 */
            ii(0x94e6, 3);    call(0x773a, -0x1daf);                    /* call 0x773a */
            ii(0x94e9, 2);    push(0x1);                                /* push 0x1 */
            ii(0x94eb, 3);    call(0x7016, -0x24d8);                    /* call 0x7016 */
            ii(0x94ee, 1);    pop(bx);                                  /* pop bx */
            ii(0x94ef, 4);    cmp(memw[ss, bp - 0x44], 0);              /* cmp word [bp-0x44], 0x0 */
            ii(0x94f3, 2);    if(jz(0x951a, 0x25)) goto l_0x951a;       /* jz 0x951a */
            ii(0x94f5, 3);    push(memw[ss, bp - 0x44]);                /* push word [bp-0x44] */
            ii(0x94f8, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x94fb, 3);    mov(ax, memw[ss, bp - 0x44]);             /* mov ax, [bp-0x44] */
            ii(0x94fe, 3);    add(memw[ss, bp - 0x2a], ax);             /* add [bp-0x2a], ax */
            ii(0x9501, 3);    push(memw[ss, bp - 0x2a]);                /* push word [bp-0x2a] */
            ii(0x9504, 3);    call(0x9b30, 0x629);                      /* call 0x9b30 */
            ii(0x9507, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x950a, 2);    jmp(0x951a, 0xe); goto l_0x951a;          /* jmp 0x951a */
        l_0x950c:
            ii(0x950c, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x950f, 3);    push(memw[ss, bp - 0x2a]);                /* push word [bp-0x2a] */
            ii(0x9512, 3);    call(0x9bc9, 0x6b4);                      /* call 0x9bc9 */
            ii(0x9515, 1);    pop(bx);                                  /* pop bx */
            ii(0x9516, 1);    pop(bx);                                  /* pop bx */
            ii(0x9517, 3);    call(0xbd63, 0x2849);                     /* call 0xbd63 */
        l_0x951a:
            ii(0x951a, 3);    dec(memw[ss, bp - 0x1e]);                 /* dec word [bp-0x1e] */
            ii(0x951d, 2);    if(jns(0x950c, -0x13)) goto l_0x950c;     /* jns 0x950c */
            ii(0x951f, 3);    push(memw[ss, bp - 0x2a]);                /* push word [bp-0x2a] */
            ii(0x9522, 3);    call(0x7836, -0x1cef);                    /* call 0x7836 */
            ii(0x9525, 1);    pop(bx);                                  /* pop bx */
            ii(0x9526, 3);    mov(ax, memw[ss, bp - 0x2a]);             /* mov ax, [bp-0x2a] */
            ii(0x9529, 3);    sub(ax, 0x8);                             /* sub ax, 0x8 */
            ii(0x952c, 3);    mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x952f, 3);    mov(memw[ds, bx + 0x8], ax);              /* mov [bx+0x8], ax */
            ii(0x9532, 3);    call(0x6f71, -0x25c4);                    /* call 0x6f71 */
            ii(0x9535, 2);    jmp(0x957c, 0x45); goto l_0x957c;         /* jmp 0x957c */
        l_0x9537:
            ii(0x9537, 4);    cmp(memw[ss, bp - 0x44], 0);              /* cmp word [bp-0x44], 0x0 */
            ii(0x953b, 2);    if(jz(0x9548, 0xb)) goto l_0x9548;        /* jz 0x9548 */
            ii(0x953d, 3);    push(memw[ss, bp - 0x44]);                /* push word [bp-0x44] */
            ii(0x9540, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x9543, 3);    call(0x98d1, 0x38b);                      /* call 0x98d1 */
            ii(0x9546, 1);    pop(bx);                                  /* pop bx */
            ii(0x9547, 1);    pop(bx);                                  /* pop bx */
        l_0x9548:
            ii(0x9548, 4);    cmp(memw[ss, bp - 0x1e], 0);              /* cmp word [bp-0x1e], 0x0 */
            ii(0x954c, 2);    if(jle(0x957c, 0x2e)) goto l_0x957c;      /* jle 0x957c */
            ii(0x954e, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x9551, 3);    call(0x79ef, -0x1b65);                    /* call 0x79ef */
            ii(0x9554, 1);    pop(bx);                                  /* pop bx */
            ii(0x9555, 3);    mov(al, memb[ds, 0x11e9]);                /* mov al, [0x11e9] */
            ii(0x9558, 2);    and(al, 0x18);                            /* and al, 0x18 */
            ii(0x955a, 2);    cmp(al, 0x10);                            /* cmp al, 0x10 */
            ii(0x955c, 2);    if(jz(0x9564, 0x6)) goto l_0x9564;        /* jz 0x9564 */
            ii(0x955e, 2);    push(0x7);                                /* push 0x7 */
            ii(0x9560, 3);    call(0x805d, -0x1506);                    /* call 0x805d */
            ii(0x9563, 1);    pop(bx);                                  /* pop bx */
        l_0x9564:
            ii(0x9564, 5);    cmp(memw[ds, 0x11e4], 0);                 /* cmp word [0x11e4], 0x0 */
            ii(0x9569, 2);    if(jz(0x957c, 0x11)) goto l_0x957c;       /* jz 0x957c */
            ii(0x956b, 2);    jmp(0x9577, 0xa); goto l_0x9577;          /* jmp 0x9577 */
        l_0x956d:
            ii(0x956d, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x9570, 3);    call(0x9a4d, 0x4da);                      /* call 0x9a4d */
            ii(0x9573, 1);    pop(bx);                                  /* pop bx */
            ii(0x9574, 3);    call(0xbd63, 0x27ec);                     /* call 0xbd63 */
        l_0x9577:
            ii(0x9577, 3);    dec(memw[ss, bp - 0x1e]);                 /* dec word [bp-0x1e] */
            ii(0x957a, 2);    if(jns(0x956d, -0xf)) goto l_0x956d;      /* jns 0x956d */
        l_0x957c:
            ii(0x957c, 4);    cmp(memw[ss, bp - 0x1e], 0);              /* cmp word [bp-0x1e], 0x0 */
            ii(0x9580, 2);    if(jl(0x9588, 0x6)) goto l_0x9588;        /* jl 0x9588 */
            ii(0x9582, 4);    test(memb[ss, bp - 0x12], 0x1);           /* test byte [bp-0x12], 0x1 */
            ii(0x9586, 2);    if(jz(0x9595, 0xd)) goto l_0x9595;        /* jz 0x9595 */
        l_0x9588:
            ii(0x9588, 4);    cmp(memw[ss, bp - 0x2a], 0);              /* cmp word [bp-0x2a], 0x0 */
            ii(0x958c, 2);    if(jnz(0x9595, 0x7)) goto l_0x9595;       /* jnz 0x9595 */
            ii(0x958e, 3);    push(memw[ss, bp - 0x18]);                /* push word [bp-0x18] */
            ii(0x9591, 3);    call(0x9b12, 0x57e);                      /* call 0x9b12 */
            ii(0x9594, 1);    pop(bx);                                  /* pop bx */
        l_0x9595:
            ii(0x9595, 3);    mov(ax, 0x28);                            /* mov ax, 0x28 */
            ii(0x9598, 3);    mov(bx, memw[ss, bp + 0x6]);              /* mov bx, [bp+0x6] */
            ii(0x959b, 3);    mov(memw[ds, bx + 0x4], ax);              /* mov [bx+0x4], ax */
            ii(0x959e, 3);    mov(memw[ds, bx + 0x6], ax);              /* mov [bx+0x6], ax */
            ii(0x95a1, 5);    mov(memw[ds, bx + 0x26], 0x200);          /* mov word [bx+0x26], 0x200 */
            ii(0x95a6, 4);    cmp(memw[ss, bp + 0x4], 0);               /* cmp word [bp+0x4], 0x0 */
            ii(0x95aa, 2);    if(jg(0x95c9, 0x1d)) goto l_0x95c9;       /* jg 0x95c9 */
            ii(0x95ac, 3);    call(0x8d77, -0x838);                     /* call 0x8d77 */
            ii(0x95af, 3);    mov(ax, memw[ds, 0xcec]);                 /* mov ax, [0xcec] */
            ii(0x95b2, 3);    mov(memw[ds, 0x97e], ax);                 /* mov [0x97e], ax */
            ii(0x95b5, 3);    mov(cx, 0x2c);                            /* mov cx, 0x2c */
            ii(0x95b8, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0x95ba, 3);    mov(memw[ss, bp - 0x48], cx);             /* mov [bp-0x48], cx */
            ii(0x95bd, 3);    mov(memw[ss, bp - 0x46], dx);             /* mov [bp-0x46], dx */
            ii(0x95c0, 2);    mov(es, ax);                              /* mov es, ax */
            ii(0x95c2, 2);    mov(bx, cx);                              /* mov bx, cx */
            ii(0x95c4, 5);    mov(memw[es, bx], 0x30);                  /* mov word [es:bx], 0x30 */
        l_0x95c9:
            ii(0x95c9, 1);    pop(si);                                  /* pop si */
            ii(0x95ca, 1);    pop(di);                                  /* pop di */
            ii(0x95cb, 1);    leave();                                  /* leave */
            ii(0x95cc, 1);    ret();                                    /* ret */
        }
    }
}
