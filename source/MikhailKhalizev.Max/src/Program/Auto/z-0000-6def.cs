using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x6def-3d800b7a")]
        public void Method_0000_6def()
        {
            ii(0x6def, 4);    enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x6df3, 5);    mov(memw[ss, bp - 2], 2);                 /* mov word [bp-0x2], 0x2 */
        l_0x6df8:
            ii(0x6df8, 4);    push(memw[ds, 0x11dc]);                   /* push word [0x11dc] */
            ii(0x6dfc, 4);    push(memw[ds, 0x11da]);                   /* push word [0x11da] */
            ii(0x6e00, 3);    call(0x9d6a, 0x2f67);                     /* call 0x9d6a */
            ii(0x6e03, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e04, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e05, 3);    push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x6e08, 3);    push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x6e0b, 3);    call(0x9d82, 0x2f74);                     /* call 0x9d82 */
            ii(0x6e0e, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e0f, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e10, 3);    cmp(ax, memw[ss, bp + 8]);                /* cmp ax, [bp+0x8] */
            ii(0x6e13, 2);    if(jnz(0x6e62, 0x4d)) goto l_0x6e62;      /* jnz 0x6e62 */
            ii(0x6e15, 3);    mov(bx, memw[ss, bp + 4]);                /* mov bx, [bp+0x4] */
            ii(0x6e18, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x6e1b, 2);    if(jnz(0x6e33, 0x16)) goto l_0x6e33;      /* jnz 0x6e33 */
            ii(0x6e1d, 4);    cmp(memb[ds, bx + 1], 0x46);              /* cmp byte [bx+0x1], 0x46 */
            ii(0x6e21, 2);    if(jnz(0x6e33, 0x10)) goto l_0x6e33;      /* jnz 0x6e33 */
            ii(0x6e23, 3);    mov(ax, memw[ds, bx + 2]);                /* mov ax, [bx+0x2] */
            ii(0x6e26, 3);    mov(dx, memw[ds, bx + 4]);                /* mov dx, [bx+0x4] */
        l_0x6e29:
            ii(0x6e29, 4);    add(memw[ds, 0x11da], ax);                /* add [0x11da], ax */
            ii(0x6e2d, 4);    adc(memw[ds, 0x11dc], dx);                /* adc [0x11dc], dx */
            ii(0x6e31, 2);    jmp(0x6e5c, 0x29); goto l_0x6e5c;         /* jmp 0x6e5c */
        l_0x6e33:
            ii(0x6e33, 3);    cmp(memb[ds, bx], 0x4d);                  /* cmp byte [bx], 0x4d */
            ii(0x6e36, 2);    if(jnz(0x6e45, 0xd)) goto l_0x6e45;       /* jnz 0x6e45 */
            ii(0x6e38, 4);    cmp(memb[ds, bx + 1], 0x5a);              /* cmp byte [bx+0x1], 0x5a */
            ii(0x6e3c, 2);    if(jnz(0x6e45, 7)) goto l_0x6e45;         /* jnz 0x6e45 */
            ii(0x6e3e, 1);    push(bx);                                 /* push bx */
            ii(0x6e3f, 3);    call(0x6dab, -0x97);                      /* call 0x6dab */
            ii(0x6e42, 1);    pop(bx);                                  /* pop bx */
            ii(0x6e43, 2);    jmp(0x6e29, -0x1c); goto l_0x6e29;        /* jmp 0x6e29 */
        l_0x6e45:
            ii(0x6e45, 3);    cmp(memb[ds, bx], 0x42);                  /* cmp byte [bx], 0x42 */
            ii(0x6e48, 2);    if(jnz(0x6e55, 0xb)) goto l_0x6e55;       /* jnz 0x6e55 */
            ii(0x6e4a, 4);    cmp(memb[ds, bx + 1], 0x57);              /* cmp byte [bx+0x1], 0x57 */
            ii(0x6e4e, 2);    if(jnz(0x6e55, 5)) goto l_0x6e55;         /* jnz 0x6e55 */
            ii(0x6e50, 3);    mov(ax, 1);                               /* mov ax, 0x1 */
            ii(0x6e53, 1);    leave();                                  /* leave */
            ii(0x6e54, 1);    ret(); return;                            /* ret */
        l_0x6e55:
            ii(0x6e55, 2);    mov(ah, 0xd);                             /* mov ah, 0xd */
            ii(0x6e57, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x6e59, 3);    dec(memw[ss, bp - 2]);                    /* dec word [bp-0x2] */
        l_0x6e5c:
            ii(0x6e5c, 4);    cmp(memw[ss, bp - 2], 0);                 /* cmp word [bp-0x2], 0x0 */
            ii(0x6e60, 2);    if(jge(0x6df8, -0x6a)) goto l_0x6df8;     /* jge 0x6df8 */
        l_0x6e62:
            ii(0x6e62, 4);    cmp(memw[ss, bp + 6], 0);                 /* cmp word [bp+0x6], 0x0 */
            ii(0x6e66, 2);    if(jz(0x6e6e, 6)) goto l_0x6e6e;          /* jz 0x6e6e */
            ii(0x6e68, 2);    push(-2 /* 0xfe */);                      /* push 0xfffe */
            ii(0x6e6a, 3);    call(0x604d, -0xe20);                     /* call 0x604d */
            ii(0x6e6d, 1);    pop(bx);                                  /* pop bx */
        l_0x6e6e:
            ii(0x6e6e, 2);    sub(ax, ax);                              /* sub ax, ax */
            ii(0x6e70, 3);    mov(memw[ds, 0x11dc], ax);                /* mov [0x11dc], ax */
            ii(0x6e73, 3);    mov(memw[ds, 0x11da], ax);                /* mov [0x11da], ax */
            ii(0x6e76, 1);    leave();                                  /* leave */
            ii(0x6e77, 1);    ret();                                    /* ret */
        }
    }
}
