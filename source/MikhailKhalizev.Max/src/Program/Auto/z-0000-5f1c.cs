using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x5f1c-e66f9d3f")]
        public void Method_0000_5f1c()
        {
            ii(0x5f1c, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x5f1e, 3);    mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x5f21, 3);    mov(cx, 0x100);                           /* mov cx, 0x100 */
            ii(0x5f24, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0x5f26:
            ii(0x5f26, 4);    mov(memw[ds, bx + 0xc6], ax);             /* mov [bx+0xc6], ax */
            ii(0x5f2a, 6);    mov(memw[ds, bx + 0xc4], 0x8e00);         /* mov word [bx+0xc4], 0x8e00 */
            ii(0x5f30, 6);    mov(memw[ds, bx + 0xc2], 0x70);           /* mov word [bx+0xc2], 0x70 */
            ii(0x5f36, 4);    mov(memw[ds, bx + 0xc0], dx);             /* mov [bx+0xc0], dx */
            ii(0x5f3a, 3);    add(dx, 4);                               /* add dx, 0x4 */
            ii(0x5f3d, 3);    add(bx, 8);                               /* add bx, 0x8 */
            ii(0x5f40, 2);    if(loop(0x5f26, -0x1c)) goto l_0x5f26;    /* loop 0x5f26 */
            ii(0x5f42, 3);    mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0x5f45, 3);    mov(dx, 0x4235);                          /* mov dx, 0x4235 */
            ii(0x5f48, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0x5f4a:
            ii(0x5f4a, 4);    mov(memw[ds, bx + 0xc0], dx);             /* mov [bx+0xc0], dx */
            ii(0x5f4e, 4);    add(dx, 0x1c);                            /* add dx, 0x1c */
            ii(0x5f52, 3);    add(bx, 8);                               /* add bx, 0x8 */
            ii(0x5f55, 2);    if(loop(0x5f4a, -0xd)) goto l_0x5f4a;     /* loop 0x5f4a */
            ii(0x5f57, 6);    mov(memw[ds, 0x128], 0x1fb8);             /* mov word [0x128], 0x1fb8 */
            ii(0x5f5d, 6);    mov(memw[ds, 0x1b8], 0x84);               /* mov word [0x1b8], 0x84 */
            ii(0x5f63, 6);    mov(memw[ds, 0x1c0], 0xc80);              /* mov word [0x1c0], 0xc80 */
            ii(0x5f69, 6);    mov(memw[ds, 0x1c2], 0x18);               /* mov word [0x1c2], 0x18 */
            ii(0x5f6f, 6);    mov(memw[ds, 0x1c8], 0xc9e);              /* mov word [0x1c8], 0xc9e */
            ii(0x5f75, 6);    mov(memw[ds, 0x1d8], 0x5eb);              /* mov word [0x1d8], 0x5eb */
            ii(0x5f7b, 6);    mov(memw[ds, 0x248], 0x44d6);             /* mov word [0x248], 0x44d6 */
            ii(0x5f81, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x5f86, 2);    if(jnz(0x5f94, 0xc)) goto l_0x5f94;       /* jnz 0x5f94 */
            ii(0x5f88, 6);    mov(memw[ds, 0x3f8], 0x2c83);             /* mov word [0x3f8], 0x2c83 */
            ii(0x5f8e, 6);    mov(memw[ds, 0x3fa], 0x18);               /* mov word [0x3fa], 0x18 */
        l_0x5f94:
            ii(0x5f94, 3);    call(0x7e31, 0x1e9a);                     /* call 0x7e31 */
            ii(0x5f97, 5);    test(memb[ds, 0x47], 1);                  /* test byte [0x47], 0x1 */
            ii(0x5f9c, 2);    if(jz(0x5fc6, 0x28)) goto l_0x5fc6;       /* jz 0x5fc6 */
            ii(0x5f9e, 6);    mov(memw[ds, 0x170], 0x4fa);              /* mov word [0x170], 0x4fa */
            ii(0x5fa4, 6);    mov(memw[ds, 0x1b0], 0xc7c);              /* mov word [0x1b0], 0xc7c */
            ii(0x5faa, 6);    mov(memw[ds, 0x1b2], 0x18);               /* mov word [0x1b2], 0x18 */
            ii(0x5fb0, 4);    mov(bl, memb[ds, 0x51]);                  /* mov bl, [0x51] */
            ii(0x5fb4, 2);    or(bl, bl);                               /* or bl, bl */
            ii(0x5fb6, 2);    if(jz(0x5fc6, 0xe)) goto l_0x5fc6;        /* jz 0x5fc6 */
            ii(0x5fb8, 3);    add(bl, 5);                               /* add bl, 0x5 */
            ii(0x5fbb, 2);    xor(bh, bh);                              /* xor bh, bh */
            ii(0x5fbd, 3);    shl(bx, 3);                               /* shl bx, 0x3 */
            ii(0x5fc0, 6);    mov(memw[ds, bx + 0xc0], 0x556);          /* mov word [bx+0xc0], 0x556 */
        l_0x5fc6:
            ii(0x5fc6, 5);    cmp(memb[ds, 0x3e], 0);                   /* cmp byte [0x3e], 0x0 */
            ii(0x5fcb, 2);    if(jz(0x5ff5, 0x28)) goto l_0x5ff5;       /* jz 0x5ff5 */
            ii(0x5fcd, 2);    fninit();                                 /* fninit */
            ii(0x5fcf, 4);    mov(bx, memw[ds, 0xf82]);                 /* mov bx, [0xf82] */
            ii(0x5fd3, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x5fd5, 2);    if(jz(0x5fd9, 2)) goto l_0x5fd9;          /* jz 0x5fd9 */
            ii(0x5fd7, 2);    fnsave(memw[ds, bx]);                     /* fnsave [bx] */
        l_0x5fd9:
            ii(0x5fd9, 6);    mov(memb[cs, 0x92c], 0x9b);               /* mov byte [cs:0x92c], 0x9b */
            ii(0x5fdf, 6);    mov(memb[cs, 0x931], 0x9b);               /* mov byte [cs:0x931], 0x9b */
            ii(0x5fe5, 3);    mov(al, memb[ds, 0x2e]);                  /* mov al, [0x2e] */
            ii(0x5fe8, 2);    or(al, al);                               /* or al, al */
            ii(0x5fea, 2);    if(jz(0x5ff2, 6)) goto l_0x5ff2;          /* jz 0x5ff2 */
            ii(0x5fec, 2);    cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x5fee, 2);    if(jz(0x5ff2, 2)) goto l_0x5ff2;          /* jz 0x5ff2 */
            ii(0x5ff0, 2);    clts();                                   /* clts */
        l_0x5ff2:
            ii(0x5ff2, 1);    wait();                                   /* wait */
            ii(0x5ff3, 2);    fnsetpm();                                /* fnsetpm */
        l_0x5ff5:
            ii(0x5ff5, 1);    ret();                                    /* ret */
        }
    }
}
