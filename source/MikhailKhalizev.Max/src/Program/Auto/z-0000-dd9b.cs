using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("26d06d56-a8be-42b7-978d-71b450c0c7ea")]
        public void Method_0000_dd9b()
        {
            ii(0xdd9b, 4);    enterw(0x16, 0);                          /* enter 0x16, 0x0 */
        l_0xdd9f:
            ii(0xdd9f, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xdda1, 3);    mov(memw_a16[ds, 0x11fc], ax);            /* mov [0x11fc], ax */
            ii(0xdda4, 3);    mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0xdda7, 3);    mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
        l_0xddaa:
            ii(0xddaa, 1);    cli();                                    /* cli */
            ii(0xddab, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xddae, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xddb2, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xddb5, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xddb8, 4);    cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0xddbc, 2);    if(jaw(0xddd4, 0x16)) goto l_0xddd4;      /* ja 0xddd4 */
            ii(0xddbe, 2);    if(jbw(0xddc6, 0x6)) goto l_0xddc6;       /* jb 0xddc6 */
            ii(0xddc0, 4);    cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0xddc4, 2);    if(jaew(0xddd4, 0xe)) goto l_0xddd4;      /* jae 0xddd4 */
        l_0xddc6:
            ii(0xddc6, 4);    cmp(memw_a16[ss, bp + 0x6], 0);           /* cmp word [bp+0x6], 0x0 */
            ii(0xddca, 2);    if(jgw(0xddd9, 0xd)) goto l_0xddd9;       /* jg 0xddd9 */
            ii(0xddcc, 2);    if(jlw(0xddd4, 0x6)) goto l_0xddd4;       /* jl 0xddd4 */
            ii(0xddce, 4);    cmp(memw_a16[ss, bp + 0x4], 0);           /* cmp word [bp+0x4], 0x0 */
            ii(0xddd2, 2);    if(jnzw(0xddd9, 0x5)) goto l_0xddd9;      /* jnz 0xddd9 */
        l_0xddd4:
            ii(0xddd4, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xddd6, 1);    cwd();                                    /* cwd */
            ii(0xddd7, 1);    leavew();                                 /* leave */
            ii(0xddd8, 1);    retw(); return;                           /* ret */
        l_0xddd9:
            ii(0xddd9, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xdddb, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xddde, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xdde1, 3);    callw(0xfb11, 0x1d2d);                    /* call 0xfb11 */
            ii(0xdde4, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xdde7, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xddea, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
        l_0xdded:
            ii(0xdded, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xddf0, 3);    or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0xddf3, 2);    if(jnzw(0xddf8, 0x3)) goto l_0xddf8;      /* jnz 0xddf8 */
            ii(0xddf5, 3);    jmpw(0xdf55, 0x15d); goto l_0xdf55;       /* jmp 0xdf55 */
        l_0xddf8:
            ii(0xddf8, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xddfa, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xddfd, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xde00, 3);    callw(0xfb11, 0x1d0e);                    /* call 0xfb11 */
            ii(0xde03, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xde06, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0xde09, 3);    mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0xde0c, 3);    cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0xde0f, 2);    if(jgew(0xde14, 0x3)) goto l_0xde14;      /* jge 0xde14 */
            ii(0xde11, 3);    jmpw(0xdef2, 0xde); goto l_0xdef2;        /* jmp 0xdef2 */
        l_0xde14:
            ii(0xde14, 2);    if(jgw(0xde1e, 0x8)) goto l_0xde1e;       /* jg 0xde1e */
            ii(0xde16, 3);    cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0xde19, 2);    if(jaew(0xde1e, 0x3)) goto l_0xde1e;      /* jae 0xde1e */
            ii(0xde1b, 3);    jmpw(0xdef2, 0xd4); goto l_0xdef2;        /* jmp 0xdef2 */
        l_0xde1e:
            ii(0xde1e, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0xde23, 2);    if(jnzw(0xde58, 0x33)) goto l_0xde58;     /* jnz 0xde58 */
            ii(0xde25, 3);    callw(0x1_135c, 0x3534);                  /* call 0x135c */
            ii(0xde28, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xde2a, 2);    if(jnzw(0xde58, 0x2c)) goto l_0xde58;     /* jnz 0xde58 */
            ii(0xde2c, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xde2f, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xde32, 3);    add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0xde35, 3);    adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0xde38, 1);    pushw(dx);                                /* push dx */
            ii(0xde39, 1);    pushw(ax);                                /* push ax */
            ii(0xde3a, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xde3d, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xde40, 3);    callw(0x1_1298, 0x3455);                  /* call 0x1298 */
            ii(0xde43, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0xde46, 3);    mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0xde49, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xde4b, 2);    if(jlew(0xde51, 0x4)) goto l_0xde51;      /* jle 0xde51 */
            ii(0xde4d, 1);    sti();                                    /* sti */
            ii(0xde4e, 3);    jmpw(0xdd9f, -0xb2); goto l_0xdd9f;       /* jmp 0xdd9f */
        l_0xde51:
            ii(0xde51, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xde53, 2);    if(jgew(0xde58, 0x3)) goto l_0xde58;      /* jge 0xde58 */
            ii(0xde55, 3);    jmpw(0xdf55, 0xfd); goto l_0xdf55;        /* jmp 0xdf55 */
        l_0xde58:
            ii(0xde58, 3);    mov(ax, memw_a16[ss, bp - 0x12]);         /* mov ax, [bp-0x12] */
            ii(0xde5b, 3);    mov(dx, memw_a16[ss, bp - 0x10]);         /* mov dx, [bp-0x10] */
            ii(0xde5e, 3);    cmp(memw_a16[ss, bp + 0x4], ax);          /* cmp [bp+0x4], ax */
            ii(0xde61, 2);    if(jnzw(0xde68, 0x5)) goto l_0xde68;      /* jnz 0xde68 */
            ii(0xde63, 3);    cmp(memw_a16[ss, bp + 0x6], dx);          /* cmp [bp+0x6], dx */
            ii(0xde66, 2);    if(jzw(0xde9c, 0x34)) goto l_0xde9c;      /* jz 0xde9c */
        l_0xde68:
            ii(0xde68, 3);    sub(ax, memw_a16[ss, bp + 0x4]);          /* sub ax, [bp+0x4] */
            ii(0xde6b, 3);    sbb(dx, memw_a16[ss, bp + 0x6]);          /* sbb dx, [bp+0x6] */
            ii(0xde6e, 1);    pushw(dx);                                /* push dx */
            ii(0xde6f, 1);    pushw(ax);                                /* push ax */
            ii(0xde70, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xde72, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xde75, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xde78, 3);    add(ax, memw_a16[ss, bp - 0x4]);          /* add ax, [bp-0x4] */
            ii(0xde7b, 3);    adc(dx, memw_a16[ss, bp - 0x2]);          /* adc dx, [bp-0x2] */
            ii(0xde7e, 1);    pushw(dx);                                /* push dx */
            ii(0xde7f, 1);    pushw(ax);                                /* push ax */
            ii(0xde80, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xde82, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xde85, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xde88, 3);    callw(0xfb27, 0x1c9c);                    /* call 0xfb27 */
            ii(0xde8b, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xde8e, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xde91, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xde94, 1);    pushw(dx);                                /* push dx */
            ii(0xde95, 1);    pushw(ax);                                /* push ax */
            ii(0xde96, 3);    callw(0xfb27, 0x1c8e);                    /* call 0xfb27 */
            ii(0xde99, 3);    add(sp, 0xa);                             /* add sp, 0xa */
        l_0xde9c:
            ii(0xde9c, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xde9e, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xdea1, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xdea4, 3);    callw(0xfb11, 0x1c6a);                    /* call 0xfb11 */
            ii(0xdea7, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xdeaa, 1);    pushw(dx);                                /* push dx */
            ii(0xdeab, 1);    pushw(ax);                                /* push ax */
            ii(0xdeac, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xdeae, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xdeb1, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xdeb4, 3);    callw(0xfb27, 0x1c70);                    /* call 0xfb27 */
            ii(0xdeb7, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xdeba, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xdebd, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xdec0, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xdec2, 2);    if(jzw(0xded5, 0x11)) goto l_0xded5;      /* jz 0xded5 */
            ii(0xdec4, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xdec7, 1);    pushw(ax);                                /* push ax */
            ii(0xdec8, 3);    callw(0xdc8e, -0x23d);                    /* call 0xdc8e */
            ii(0xdecb, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xdecd, 2);    if(jnzw(0xded5, 0x6)) goto l_0xded5;      /* jnz 0xded5 */
            ii(0xdecf, 2);    pushw(0x1d);                              /* push 0x1d */
            ii(0xded1, 3);    callw(0xf985, 0x1ab1);                    /* call 0xf985 */
            ii(0xded4, 1);    popw(bx);                                 /* pop bx */
        l_0xded5:
            ii(0xded5, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xded8, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xdedb, 2);    neg(ax);                                  /* neg ax */
            ii(0xdedd, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xdee0, 2);    neg(dx);                                  /* neg dx */
            ii(0xdee2, 1);    pushw(dx);                                /* push dx */
            ii(0xdee3, 1);    pushw(ax);                                /* push ax */
            ii(0xdee4, 3);    callw(0xdd62, -0x185);                    /* call 0xdd62 */
            ii(0xdee7, 1);    popw(bx);                                 /* pop bx */
            ii(0xdee8, 1);    popw(bx);                                 /* pop bx */
            ii(0xdee9, 1);    sti();                                    /* sti */
            ii(0xdeea, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xdeed, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0xdef0, 1);    leavew();                                 /* leave */
            ii(0xdef1, 1);    retw(); return;                           /* ret */
        l_0xdef2:
            ii(0xdef2, 4);    cmp(memw_a16[ds, 0x11fc], dx);            /* cmp [0x11fc], dx */
            ii(0xdef6, 2);    if(jaw(0xdf07, 0xf)) goto l_0xdf07;       /* ja 0xdf07 */
            ii(0xdef8, 2);    if(jbw(0xdf00, 0x6)) goto l_0xdf00;       /* jb 0xdf00 */
            ii(0xdefa, 4);    cmp(memw_a16[ds, 0x11fa], ax);            /* cmp [0x11fa], ax */
            ii(0xdefe, 2);    if(jaew(0xdf07, 0x7)) goto l_0xdf07;      /* jae 0xdf07 */
        l_0xdf00:
            ii(0xdf00, 3);    mov(memw_a16[ds, 0x11fa], ax);            /* mov [0x11fa], ax */
            ii(0xdf03, 4);    mov(memw_a16[ds, 0x11fc], dx);            /* mov [0x11fc], dx */
        l_0xdf07:
            ii(0xdf07, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xdf09, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xdf0c, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0xdf0f, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xdf12, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xdf15, 1);    pushw(dx);                                /* push dx */
            ii(0xdf16, 1);    pushw(ax);                                /* push ax */
            ii(0xdf17, 3);    callw(0xfb11, 0x1bf7);                    /* call 0xfb11 */
            ii(0xdf1a, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xdf1d, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xdf20, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0xdf23, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xdf25, 2);    if(jnzw(0xdf2a, 0x3)) goto l_0xdf2a;      /* jnz 0xdf2a */
            ii(0xdf27, 3);    jmpw(0xdded, -0x13d); goto l_0xdded;      /* jmp 0xdded */
        l_0xdf2a:
            ii(0xdf2a, 3);    mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0xdf2d, 3);    mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0xdf30, 3);    cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0xdf33, 2);    if(jbw(0xdf4c, 0x17)) goto l_0xdf4c;      /* jb 0xdf4c */
            ii(0xdf35, 2);    if(jaw(0xdf3c, 0x5)) goto l_0xdf3c;       /* ja 0xdf3c */
            ii(0xdf37, 3);    cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0xdf3a, 2);    if(jbw(0xdf4c, 0x10)) goto l_0xdf4c;      /* jb 0xdf4c */
        l_0xdf3c:
            ii(0xdf3c, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xdf3f, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xdf42, 3);    callw(0xdc8e, -0x2b7);                    /* call 0xdc8e */
            ii(0xdf45, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xdf47, 2);    if(jzw(0xdf4c, 0x3)) goto l_0xdf4c;       /* jz 0xdf4c */
            ii(0xdf49, 3);    jmpw(0xdded, -0x15f); goto l_0xdded;      /* jmp 0xdded */
        l_0xdf4c:
            ii(0xdf4c, 2);    pushw(0x1d);                              /* push 0x1d */
            ii(0xdf4e, 3);    callw(0xf985, 0x1a34);                    /* call 0xf985 */
            ii(0xdf51, 1);    popw(bx);                                 /* pop bx */
            ii(0xdf52, 3);    jmpw(0xdded, -0x168); goto l_0xdded;      /* jmp 0xdded */
        l_0xdf55:
            ii(0xdf55, 1);    sti();                                    /* sti */
            ii(0xdf56, 5);    cmp(memw_a16[ds, 0x1206], 0);             /* cmp word [0x1206], 0x0 */
            ii(0xdf5b, 2);    if(jnzw(0xdf60, 0x3)) goto l_0xdf60;      /* jnz 0xdf60 */
            ii(0xdf5d, 3);    jmpw(0xddd4, -0x18c); goto l_0xddd4;      /* jmp 0xddd4 */
        l_0xdf60:
            ii(0xdf60, 3);    mov(ax, memw_a16[ss, bp - 0x14]);         /* mov ax, [bp-0x14] */
            ii(0xdf63, 3);    inc(memw_a16[ss, bp - 0x14]);             /* inc word [bp-0x14] */
            ii(0xdf66, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xdf68, 2);    if(jzw(0xdf6d, 0x3)) goto l_0xdf6d;       /* jz 0xdf6d */
            ii(0xdf6a, 3);    jmpw(0xddd4, -0x199); goto l_0xddd4;      /* jmp 0xddd4 */
        l_0xdf6d:
            ii(0xdf6d, 3);    mov(ax, memw_a16[ds, 0x1206]);            /* mov ax, [0x1206] */
            ii(0xdf70, 3);    shr(ax, 0x6);                             /* shr ax, 0x6 */
            ii(0xdf73, 2);    mov(dx, ax);                              /* mov dx, ax */
            ii(0xdf75, 3);    mov(ax, memw_a16[ds, 0x1206]);            /* mov ax, [0x1206] */
            ii(0xdf78, 3);    shl(ax, 0xa);                             /* shl ax, 0xa */
            ii(0xdf7b, 2);    mov(bx, dx);                              /* mov bx, dx */
            ii(0xdf7d, 1);    cwd();                                    /* cwd */
            ii(0xdf7e, 2);    or(dx, bx);                               /* or dx, bx */
            ii(0xdf80, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0xdf83, 3);    mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
            ii(0xdf86, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xdf89, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xdf8c, 3);    callw(0xfb97, 0x1c08);                    /* call 0xfb97 */
            ii(0xdf8f, 1);    popw(bx);                                 /* pop bx */
            ii(0xdf90, 1);    popw(bx);                                 /* pop bx */
            ii(0xdf91, 3);    cmp(dx, memw_a16[ss, bp - 0x10]);         /* cmp dx, [bp-0x10] */
            ii(0xdf94, 2);    if(jlw(0xdfa3, 0xd)) goto l_0xdfa3;       /* jl 0xdfa3 */
            ii(0xdf96, 2);    if(jgw(0xdf9d, 0x5)) goto l_0xdf9d;       /* jg 0xdf9d */
            ii(0xdf98, 3);    cmp(ax, memw_a16[ss, bp - 0x12]);         /* cmp ax, [bp-0x12] */
            ii(0xdf9b, 2);    if(jbew(0xdfa3, 0x6)) goto l_0xdfa3;      /* jbe 0xdfa3 */
        l_0xdf9d:
            ii(0xdf9d, 3);    mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0xdfa0, 3);    mov(memw_a16[ss, bp - 0x10], dx);         /* mov [bp-0x10], dx */
        l_0xdfa3:
            ii(0xdfa3, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0xdfa5, 3);    mov(ax, memw_a16[ds, 0xaa8]);             /* mov ax, [0xaa8] */
            ii(0xdfa8, 4);    mov(dx, memw_a16[ds, 0xaaa]);             /* mov dx, [0xaaa] */
            ii(0xdfac, 3);    add(ax, memw_a16[ss, bp - 0x12]);         /* add ax, [bp-0x12] */
            ii(0xdfaf, 3);    adc(dx, memw_a16[ss, bp - 0x10]);         /* adc dx, [bp-0x10] */
            ii(0xdfb2, 1);    pushw(dx);                                /* push dx */
            ii(0xdfb3, 1);    pushw(ax);                                /* push ax */
            ii(0xdfb4, 3);    callw(0xf632, 0x167b);                    /* call 0xf632 */
            ii(0xdfb7, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xdfba, 2);    or(dx, ax);                               /* or dx, ax */
            ii(0xdfbc, 2);    if(jzw(0xdfc1, 0x3)) goto l_0xdfc1;       /* jz 0xdfc1 */
            ii(0xdfbe, 3);    jmpw(0xddaa, -0x217); goto l_0xddaa;      /* jmp 0xddaa */
        l_0xdfc1:
            ii(0xdfc1, 3);    jmpw(0xddd4, -0x1f0); goto l_0xddd4;      /* jmp 0xddd4 */
        }
    }
}
