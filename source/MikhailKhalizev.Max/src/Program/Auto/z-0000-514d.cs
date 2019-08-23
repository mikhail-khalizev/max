using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x514d-137911bc")]
        public void Method_0000_514d()
        {
            ii(0x514d, 3);    call(0x540b, 0x2bb);                      /* call 0x540b */
            ii(0x5150, 2);    if(jnz(0x51c7, 0x75)) goto l_0x51c7;      /* jnz 0x51c7 */
            ii(0x5152, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x5154, 2);    mov(es, bx);                              /* mov es, bx */
            ii(0x5156, 4);    mov(bl, memb[ds, 0x34]);                  /* mov bl, [0x34] */
            ii(0x515a, 3);    shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x515d, 2);    mov(dx, cs);                              /* mov dx, cs */
            ii(0x515f, 4);    cmp(dx, memw[es, bx + 0x2]);              /* cmp dx, [es:bx+0x2] */
            ii(0x5163, 2);    if(jnz(0x5184, 0x1f)) goto l_0x5184;      /* jnz 0x5184 */
            ii(0x5165, 2);    mov(ah, 0x25);                            /* mov ah, 0x25 */
            ii(0x5167, 5);    cmp(memb[ds, 0x34], 0x15);                /* cmp byte [0x34], 0x15 */
            ii(0x516c, 5);    lds(dx, cs, 0x12c4);                      /* lds dx, [cs:0x12c4] */
            ii(0x5171, 2);    if(jz(0x5178, 0x5)) goto l_0x5178;        /* jz 0x5178 */
            ii(0x5173, 5);    lds(dx, ss, 0xf84);                       /* lds dx, [ss:0xf84] */
        l_0x5178:
            ii(0x5178, 1);    cli();                                    /* cli */
            ii(0x5179, 3);    mov(memw[es, bx], dx);                    /* mov [es:bx], dx */
            ii(0x517c, 4);    mov(memw[es, bx + 0x2], ds);              /* mov [es:bx+0x2], ds */
            ii(0x5180, 1);    sti();                                    /* sti */
            ii(0x5181, 1);    push(ss);                                 /* push ss */
            ii(0x5182, 1);    pop(ds);                                  /* pop ds */
            ii(0x5183, 1);    ret(); return;                            /* ret */
        l_0x5184:
            ii(0x5184, 1);    xchg(cx, ax);                             /* xchg cx, ax */
        l_0x5185:
            ii(0x5185, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x5187, 3);    cmp(ax, memw[ds, bx - 0x2]);              /* cmp ax, [bx-0x2] */
            ii(0x518a, 2);    if(jnz(0x51c7, 0x3b)) goto l_0x51c7;      /* jnz 0x51c7 */
            ii(0x518c, 3);    cmp(bx, memw[ds, bx - 0x4]);              /* cmp bx, [bx-0x4] */
            ii(0x518f, 2);    if(jnz(0x51c7, 0x36)) goto l_0x51c7;      /* jnz 0x51c7 */
            ii(0x5191, 3);    mov(ax, memw[ds, bx - 0x6]);              /* mov ax, [bx-0x6] */
            ii(0x5194, 2);    cmp(dx, ax);                              /* cmp dx, ax */
            ii(0x5196, 2);    if(jz(0x519d, 0x5)) goto l_0x519d;        /* jz 0x519d */
            ii(0x5198, 3);    mov(bx, memw[ds, bx - 0x8]);              /* mov bx, [bx-0x8] */
            ii(0x519b, 2);    jmp(0x5185, -0x18); goto l_0x5185;        /* jmp 0x5185 */
        l_0x519d:
            ii(0x519d, 4);    mov(ax, memw[cs, 0x12c4]);                /* mov ax, [cs:0x12c4] */
            ii(0x51a1, 1);    cli();                                    /* cli */
            ii(0x51a2, 3);    mov(memw[ds, bx - 0x8], ax);              /* mov [bx-0x8], ax */
            ii(0x51a5, 4);    mov(ax, memw[cs, 0x12c6]);                /* mov ax, [cs:0x12c6] */
            ii(0x51a9, 3);    mov(memw[ds, bx - 0x6], ax);              /* mov [bx-0x6], ax */
            ii(0x51ac, 1);    sti();                                    /* sti */
            ii(0x51ad, 3);    mov(ax, memw[ds, 0]);                     /* mov ax, [0x0] */
            ii(0x51b0, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x51b2, 2);    if(jnz(0x51b7, 0x3)) goto l_0x51b7;       /* jnz 0x51b7 */
            ii(0x51b4, 3);    mov(ax, memw[ds, 0x10]);                  /* mov ax, [0x10] */
        l_0x51b7:
            ii(0x51b7, 2);    or(ax, ax);                               /* or ax, ax */
            ii(0x51b9, 2);    if(jz(0x51c7, 0xc)) goto l_0x51c7;        /* jz 0x51c7 */
            ii(0x51bb, 3);    sub(ax, 0x11);                            /* sub ax, 0x11 */
            ii(0x51be, 2);    mov(ds, ax);                              /* mov ds, ax */
            ii(0x51c0, 1);    inc(ax);                                  /* inc ax */
            ii(0x51c1, 4);    cmp(memw[ds, 0x1], ax);                   /* cmp [0x1], ax */
            ii(0x51c5, 2);    if(jz(0x51ca, 0x3)) goto l_0x51ca;        /* jz 0x51ca */
        l_0x51c7:
            ii(0x51c7, 3);    mov(ax, 0xffff);                          /* mov ax, 0xffff */
        l_0x51ca:
            ii(0x51ca, 5);    mov(bx, memw[ss, 0xcec]);                 /* mov bx, [ss:0xcec] */
            ii(0x51cf, 1);    dec(bx);                                  /* dec bx */
            ii(0x51d0, 2);    mov(ds, bx);                              /* mov ds, bx */
            ii(0x51d2, 3);    mov(memw[ds, 0x1], ax);                   /* mov [0x1], ax */
            ii(0x51d5, 1);    push(ss);                                 /* push ss */
            ii(0x51d6, 1);    pop(ds);                                  /* pop ds */
            ii(0x51d7, 1);    ret();                                    /* ret */
        }
    }
}
