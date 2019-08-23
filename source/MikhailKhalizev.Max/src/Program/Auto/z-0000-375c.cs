using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x375c-e66f9d3f")]
        public void Method_0000_375c()
        {
            ii(0x375c, 2);    xor(bx, bx);                              /* xor bx, bx */
            ii(0x375e, 3);    mov(dx, 0);                               /* mov dx, 0x0 */
            ii(0x3761, 3);    mov(cx, 0x100);                           /* mov cx, 0x100 */
            ii(0x3764, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0x3766:
            ii(0x3766, 4);    mov(memw[ds, bx + 0xc6], ax);             /* mov [bx+0xc6], ax */
            ii(0x376a, 6);    mov(memw[ds, bx + 0xc4], 0x8e00);         /* mov word [bx+0xc4], 0x8e00 */
            ii(0x3770, 6);    mov(memw[ds, bx + 0xc2], 0x70);           /* mov word [bx+0xc2], 0x70 */
            ii(0x3776, 4);    mov(memw[ds, bx + 0xc0], dx);             /* mov [bx+0xc0], dx */
            ii(0x377a, 3);    add(dx, 0x4);                             /* add dx, 0x4 */
            ii(0x377d, 3);    add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x3780, 2);    if(loop(0x3766, -0x1c)) goto l_0x3766;    /* loop 0x3766 */
            ii(0x3782, 3);    mov(cx, 0x11);                            /* mov cx, 0x11 */
            ii(0x3785, 3);    mov(dx, 0x4235);                          /* mov dx, 0x4235 */
            ii(0x3788, 2);    xor(bx, bx);                              /* xor bx, bx */
        l_0x378a:
            ii(0x378a, 4);    mov(memw[ds, bx + 0xc0], dx);             /* mov [bx+0xc0], dx */
            ii(0x378e, 4);    add(dx, 0x1c);                            /* add dx, 0x1c */
            ii(0x3792, 3);    add(bx, 0x8);                             /* add bx, 0x8 */
            ii(0x3795, 2);    if(loop(0x378a, -0xd)) goto l_0x378a;     /* loop 0x378a */
            ii(0x3797, 6);    mov(memw[ds, 0x128], 0x1fb8);             /* mov word [0x128], 0x1fb8 */
            ii(0x379d, 6);    mov(memw[ds, 0x1b8], 0x84);               /* mov word [0x1b8], 0x84 */
            ii(0x37a3, 6);    mov(memw[ds, 0x1c0], 0xc80);              /* mov word [0x1c0], 0xc80 */
            ii(0x37a9, 6);    mov(memw[ds, 0x1c2], 0x18);               /* mov word [0x1c2], 0x18 */
            ii(0x37af, 6);    mov(memw[ds, 0x1c8], 0xc9e);              /* mov word [0x1c8], 0xc9e */
            ii(0x37b5, 6);    mov(memw[ds, 0x1d8], 0x5eb);              /* mov word [0x1d8], 0x5eb */
            ii(0x37bb, 6);    mov(memw[ds, 0x248], 0x44d6);             /* mov word [0x248], 0x44d6 */
            ii(0x37c1, 5);    cmp(memb[ds, 0x2e], 0xb);                 /* cmp byte [0x2e], 0xb */
            ii(0x37c6, 2);    if(jnz(0x37d4, 0xc)) goto l_0x37d4;       /* jnz 0x37d4 */
            ii(0x37c8, 6);    mov(memw[ds, 0x3f8], 0x2c83);             /* mov word [0x3f8], 0x2c83 */
            ii(0x37ce, 6);    mov(memw[ds, 0x3fa], 0x18);               /* mov word [0x3fa], 0x18 */
        l_0x37d4:
            ii(0x37d4, 3);    call(0x5671, 0x1e9a);                     /* call 0x5671 */
            ii(0x37d7, 5);    test(memb[ds, 0x47], 0x1);                /* test byte [0x47], 0x1 */
            ii(0x37dc, 2);    if(jz(0x3806, 0x28)) goto l_0x3806;       /* jz 0x3806 */
            ii(0x37de, 6);    mov(memw[ds, 0x170], 0x4fa);              /* mov word [0x170], 0x4fa */
            ii(0x37e4, 6);    mov(memw[ds, 0x1b0], 0xc7c);              /* mov word [0x1b0], 0xc7c */
            ii(0x37ea, 6);    mov(memw[ds, 0x1b2], 0x18);               /* mov word [0x1b2], 0x18 */
            ii(0x37f0, 4);    mov(bl, memb[ds, 0x51]);                  /* mov bl, [0x51] */
            ii(0x37f4, 2);    or(bl, bl);                               /* or bl, bl */
            ii(0x37f6, 2);    if(jz(0x3806, 0xe)) goto l_0x3806;        /* jz 0x3806 */
            ii(0x37f8, 3);    add(bl, 0x5);                             /* add bl, 0x5 */
            ii(0x37fb, 2);    xor(bh, bh);                              /* xor bh, bh */
            ii(0x37fd, 3);    shl(bx, 0x3);                             /* shl bx, 0x3 */
            ii(0x3800, 6);    mov(memw[ds, bx + 0xc0], 0x556);          /* mov word [bx+0xc0], 0x556 */
        l_0x3806:
            ii(0x3806, 5);    cmp(memb[ds, 0x3e], 0);                   /* cmp byte [0x3e], 0x0 */
            ii(0x380b, 2);    if(jz(0x3835, 0x28)) goto l_0x3835;       /* jz 0x3835 */
            ii(0x380d, 2);    fninit();                                 /* fninit */
            ii(0x380f, 4);    mov(bx, memw[ds, 0xf82]);                 /* mov bx, [0xf82] */
            ii(0x3813, 2);    or(bx, bx);                               /* or bx, bx */
            ii(0x3815, 2);    if(jz(0x3819, 0x2)) goto l_0x3819;        /* jz 0x3819 */
            ii(0x3817, 2);    fnsave(memw[ds, bx]);                     /* fnsave [bx] */
        l_0x3819:
            ii(0x3819, 6);    mov(memb[cs, 0x92c], 0x9b);               /* mov byte [cs:0x92c], 0x9b */
            ii(0x381f, 6);    mov(memb[cs, 0x931], 0x9b);               /* mov byte [cs:0x931], 0x9b */
            ii(0x3825, 3);    mov(al, memb[ds, 0x2e]);                  /* mov al, [0x2e] */
            ii(0x3828, 2);    or(al, al);                               /* or al, al */
            ii(0x382a, 2);    if(jz(0x3832, 0x6)) goto l_0x3832;        /* jz 0x3832 */
            ii(0x382c, 2);    cmp(al, 0xb);                             /* cmp al, 0xb */
            ii(0x382e, 2);    if(jz(0x3832, 0x2)) goto l_0x3832;        /* jz 0x3832 */
            ii(0x3830, 2);    clts();                                   /* clts */
        l_0x3832:
            ii(0x3832, 1);    wait();                                   /* wait */
            ii(0x3833, 2);    fnsetpm();                                /* fnsetpm */
        l_0x3835:
            ii(0x3835, 1);    ret();                                    /* ret */
        }
    }
}
