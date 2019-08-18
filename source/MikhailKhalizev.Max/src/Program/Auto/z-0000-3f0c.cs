using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x3f0c-21a3e12f")]
        public void Method_0000_3f0c()
        {
            ii(0x3f0c, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x3f0e, 3);    mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x3f11, 3);    mov(cx, 0x100);                           /* mov cx, 0x100 */
            ii(0x3f14, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0x3f16:
            ii(0x3f16, 4);    mov(memw_a16[ds, bx + 0xc6], ax);         /* mov [bx+0xc6], ax */
            ii(0x3f1a, 6);    mov(memw_a16[ds, bx + 0xc4], 0x8e00);     /* mov word [bx+0xc4], 0x8e00 */
            ii(0x3f20, 6);    mov(memw_a16[ds, bx + 0xc2], 0x70);       /* mov word [bx+0xc2], 0x70 */
            ii(0x3f26, 4);    mov(memw_a16[ds, bx + 0xc0], dx);         /* mov [bx+0xc0], dx */
            ii(0x3f2a, 3);    add(dx, 0x4);                             /* add dx, 0x4 */
            ii(0x3f2d, 3);    add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x3f30, 2);    if(loopw_a16(0x3f16, -0x1c)) goto l_0x3f16; /* loop 0x3f16 */
            ii(0x3f32, 3);    mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0x3f35, 3);    mov(dx, 0x4235);                          /* mov dx, 0x4235 */
            ii(0x3f38, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0x3f3a:
            ii(0x3f3a, 4);    mov(memw_a16[ds, bx + 0xc0], dx);         /* mov [bx+0xc0], dx */
            ii(0x3f3e, 4);    add(dx, 0x1c);                            /* add dx, 0x1c */
            ii(0x3f42, 3);    add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x3f45, 2);    if(loopw_a16(0x3f3a, -0xd)) goto l_0x3f3a; /* loop 0x3f3a */
            ii(0x3f47, 6);    mov(memw_a16[ds, 0x128], 0x1fb8);         /* mov word [0x128], 0x1fb8 */
            ii(0x3f4d, 6);    mov(memw_a16[ds, 0x1b8], 0x84);           /* mov word [0x1b8], 0x84 */
            ii(0x3f53, 6);    mov(memw_a16[ds, 0x1c0], 0xc80);          /* mov word [0x1c0], 0xc80 */
            ii(0x3f59, 6);    mov(memw_a16[ds, 0x1c2], 0x18);           /* mov word [0x1c2], 0x18 */
            ii(0x3f5f, 6);    mov(memw_a16[ds, 0x1c8], 0xc9e);          /* mov word [0x1c8], 0xc9e */
            ii(0x3f65, 6);    mov(memw_a16[ds, 0x1d8], 0x5eb);          /* mov word [0x1d8], 0x5eb */
            ii(0x3f6b, 6);    mov(memw_a16[ds, 0x248], 0x44d6);         /* mov word [0x248], 0x44d6 */
            ii(0x3f71, 5);    cmp(memb_a16[ds, 0x2e], 0xb);             /* cmp byte [0x2e], 0xb */
            ii(0x3f76, 2);    if(jnzw(0x3f84, 0xc)) goto l_0x3f84;      /* jnz 0x3f84 */
            ii(0x3f78, 6);    mov(memw_a16[ds, 0x3f8], 0x2c83);         /* mov word [0x3f8], 0x2c83 */
            ii(0x3f7e, 6);    mov(memw_a16[ds, 0x3fa], 0x18);           /* mov word [0x3fa], 0x18 */
        l_0x3f84:
            ii(0x3f84, 3);    callw(0x5e21, 0x1e9a);                    /* call 0x5e21 */
            ii(0x3f87, 5);    test(memb_a16[ds, 0x47], 0x1);            /* test byte [0x47], 0x1 */
            ii(0x3f8c, 2);    if(jzw(0x3fb6, 0x28)) goto l_0x3fb6;      /* jz 0x3fb6 */
            ii(0x3f8e, 6);    mov(memw_a16[ds, 0x170], 0x4fa);          /* mov word [0x170], 0x4fa */
            ii(0x3f94, 6);    mov(memw_a16[ds, 0x1b0], 0xc7c);          /* mov word [0x1b0], 0xc7c */
            ii(0x3f9a, 6);    mov(memw_a16[ds, 0x1b2], 0x18);           /* mov word [0x1b2], 0x18 */
            ii(0x3fa0, 4);    mov(bl, memb_a16[ds, 0x51]);              /* mov bl, [0x51] */
            ii(0x3fa4, 2);    or(bl, bl);                               /* or bl, bl */
            ii(0x3fa6, 2);    if(jzw(0x3fb6, 0xe)) goto l_0x3fb6;       /* jz 0x3fb6 */
            ii(0x3fa8, 3);    add(bl, 0x5);                             /* add bl, 0x5 */
            ii(0x3fab, 2);    xor(bh, bh);                              /* xor bh, bh */
            ii(0x3fad, 3);    shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x3fb0, 6);    mov(memw_a16[ds, bx + 0xc0], 0x556);      /* mov word [bx+0xc0], 0x556 */
        l_0x3fb6:
            ii(0x3fb6, 5);    cmp(memb_a16[ds, 0x3e], 0);               /* cmp byte [0x3e], 0x0 */
            ii(0x3fbb, 2);    if(jzw(0x3fe5, 0x28)) goto l_0x3fe5;      /* jz 0x3fe5 */
            ii(0x3fbd, 2);    fninit();                                 /* fninit */
            ii(0x3fbf, 4);    mov(bx, memw_a16[ds, 0xf82]);             /* mov bx, [0xf82] */
            ii(0x3fc3, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x3fc5, 2);    if(jzw(0x3fc9, 0x2)) goto l_0x3fc9;       /* jz 0x3fc9 */
            ii(0x3fc7, 2);    fnsavew_a16(ds, bx);                      /* fnsave [bx] */
        l_0x3fc9:
            ii(0x3fc9, 6);    mov(memb_a16[cs, 0x92c], 0x9b);           /* mov byte [cs:0x92c], 0x9b */
            ii(0x3fcf, 6);    mov(memb_a16[cs, 0x931], 0x9b);           /* mov byte [cs:0x931], 0x9b */
            ii(0x3fd5, 3);    mov(al, memb_a16[ds, 0x2e]);              /* mov al, [0x2e] */
            ii(0x3fd8, 2);    or(al, al);                               /* or al, al */
            ii(0x3fda, 2);    if(jzw(0x3fe2, 0x6)) goto l_0x3fe2;       /* jz 0x3fe2 */
            ii(0x3fdc, 2);    cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x3fde, 2);    if(jzw(0x3fe2, 0x2)) goto l_0x3fe2;       /* jz 0x3fe2 */
            ii(0x3fe0, 2);    clts();                                   /* clts */
        l_0x3fe2:
            ii(0x3fe2, 1);    wait();                                   /* wait */
            ii(0x3fe3, 2);    fnsetpm();                                /* fnsetpm */
        l_0x3fe5:
            ii(0x3fe5, 1);    retw(); return;                           /* ret */
        }
    }
}
