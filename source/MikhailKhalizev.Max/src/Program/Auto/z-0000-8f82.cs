using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8f82-db04e188")]
        public void Method_0000_8f82()
        {
            ii(0x8f82, 1);    push(bp);                                 /* push bp */
            ii(0x8f83, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8f85, 4);    sub(sp, 0x10a);                           /* sub sp, 0x10a */
            ii(0x8f89, 3);    mov(ax, memw[ds, 0xe70]);                 /* mov ax, [0xe70] */
            ii(0x8f8c, 4);    mov(memw[ss, bp - 0x108], ax);            /* mov [bp-0x108], ax */
            ii(0x8f90, 5);    cmp(memb[ds, 0xf21], 0);                  /* cmp byte [0xf21], 0x0 */
            ii(0x8f95, 2);    if(jg(0x8f9e, 0x7)) goto l_0x8f9e;        /* jg 0x8f9e */
            ii(0x8f97, 5);    cmp(memb[ds, 0xcee], 0x3);                /* cmp byte [0xcee], 0x3 */
            ii(0x8f9c, 2);    if(jge(0x8fa1, 0x3)) goto l_0x8fa1;       /* jge 0x8fa1 */
        l_0x8f9e:
            ii(0x8f9e, 3);    jmp(0x90c2, 0x121); goto l_0x90c2;        /* jmp 0x90c2 */
        l_0x8fa1:
            ii(0x8fa1, 3);    call(0x9edc, 0xf38);                      /* call 0x9edc */
            ii(0x8fa4, 4);    mov(memw[ss, bp - 0x106], ax);            /* mov [bp-0x106], ax */
            ii(0x8fa8, 3);    call(0x6385, -0x2c26);                    /* call 0x6385 */
            ii(0x8fab, 3);    mov(memw[ds, 0xe70], ax);                 /* mov [0xe70], ax */
            ii(0x8fae, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8fb0, 2);    if(jge(0x8fcd, 0x1b)) goto l_0x8fcd;      /* jge 0x8fcd */
            ii(0x8fb2, 4);    lea(ax, bp - 0x100);                      /* lea ax, [bp-0x100] */
            ii(0x8fb6, 1);    push(ax);                                 /* push ax */
            ii(0x8fb7, 3);    mov(cx, 0xf14);                           /* mov cx, 0xf14 */
            ii(0x8fba, 1);    push(cx);                                 /* push cx */
            ii(0x8fbb, 3);    call(0x7c55, -0x1369);                    /* call 0x7c55 */
            ii(0x8fbe, 1);    pop(bx);                                  /* pop bx */
            ii(0x8fbf, 1);    pop(bx);                                  /* pop bx */
            ii(0x8fc0, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x8fc2, 2);    if(jz(0x8fcd, 0x9)) goto l_0x8fcd;        /* jz 0x8fcd */
            ii(0x8fc4, 4);    lea(ax, bp - 0x100);                      /* lea ax, [bp-0x100] */
            ii(0x8fc8, 1);    push(ax);                                 /* push ax */
            ii(0x8fc9, 3);    call(0x95a8, 0x5dc);                      /* call 0x95a8 */
            ii(0x8fcc, 1);    pop(bx);                                  /* pop bx */
        l_0x8fcd:
            ii(0x8fcd, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x8fd2, 2);    if(jge(0x9038, 0x64)) goto l_0x9038;      /* jge 0x9038 */
            ii(0x8fd4, 4);    mov(ax, memw[ss, bp - 0x108]);            /* mov ax, [bp-0x108] */
            ii(0x8fd8, 3);    mov(memw[ds, 0xe70], ax);                 /* mov [0xe70], ax */
            ii(0x8fdb, 3);    call(0x95e7, 0x609);                      /* call 0x95e7 */
            ii(0x8fde, 6);    mov(memw[ss, bp - 0x108], 0xffff);        /* mov word [bp-0x108], 0xffff */
            ii(0x8fe4, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x8fe7, 1);    push(ax);                                 /* push ax */
            ii(0x8fe8, 3);    call(0x95a8, 0x5bd);                      /* call 0x95a8 */
            ii(0x8feb, 1);    pop(bx);                                  /* pop bx */
            ii(0x8fec, 3);    mov(ax, 0x1c);                            /* mov ax, 0x1c */
            ii(0x8fef, 1);    push(ax);                                 /* push ax */
            ii(0x8ff0, 4);    lea(ax, bp - 0x104);                      /* lea ax, [bp-0x104] */
            ii(0x8ff4, 1);    push(ax);                                 /* push ax */
            ii(0x8ff5, 3);    call(0x95d2, 0x5da);                      /* call 0x95d2 */
            ii(0x8ff8, 1);    pop(bx);                                  /* pop bx */
            ii(0x8ff9, 1);    pop(bx);                                  /* pop bx */
            ii(0x8ffa, 4);    lea(ax, bp - 0x104);                      /* lea ax, [bp-0x104] */
            ii(0x8ffe, 1);    push(ax);                                 /* push ax */
            ii(0x8fff, 3);    call(0x90f9, 0xf7);                       /* call 0x90f9 */
            ii(0x9002, 1);    pop(bx);                                  /* pop bx */
            ii(0x9003, 1);    push(dx);                                 /* push dx */
            ii(0x9004, 1);    push(ax);                                 /* push ax */
            ii(0x9005, 3);    call(0x95ba, 0x5b2);                      /* call 0x95ba */
            ii(0x9008, 1);    pop(bx);                                  /* pop bx */
            ii(0x9009, 1);    pop(bx);                                  /* pop bx */
            ii(0x900a, 5);    mov(memb[ss, bp - 0x104], 0);             /* mov byte [bp-0x104], 0x0 */
            ii(0x900f, 3);    mov(ax, 0x6);                             /* mov ax, 0x6 */
            ii(0x9012, 1);    push(ax);                                 /* push ax */
            ii(0x9013, 4);    lea(ax, bp - 0x104);                      /* lea ax, [bp-0x104] */
            ii(0x9017, 1);    push(ax);                                 /* push ax */
            ii(0x9018, 3);    call(0x95d2, 0x5b7);                      /* call 0x95d2 */
            ii(0x901b, 1);    pop(bx);                                  /* pop bx */
            ii(0x901c, 1);    pop(bx);                                  /* pop bx */
            ii(0x901d, 5);    cmp(memb[ss, bp - 0x104], 0x4d);          /* cmp byte [bp-0x104], 0x4d */
            ii(0x9022, 2);    if(jnz(0x902b, 0x7)) goto l_0x902b;       /* jnz 0x902b */
            ii(0x9024, 5);    cmp(memb[ss, bp - 0x103], 0x46);          /* cmp byte [bp-0x103], 0x46 */
            ii(0x9029, 2);    if(jz(0x9038, 0xd)) goto l_0x9038;        /* jz 0x9038 */
        l_0x902b:
            ii(0x902b, 3);    mov(ax, memw[ds, 0xe70]);                 /* mov ax, [0xe70] */
            ii(0x902e, 4);    mov(memw[ss, bp - 0x108], ax);            /* mov [bp-0x108], ax */
            ii(0x9032, 6);    mov(memw[ds, 0xe70], 0xffff);             /* mov word [0xe70], 0xffff */
        l_0x9038:
            ii(0x9038, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x903d, 2);    if(jge(0x906b, 0x2c)) goto l_0x906b;      /* jge 0x906b */
            ii(0x903f, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x9042, 1);    push(ax);                                 /* push ax */
            ii(0x9043, 4);    lea(cx, bp - 0x100);                      /* lea cx, [bp-0x100] */
            ii(0x9047, 1);    push(cx);                                 /* push cx */
            ii(0x9048, 3);    call(0x5bde, -0x346d);                    /* call 0x5bde */
            ii(0x904b, 1);    pop(bx);                                  /* pop bx */
            ii(0x904c, 1);    pop(bx);                                  /* pop bx */
            ii(0x904d, 3);    mov(ax, 0xf1c);                           /* mov ax, 0xf1c */
            ii(0x9050, 1);    push(ax);                                 /* push ax */
            ii(0x9051, 3);    call(0x4e94, -0x41c0);                    /* call 0x4e94 */
            ii(0x9054, 1);    pop(bx);                                  /* pop bx */
            ii(0x9055, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x9058, 1);    push(ax);                                 /* push ax */
            ii(0x9059, 3);    call(0x95a8, 0x54c);                      /* call 0x95a8 */
            ii(0x905c, 1);    pop(bx);                                  /* pop bx */
            ii(0x905d, 4);    lea(ax, bp - 0x100);                      /* lea ax, [bp-0x100] */
            ii(0x9061, 1);    push(ax);                                 /* push ax */
            ii(0x9062, 3);    mov(ax, 0x1190);                          /* mov ax, 0x1190 */
            ii(0x9065, 1);    push(ax);                                 /* push ax */
            ii(0x9066, 3);    call(0x5bde, -0x348b);                    /* call 0x5bde */
            ii(0x9069, 1);    pop(bx);                                  /* pop bx */
            ii(0x906a, 1);    pop(bx);                                  /* pop bx */
        l_0x906b:
            ii(0x906b, 5);    cmp(memw[ds, 0xe70], 0);                  /* cmp word [0xe70], 0x0 */
            ii(0x9070, 2);    if(jl(0x90b1, 0x3f)) goto l_0x90b1;       /* jl 0x90b1 */
            ii(0x9072, 4);    lea(ax, bp - 0x104);                      /* lea ax, [bp-0x104] */
            ii(0x9076, 3);    mov(memw[ds, 0x1188], ax);                /* mov [0x1188], ax */
            ii(0x9079, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x907b, 4);    mov(memw[ss, bp - 0x102], ax);            /* mov [bp-0x102], ax */
            ii(0x907f, 4);    mov(memw[ss, bp - 0x10a], ax);            /* mov [bp-0x10a], ax */
            ii(0x9083, 3);    mov(ax, 0x1);                             /* mov ax, 0x1 */
            ii(0x9086, 1);    push(ax);                                 /* push ax */
            ii(0x9087, 4);    lea(ax, bp - 0x10a);                      /* lea ax, [bp-0x10a] */
            ii(0x908b, 1);    push(ax);                                 /* push ax */
            ii(0x908c, 3);    call(0x95d2, 0x543);                      /* call 0x95d2 */
            ii(0x908f, 1);    pop(bx);                                  /* pop bx */
            ii(0x9090, 1);    pop(bx);                                  /* pop bx */
            ii(0x9091, 5);    cmp(memw[ss, bp - 0x10a], 0x4d);          /* cmp word [bp-0x10a], 0x4d */
            ii(0x9096, 2);    if(jnz(0x909d, 0x5)) goto l_0x909d;       /* jnz 0x909d */
            ii(0x9098, 3);    call(0x93c2, 0x327);                      /* call 0x93c2 */
            ii(0x909b, 2);    jmp(0x90ac, 0xf); goto l_0x90ac;          /* jmp 0x90ac */
        l_0x909d:
            ii(0x909d, 4);    push(memw[ss, bp - 0x106]);               /* push word [bp-0x106] */
            ii(0x90a1, 3);    call(0x91cb, 0x127);                      /* call 0x91cb */
            ii(0x90a4, 1);    pop(bx);                                  /* pop bx */
            ii(0x90a5, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x90a7, 2);    if(jz(0x90b1, 0x8)) goto l_0x90b1;        /* jz 0x90b1 */
            ii(0x90a9, 3);    call(0x927b, 0x1cf);                      /* call 0x927b */
        l_0x90ac:
            ii(0x90ac, 5);    mov(memb[ds, 0xf21], 0x1);                /* mov byte [0xf21], 0x1 */
        l_0x90b1:
            ii(0x90b1, 5);    cmp(memw[ss, bp - 0x108], 0);             /* cmp word [bp-0x108], 0x0 */
            ii(0x90b6, 2);    if(jl(0x90c2, 0xa)) goto l_0x90c2;        /* jl 0x90c2 */
            ii(0x90b8, 3);    call(0x95e7, 0x52c);                      /* call 0x95e7 */
            ii(0x90bb, 4);    mov(ax, memw[ss, bp - 0x108]);            /* mov ax, [bp-0x108] */
            ii(0x90bf, 3);    mov(memw[ds, 0xe70], ax);                 /* mov [0xe70], ax */
        l_0x90c2:
            ii(0x90c2, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x90c4, 1);    pop(bp);                                  /* pop bp */
            ii(0x90c5, 1);    ret();                                    /* ret */
        }
    }
}
