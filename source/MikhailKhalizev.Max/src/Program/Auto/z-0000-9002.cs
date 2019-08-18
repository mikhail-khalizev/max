using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9002-7d4210e0")]
        public void Method_0000_9002()
        {
            ii(0x9002, 4);    enterw(0x4, 0);                           /* enter 0x4, 0x0 */
            ii(0x9006, 5);    test(memb_a16[ds, 0x47], 0x2);            /* test byte [0x47], 0x2 */
            ii(0x900b, 2);    if(jzw(0x9085, 0x78)) goto l_0x9085;      /* jz 0x9085 */
            ii(0x900d, 5);    mov(memw_a16[ss, bp - 0x4], 0xa000);      /* mov word [bp-0x4], 0xa000 */
            ii(0x9012, 5);    mov(memw_a16[ss, bp - 0x2], 0xf);         /* mov word [bp-0x2], 0xf */
        l_0x9017:
            ii(0x9017, 4);    cmp(memw_a16[ss, bp - 0x2], 0xf);         /* cmp word [bp-0x2], 0xf */
            ii(0x901b, 2);    if(jgw(0x906e, 0x51)) goto l_0x906e;      /* jg 0x906e */
            ii(0x901d, 2);    if(jlw(0x9025, 0x6)) goto l_0x9025;       /* jl 0x9025 */
            ii(0x901f, 4);    cmp(memw_a16[ss, bp - 0x4], -0x1 /* 0xff */); /* cmp word [bp-0x4], 0xffff */
            ii(0x9023, 2);    if(jaew(0x906e, 0x49)) goto l_0x906e;     /* jae 0x906e */
        l_0x9025:
            ii(0x9025, 3);    pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x9028, 3);    pushw(memw_a16[ss, bp - 0x4]);            /* push word [bp-0x4] */
            ii(0x902b, 3);    callw(0x8d9d, -0x291);                    /* call 0x8d9d */
            ii(0x902e, 1);    popw(bx);                                 /* pop bx */
            ii(0x902f, 1);    popw(bx);                                 /* pop bx */
            ii(0x9030, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9032, 2);    if(jzw(0x906e, 0x3a)) goto l_0x906e;      /* jz 0x906e */
            ii(0x9034, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x9037, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x903a, 3);    add(ax, 0x3ff);                           /* add ax, 0x3ff */
            ii(0x903d, 3);    adc(dx, 0);                               /* adc dx, 0x0 */
            ii(0x9040, 1);    pushw(dx);                                /* push dx */
            ii(0x9041, 1);    pushw(ax);                                /* push ax */
            ii(0x9042, 3);    callw(0x8d9d, -0x2a8);                    /* call 0x8d9d */
            ii(0x9045, 1);    popw(bx);                                 /* pop bx */
            ii(0x9046, 1);    popw(bx);                                 /* pop bx */
            ii(0x9047, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x9049, 2);    if(jzw(0x906e, 0x23)) goto l_0x906e;      /* jz 0x906e */
            ii(0x904b, 3);    pushw(0x4000);                            /* push 0x4000 */
            ii(0x904e, 2);    pushw(0);                                 /* push 0x0 */
            ii(0x9050, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x9053, 3);    mov(dx, memw_a16[ss, bp - 0x2]);          /* mov dx, [bp-0x2] */
            ii(0x9056, 2);    mov(cl, 0x4);                             /* mov cl, 0x4 */
            ii(0x9058, 3);    callw(0x6544, -0x2b17);                   /* call 0x6544 */
            ii(0x905b, 1);    pushw(dx);                                /* push dx */
            ii(0x905c, 1);    pushw(ax);                                /* push ax */
            ii(0x905d, 3);    callw(0x4fc2, -0x409e);                   /* call 0x4fc2 */
            ii(0x9060, 3);    add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x9063, 5);    add(memw_a16[ss, bp - 0x4], 0x400);       /* add word [bp-0x4], 0x400 */
            ii(0x9068, 4);    adc(memw_a16[ss, bp - 0x2], 0);           /* adc word [bp-0x2], 0x0 */
            ii(0x906c, 2);    jmpw(0x9017, -0x57); goto l_0x9017;       /* jmp 0x9017 */
        l_0x906e:
            ii(0x906e, 3);    mov(ax, memw_a16[ss, bp - 0x4]);          /* mov ax, [bp-0x4] */
            ii(0x9071, 3);    add(ah, 0x60);                            /* add ah, 0x60 */
            ii(0x9074, 3);    mov(bx, memw_a16[ss, bp + 0x4]);          /* mov bx, [bp+0x4] */
            ii(0x9077, 2);    mov(memw_a16[ds, bx], ax);                /* mov [bx], ax */
            ii(0x9079, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x907b, 2);    if(jzw(0x9085, 0x8)) goto l_0x9085;       /* jz 0x9085 */
            ii(0x907d, 3);    mov(ax, 0xa000);                          /* mov ax, 0xa000 */
            ii(0x9080, 3);    mov(dx, 0xf);                             /* mov dx, 0xf */
            ii(0x9083, 1);    leavew();                                 /* leave */
            ii(0x9084, 1);    retw(); return;                           /* ret */
        l_0x9085:
            ii(0x9085, 5);    and(memb_a16[ds, 0x47], -0x3 /* 0xfd */); /* and byte [0x47], 0xfd */
            ii(0x908a, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x908c, 1);    cwd();                                    /* cwd */
            ii(0x908d, 1);    leavew();                                 /* leave */
            ii(0x908e, 1);    retw(); return;                           /* ret */
        }
    }
}
