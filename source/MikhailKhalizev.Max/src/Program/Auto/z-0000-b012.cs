using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb012-7d4210e0")]
        public void Method_0000_b012()
        {
            ii(0xb012, 4);    enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0xb016, 5);    test(memb[ds, 0x47], 2);                  /* test byte [0x47], 0x2 */
            ii(0xb01b, 2);    if(jz(0xb095, 0x78)) goto l_0xb095;       /* jz 0xb095 */
            ii(0xb01d, 5);    mov(memw[ss, bp - 4], 0xa000);            /* mov word [bp-0x4], 0xa000 */
            ii(0xb022, 5);    mov(memw[ss, bp - 2], 0xf);               /* mov word [bp-0x2], 0xf */
        l_0xb027:
            ii(0xb027, 4);    cmp(memw[ss, bp - 2], 0xf);               /* cmp word [bp-0x2], 0xf */
            ii(0xb02b, 2);    if(jg(0xb07e, 0x51)) goto l_0xb07e;       /* jg 0xb07e */
            ii(0xb02d, 2);    if(jl(0xb035, 6)) goto l_0xb035;          /* jl 0xb035 */
            ii(0xb02f, 4);    cmp(memw[ss, bp - 4], -1 /* 0xff */);     /* cmp word [bp-0x4], 0xffff */
            ii(0xb033, 2);    if(jae(0xb07e, 0x49)) goto l_0xb07e;      /* jae 0xb07e */
        l_0xb035:
            ii(0xb035, 3);    push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0xb038, 3);    push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0xb03b, 3);    call(0xadad, -0x291);                     /* call 0xadad */
            ii(0xb03e, 1);    pop(bx);                                  /* pop bx */
            ii(0xb03f, 1);    pop(bx);                                  /* pop bx */
            ii(0xb040, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb042, 2);    if(jz(0xb07e, 0x3a)) goto l_0xb07e;       /* jz 0xb07e */
            ii(0xb044, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0xb047, 3);    mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0xb04a, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0xb04d, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0xb050, 1);    push(dx);                                 /* push dx */
            ii(0xb051, 1);    push(ax);                                 /* push ax */
            ii(0xb052, 3);    call(0xadad, -0x2a8);                     /* call 0xadad */
            ii(0xb055, 1);    pop(bx);                                  /* pop bx */
            ii(0xb056, 1);    pop(bx);                                  /* pop bx */
            ii(0xb057, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb059, 2);    if(jz(0xb07e, 0x23)) goto l_0xb07e;       /* jz 0xb07e */
            ii(0xb05b, 3);    push(0x4000);                             /* push 0x4000 */
            ii(0xb05e, 2);    push(0);                                  /* push 0x0 */
            ii(0xb060, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0xb063, 3);    mov(dx, memw[ss, bp - 2]);                /* mov dx, [bp-0x2] */
            ii(0xb066, 2);    mov(cl, 4);                               /* mov cl, 0x4 */
            ii(0xb068, 3);    call(0x8554, -0x2b17);                    /* call 0x8554 */
            ii(0xb06b, 1);    push(dx);                                 /* push dx */
            ii(0xb06c, 1);    push(ax);                                 /* push ax */
            ii(0xb06d, 3);    call(0x6fd2, -0x409e);                    /* call 0x6fd2 */
            ii(0xb070, 3);    add(sp, 8);                               /* add sp, 0x8 */
            ii(0xb073, 5);    add(memw[ss, bp - 4], 0x400);             /* add word [bp-0x4], 0x400 */
            ii(0xb078, 4);    adc(memw[ss, bp - 2], 0);                 /* adc word [bp-0x2], 0x0 */
            ii(0xb07c, 2);    jmp(0xb027, -0x57); goto l_0xb027;        /* jmp 0xb027 */
        l_0xb07e:
            ii(0xb07e, 3);    mov(ax, memw[ss, bp - 4]);                /* mov ax, [bp-0x4] */
            ii(0xb081, 3);    add(ah, 0x60);                            /* add ah, 0x60 */
            ii(0xb084, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0xb087, 2);    mov(memw[ds, bx], ax);                    /* mov [bx], ax */
            ii(0xb089, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0xb08b, 2);    if(jz(0xb095, 8)) goto l_0xb095;          /* jz 0xb095 */
            ii(0xb08d, 3);    mov(ax, 0xa000);                          /* mov ax, 0xa000 */
            ii(0xb090, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0xb093, 1);    leave();                                  /* leave */
            ii(0xb094, 1);    ret(); return;                            /* ret */
        l_0xb095:
            ii(0xb095, 5);    and(memb[ds, 0x47], -3 /* 0xfd */);       /* and byte [0x47], 0xfd */
            ii(0xb09a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0xb09c, 1);    cwd();                                    /* cwd */
            ii(0xb09d, 1);    leave();                                  /* leave */
            ii(0xb09e, 1);    ret();                                    /* ret */
        }
    }
}
