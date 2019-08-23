using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8852-7d4210e0")]
        public void Method_0000_8852()
        {
            ii(0x8852, 4);    enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x8856, 5);    test(memb[ds, 0x47], 0x2);                /* test byte [0x47], 0x2 */
            ii(0x885b, 2);    if(jz(0x88d5, 0x78)) goto l_0x88d5;       /* jz 0x88d5 */
            ii(0x885d, 5);    mov(memw[ss, bp - 0x4], 0xa000);          /* mov word [bp-0x4], 0xa000 */
            ii(0x8862, 5);    mov(memw[ss, bp - 0x2], 0xf);             /* mov word [bp-0x2], 0xf */
        l_0x8867:
            ii(0x8867, 4);    cmp(memw[ss, bp - 0x2], 0xf);             /* cmp word [bp-0x2], 0xf */
            ii(0x886b, 2);    if(jg(0x88be, 0x51)) goto l_0x88be;       /* jg 0x88be */
            ii(0x886d, 2);    if(jl(0x8875, 0x6)) goto l_0x8875;        /* jl 0x8875 */
            ii(0x886f, 4);    cmp(memw[ss, bp - 0x4], -0x1 /* 0xff */); /* cmp word [bp-0x4], 0xffff */
            ii(0x8873, 2);    if(jae(0x88be, 0x49)) goto l_0x88be;      /* jae 0x88be */
        l_0x8875:
            ii(0x8875, 3);    push(memw[ss, bp - 0x2]);                 /* push word [bp-0x2] */
            ii(0x8878, 3);    push(memw[ss, bp - 0x4]);                 /* push word [bp-0x4] */
            ii(0x887b, 3);    call(0x85ed, -0x291);                     /* call 0x85ed */
            ii(0x887e, 1);    pop(bx);                                  /* pop bx */
            ii(0x887f, 1);    pop(bx);                                  /* pop bx */
            ii(0x8880, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8882, 2);    if(jz(0x88be, 0x3a)) goto l_0x88be;       /* jz 0x88be */
            ii(0x8884, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x8887, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x888a, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0x888d, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x8890, 1);    push(dx);                                 /* push dx */
            ii(0x8891, 1);    push(ax);                                 /* push ax */
            ii(0x8892, 3);    call(0x85ed, -0x2a8);                     /* call 0x85ed */
            ii(0x8895, 1);    pop(bx);                                  /* pop bx */
            ii(0x8896, 1);    pop(bx);                                  /* pop bx */
            ii(0x8897, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8899, 2);    if(jz(0x88be, 0x23)) goto l_0x88be;       /* jz 0x88be */
            ii(0x889b, 3);    push(0x4000);                             /* push 0x4000 */
            ii(0x889e, 2);    push(0);                                  /* push 0x0 */
            ii(0x88a0, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x88a3, 3);    mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x88a6, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x88a8, 3);    call(0x5d94, -0x2b17);                    /* call 0x5d94 */
            ii(0x88ab, 1);    push(dx);                                 /* push dx */
            ii(0x88ac, 1);    push(ax);                                 /* push ax */
            ii(0x88ad, 3);    call(0x4812, -0x409e);                    /* call 0x4812 */
            ii(0x88b0, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x88b3, 5);    add(memw[ss, bp - 0x4], 0x400);           /* add word [bp-0x4], 0x400 */
            ii(0x88b8, 4);    adc(memw[ss, bp - 0x2], 0);               /* adc word [bp-0x2], 0x0 */
            ii(0x88bc, 2);    jmp(0x8867, -0x57); goto l_0x8867;        /* jmp 0x8867 */
        l_0x88be:
            ii(0x88be, 3);    mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x88c1, 3);    add(ah, 0x60);                            /* add ah, 0x60 */
            ii(0x88c4, 3);    mov(bx, memw[ss, bp + 0x4]);              /* mov bx, [bp+0x4] */
            ii(0x88c7, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0x88c9, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x88cb, 2);    if(jz(0x88d5, 0x8)) goto l_0x88d5;        /* jz 0x88d5 */
            ii(0x88cd, 3);    mov(ax, 0xa000);                          /* mov ax, 0xa000 */
            ii(0x88d0, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0x88d3, 1);    leave();                                  /* leave */
            ii(0x88d4, 1);    ret(); return;                            /* ret */
        l_0x88d5:
            ii(0x88d5, 5);    and(memb[ds, 0x47], -0x3 /* 0xfd */);     /* and byte [0x47], 0xfd */
            ii(0x88da, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x88dc, 1);    cwd();                                    /* cwd */
            ii(0x88dd, 1);    leave();                                  /* leave */
            ii(0x88de, 1);    ret();                                    /* ret */
        }
    }
}
