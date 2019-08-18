using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xdfd0-2116cdf0")]
        public void Method_0000_dfd0()
        {
            ii(0xdfd0, 4);    enterw(0xc, 0);                           /* enter 0xc, 0x0 */
            ii(0xdfd4, 1);    pushw(di);                                /* push di */
            ii(0xdfd5, 1);    pushw(si);                                /* push si */
            ii(0xdfd6, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xdfd9, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xdfdc, 4);    cmp(memw_a16[ds, 0x9a], dx);              /* cmp [0x9a], dx */
            ii(0xdfe0, 2);    if(jbew(0xdfe5, 0x3)) goto l_0xdfe5;      /* jbe 0xdfe5 */
            ii(0xdfe2, 3);    jmpw(0xe258, 0x273); goto l_0xe258;       /* jmp 0xe258 */
        l_0xdfe5:
            ii(0xdfe5, 2);    if(jbw(0xdfed, 0x6)) goto l_0xdfed;       /* jb 0xdfed */
            ii(0xdfe7, 4);    cmp(memw_a16[ds, 0x98], ax);              /* cmp [0x98], ax */
            ii(0xdfeb, 2);    if(jaw(0xdff9, 0xc)) goto l_0xdff9;       /* ja 0xdff9 */
        l_0xdfed:
            ii(0xdfed, 3);    add(ax, memw_a16[ss, bp + 0x8]);          /* add ax, [bp+0x8] */
            ii(0xdff0, 3);    adc(dx, memw_a16[ss, bp + 0xa]);          /* adc dx, [bp+0xa] */
            ii(0xdff3, 4);    cmp(dx, memw_a16[ds, 0x9e]);              /* cmp dx, [0x9e] */
            ii(0xdff7, 2);    if(jbew(0xdffc, 0x3)) goto l_0xdffc;      /* jbe 0xdffc */
        l_0xdff9:
            ii(0xdff9, 3);    jmpw(0xe258, 0x25c); goto l_0xe258;       /* jmp 0xe258 */
        l_0xdffc:
            ii(0xdffc, 2);    if(jbw(0xe004, 0x6)) goto l_0xe004;       /* jb 0xe004 */
            ii(0xdffe, 4);    cmp(ax, memw_a16[ds, 0x9c]);              /* cmp ax, [0x9c] */
            ii(0xe002, 2);    if(jaw(0xe00c, 0x8)) goto l_0xe00c;       /* ja 0xe00c */
        l_0xe004:
            ii(0xe004, 3);    mov(ax, memw_a16[ss, bp + 0xa]);          /* mov ax, [bp+0xa] */
            ii(0xe007, 3);    or(ax, memw_a16[ss, bp + 0x8]);           /* or ax, [bp+0x8] */
            ii(0xe00a, 2);    if(jnzw(0xe00f, 0x3)) goto l_0xe00f;      /* jnz 0xe00f */
        l_0xe00c:
            ii(0xe00c, 3);    jmpw(0xe258, 0x249); goto l_0xe258;       /* jmp 0xe258 */
        l_0xe00f:
            ii(0xe00f, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0xe014, 2);    if(jzw(0xe01c, 0x6)) goto l_0xe01c;       /* jz 0xe01c */
            ii(0xe016, 3);    pushw(0x111c);                            /* push 0x111c */
            ii(0xe019, 3);    callw(0xdfc4, -0x58);                     /* call 0xdfc4 */
        l_0xe01c:
            ii(0xe01c, 1);    cli();                                    /* cli */
            ii(0xe01d, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe01f, 3);    mov(ax, memw_a16[ds, 0x98]);              /* mov ax, [0x98] */
            ii(0xe022, 4);    mov(dx, memw_a16[ds, 0x9a]);              /* mov dx, [0x9a] */
            ii(0xe026, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xe029, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
        l_0xe02c:
            ii(0xe02c, 1);    pushw(dx);                                /* push dx */
            ii(0xe02d, 1);    pushw(ax);                                /* push ax */
            ii(0xe02e, 3);    callw(0xfb11, 0x1ae0);                    /* call 0xfb11 */
            ii(0xe031, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe034, 3);    mov(memw_a16[ss, bp - 0x4], ax);          /* mov [bp-0x4], ax */
            ii(0xe037, 3);    mov(memw_a16[ss, bp - 0x2], dx);          /* mov [bp-0x2], dx */
            ii(0xe03a, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xe03d, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xe040, 3);    cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0xe043, 2);    if(jaw(0xe064, 0x1f)) goto l_0xe064;      /* ja 0xe064 */
            ii(0xe045, 2);    if(jbw(0xe04c, 0x5)) goto l_0xe04c;       /* jb 0xe04c */
            ii(0xe047, 3);    cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0xe04a, 2);    if(jaew(0xe064, 0x18)) goto l_0xe064;     /* jae 0xe064 */
        l_0xe04c:
            ii(0xe04c, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xe04f, 3);    or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0xe052, 2);    if(jzw(0xe064, 0x10)) goto l_0xe064;      /* jz 0xe064 */
            ii(0xe054, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0xe057, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0xe05a, 3);    mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0xe05d, 3);    mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0xe060, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe062, 2);    jmpw(0xe02c, -0x38); goto l_0xe02c;       /* jmp 0xe02c */
        l_0xe064:
            ii(0xe064, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xe067, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xe06a, 3);    cmp(memw_a16[ss, bp - 0x4], ax);          /* cmp [bp-0x4], ax */
            ii(0xe06d, 2);    if(jnzw(0xe077, 0x8)) goto l_0xe077;      /* jnz 0xe077 */
            ii(0xe06f, 3);    cmp(memw_a16[ss, bp - 0x2], dx);          /* cmp [bp-0x2], dx */
            ii(0xe072, 2);    if(jnzw(0xe077, 0x3)) goto l_0xe077;      /* jnz 0xe077 */
            ii(0xe074, 3);    jmpw(0xe24b, 0x1d4); goto l_0xe24b;       /* jmp 0xe24b */
        l_0xe077:
            ii(0xe077, 3);    mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0xe07a, 3);    or(ax, memw_a16[ss, bp - 0x4]);           /* or ax, [bp-0x4] */
            ii(0xe07d, 2);    if(jzw(0xe09d, 0x1e)) goto l_0xe09d;      /* jz 0xe09d */
            ii(0xe07f, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0xe082, 3);    mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0xe085, 3);    add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0xe088, 3);    adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0xe08b, 3);    cmp(dx, memw_a16[ss, bp - 0x2]);          /* cmp dx, [bp-0x2] */
            ii(0xe08e, 2);    if(jbw(0xe09d, 0xd)) goto l_0xe09d;       /* jb 0xe09d */
            ii(0xe090, 2);    if(jbew(0xe095, 0x3)) goto l_0xe095;      /* jbe 0xe095 */
            ii(0xe092, 3);    jmpw(0xe24b, 0x1b6); goto l_0xe24b;       /* jmp 0xe24b */
        l_0xe095:
            ii(0xe095, 3);    cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0xe098, 2);    if(jbew(0xe09d, 0x3)) goto l_0xe09d;      /* jbe 0xe09d */
            ii(0xe09a, 3);    jmpw(0xe24b, 0x1ae); goto l_0xe24b;       /* jmp 0xe24b */
        l_0xe09d:
            ii(0xe09d, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe09f, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe0a2, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe0a5, 3);    callw(0xfb11, 0x1a69);                    /* call 0xfb11 */
            ii(0xe0a8, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe0ab, 3);    add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0xe0ae, 3);    adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0xe0b1, 3);    cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0xe0b4, 2);    if(jbw(0xe0c0, 0xa)) goto l_0xe0c0;       /* jb 0xe0c0 */
            ii(0xe0b6, 2);    if(jaw(0xe0bd, 0x5)) goto l_0xe0bd;       /* ja 0xe0bd */
            ii(0xe0b8, 3);    cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0xe0bb, 2);    if(jbew(0xe0c0, 0x3)) goto l_0xe0c0;      /* jbe 0xe0c0 */
        l_0xe0bd:
            ii(0xe0bd, 3);    jmpw(0xe24b, 0x18b); goto l_0xe24b;       /* jmp 0xe24b */
        l_0xe0c0:
            ii(0xe0c0, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe0c3, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe0c6, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe0c8, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe0cb, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe0ce, 3);    callw(0xfb27, 0x1a56);                    /* call 0xfb27 */
            ii(0xe0d1, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe0d4, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xe0d7, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xe0da, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe0dc, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe0df, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe0e2, 3);    callw(0xfb27, 0x1a42);                    /* call 0xfb27 */
            ii(0xe0e5, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe0e8, 3);    mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0xe0eb, 3);    mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0xe0ee, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0xe0f1, 3);    mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0xe0f4, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe0f6, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe0f9, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe0fc, 3);    callw(0xfb11, 0x1a12);                    /* call 0xfb11 */
            ii(0xe0ff, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe102, 3);    add(ax, memw_a16[ss, bp - 0x8]);          /* add ax, [bp-0x8] */
            ii(0xe105, 3);    adc(dx, memw_a16[ss, bp - 0x6]);          /* adc dx, [bp-0x6] */
            ii(0xe108, 3);    cmp(ax, memw_a16[ss, bp + 0x4]);          /* cmp ax, [bp+0x4] */
            ii(0xe10b, 2);    if(jnzw(0xe15e, 0x51)) goto l_0xe15e;     /* jnz 0xe15e */
            ii(0xe10d, 3);    cmp(dx, memw_a16[ss, bp + 0x6]);          /* cmp dx, [bp+0x6] */
            ii(0xe110, 2);    if(jnzw(0xe15e, 0x4c)) goto l_0xe15e;     /* jnz 0xe15e */
            ii(0xe112, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe114, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe117, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe11a, 3);    callw(0xfb11, 0x19f4);                    /* call 0xfb11 */
            ii(0xe11d, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe120, 3);    add(ax, memw_a16[ss, bp - 0xc]);          /* add ax, [bp-0xc] */
            ii(0xe123, 3);    adc(dx, memw_a16[ss, bp - 0xa]);          /* adc dx, [bp-0xa] */
            ii(0xe126, 3);    mov(memw_a16[ss, bp - 0xc], ax);          /* mov [bp-0xc], ax */
            ii(0xe129, 3);    mov(memw_a16[ss, bp - 0xa], dx);          /* mov [bp-0xa], dx */
            ii(0xe12c, 1);    pushw(dx);                                /* push dx */
            ii(0xe12d, 1);    pushw(ax);                                /* push ax */
            ii(0xe12e, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe130, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe133, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe136, 3);    callw(0xfb27, 0x19ee);                    /* call 0xfb27 */
            ii(0xe139, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe13c, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xe13f, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xe142, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe144, 3);    pushw(memw_a16[ss, bp - 0x6]);            /* push word [bp-0x6] */
            ii(0xe147, 3);    pushw(memw_a16[ss, bp - 0x8]);            /* push word [bp-0x8] */
            ii(0xe14a, 3);    callw(0xfb27, 0x19da);                    /* call 0xfb27 */
            ii(0xe14d, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe150, 3);    mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0xe153, 3);    mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0xe156, 3);    mov(memw_a16[ss, bp + 0x4], ax);          /* mov [bp+0x4], ax */
            ii(0xe159, 3);    mov(memw_a16[ss, bp + 0x6], dx);          /* mov [bp+0x6], dx */
            ii(0xe15c, 2);    jmpw(0xe172, 0x14); goto l_0xe172;        /* jmp 0xe172 */
        l_0xe15e:
            ii(0xe15e, 3);    pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0xe161, 3);    pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0xe164, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe166, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe169, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe16c, 3);    callw(0xfb27, 0x19b8);                    /* call 0xfb27 */
            ii(0xe16f, 3);    add(sp, 0xa);                             /* add sp, 0xa */
        l_0xe172:
            ii(0xe172, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe174, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe177, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe17a, 3);    callw(0xfb11, 0x1994);                    /* call 0xfb11 */
            ii(0xe17d, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe180, 3);    add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0xe183, 3);    adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0xe186, 3);    cmp(ax, memw_a16[ss, bp - 0x4]);          /* cmp ax, [bp-0x4] */
            ii(0xe189, 2);    if(jnzw(0xe1e4, 0x59)) goto l_0xe1e4;     /* jnz 0xe1e4 */
            ii(0xe18b, 3);    cmp(dx, memw_a16[ss, bp - 0x2]);          /* cmp dx, [bp-0x2] */
            ii(0xe18e, 2);    if(jnzw(0xe1e4, 0x54)) goto l_0xe1e4;     /* jnz 0xe1e4 */
            ii(0xe190, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe192, 1);    pushw(dx);                                /* push dx */
            ii(0xe193, 1);    pushw(ax);                                /* push ax */
            ii(0xe194, 3);    callw(0xfb11, 0x197a);                    /* call 0xfb11 */
            ii(0xe197, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe19a, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe19c, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe19f, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe1a2, 2);    mov(si, ax);                              /* mov si, ax */
            ii(0xe1a4, 2);    mov(di, dx);                              /* mov di, dx */
            ii(0xe1a6, 3);    callw(0xfb11, 0x1968);                    /* call 0xfb11 */
            ii(0xe1a9, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe1ac, 2);    add(si, ax);                              /* add si, ax */
            ii(0xe1ae, 2);    adc(di, dx);                              /* adc di, dx */
            ii(0xe1b0, 3);    mov(memw_a16[ss, bp - 0xc], si);          /* mov [bp-0xc], si */
            ii(0xe1b3, 3);    mov(memw_a16[ss, bp - 0xa], di);          /* mov [bp-0xa], di */
            ii(0xe1b6, 1);    pushw(di);                                /* push di */
            ii(0xe1b7, 1);    pushw(si);                                /* push si */
            ii(0xe1b8, 2);    pushw(0x4);                               /* push 0x4 */
            ii(0xe1ba, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe1bd, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe1c0, 3);    callw(0xfb27, 0x1964);                    /* call 0xfb27 */
            ii(0xe1c3, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xe1c6, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe1c8, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0xe1cb, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0xe1ce, 3);    callw(0xfb11, 0x1940);                    /* call 0xfb11 */
            ii(0xe1d1, 3);    add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0xe1d4, 1);    pushw(dx);                                /* push dx */
            ii(0xe1d5, 1);    pushw(ax);                                /* push ax */
            ii(0xe1d6, 2);    pushw(0);                                 /* push 0x0 */
            ii(0xe1d8, 3);    pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0xe1db, 3);    pushw(memw_a16[ss, bp + 0x4]);            /* push word [bp+0x4] */
            ii(0xe1de, 3);    callw(0xfb27, 0x1946);                    /* call 0xfb27 */
            ii(0xe1e1, 3);    add(sp, 0xa);                             /* add sp, 0xa */
        l_0xe1e4:
            ii(0xe1e4, 3);    pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0xe1e7, 3);    pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0xe1ea, 3);    callw(0xdd62, -0x48b);                    /* call 0xdd62 */
            ii(0xe1ed, 1);    popw(bx);                                 /* pop bx */
            ii(0xe1ee, 1);    popw(bx);                                 /* pop bx */
            ii(0xe1ef, 1);    sti();                                    /* sti */
            ii(0xe1f0, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0xe1f5, 2);    if(jnzw(0xe24b, 0x54)) goto l_0xe24b;     /* jnz 0xe24b */
            ii(0xe1f7, 4);    mov(ah, memb_a16[ds, 0x15]);              /* mov ah, [0x15] */
            ii(0xe1fb, 3);    and(ax, 0x4000);                          /* and ax, 0x4000 */
            ii(0xe1fe, 3);    cmp(ax, 0x1);                             /* cmp ax, 0x1 */
            ii(0xe201, 2);    sbb(ax, ax);                              /* sbb ax, ax */
            ii(0xe203, 1);    inc(ax);                                  /* inc ax */
            ii(0xe204, 4);    mov(cl, memb_a16[ds, 0x47]);              /* mov cl, [0x47] */
            ii(0xe208, 3);    and(cl, 0x80);                            /* and cl, 0x80 */
            ii(0xe20b, 3);    cmp(cl, 0x1);                             /* cmp cl, 0x1 */
            ii(0xe20e, 2);    sbb(cx, cx);                              /* sbb cx, cx */
            ii(0xe210, 1);    inc(cx);                                  /* inc cx */
            ii(0xe211, 2);    xor(ax, cx);                              /* xor ax, cx */
            ii(0xe213, 2);    if(jzw(0xe24b, 0x36)) goto l_0xe24b;      /* jz 0xe24b */
            ii(0xe215, 5);    cmp(memb_a16[ds, 0x9f8], 0x1);            /* cmp byte [0x9f8], 0x1 */
            ii(0xe21a, 2);    sbb(ax, ax);                              /* sbb ax, ax */
            ii(0xe21c, 3);    and(ah, 0x7);                             /* and ah, 0x7 */
            ii(0xe21f, 3);    add(ah, -0x10 /* 0xf0 */);                /* add ah, 0xf0 */
            ii(0xe222, 1);    pushw(ax);                                /* push ax */
            ii(0xe223, 3);    mov(ax, memw_a16[ss, bp - 0xc]);          /* mov ax, [bp-0xc] */
            ii(0xe226, 3);    mov(dx, memw_a16[ss, bp - 0xa]);          /* mov dx, [bp-0xa] */
            ii(0xe229, 3);    add(ax, memw_a16[ss, bp + 0x4]);          /* add ax, [bp+0x4] */
            ii(0xe22c, 3);    adc(dx, memw_a16[ss, bp + 0x6]);          /* adc dx, [bp+0x6] */
            ii(0xe22f, 3);    sub(ax, 0x1);                             /* sub ax, 0x1 */
            ii(0xe232, 3);    sbb(dx, 0);                               /* sbb dx, 0x0 */
            ii(0xe235, 1);    pushw(dx);                                /* push dx */
            ii(0xe236, 1);    pushw(ax);                                /* push ax */
            ii(0xe237, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xe23a, 3);    mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0xe23d, 3);    add(ax, 0x1);                             /* add ax, 0x1 */
            ii(0xe240, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xe243, 1);    pushw(dx);                                /* push dx */
            ii(0xe244, 1);    pushw(ax);                                /* push ax */
            ii(0xe245, 3);    callw(0x1_1354, 0x310c);                  /* call 0x1354 */
            ii(0xe248, 3);    add(sp, 0xa);                             /* add sp, 0xa */
        l_0xe24b:
            ii(0xe24b, 5);    test(memb_a16[ds, 0x47], 0x80);           /* test byte [0x47], 0x80 */
            ii(0xe250, 2);    if(jzw(0xe258, 0x6)) goto l_0xe258;       /* jz 0xe258 */
            ii(0xe252, 3);    pushw(0x111b);                            /* push 0x111b */
            ii(0xe255, 3);    callw(0xdfc4, -0x294);                    /* call 0xdfc4 */
        l_0xe258:
            ii(0xe258, 1);    popw(si);                                 /* pop si */
            ii(0xe259, 1);    popw(di);                                 /* pop di */
            ii(0xe25a, 1);    leavew();                                 /* leave */
            ii(0xe25b, 1);    retw(); return;                           /* ret */
        }
    }
}
