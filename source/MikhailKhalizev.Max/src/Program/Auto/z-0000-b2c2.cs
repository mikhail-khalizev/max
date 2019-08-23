using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xb2c2-4672337b")]
        public void Method_0000_b2c2()
        {
            ii(0xb2c2, 3);    mov(ax, 0x1600);                          /* mov ax, 0x1600 */
            ii(0xb2c5, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xb2c7, 2);    test(al, 0x7f);                           /* test al, 0x7f */
            ii(0xb2c9, 2);    if(jzw(0xb31e, 0x53)) goto l_0xb31e;      /* jz 0xb31e */
            ii(0xb2cb, 2);    cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0xb2cd, 2);    if(jnzw(0xb31e, 0x4f)) goto l_0xb31e;     /* jnz 0xb31e */
            ii(0xb2cf, 3);    cmp(ah, 0xa);                             /* cmp ah, 0xa */
            ii(0xb2d2, 2);    if(jaew(0xb31e, 0x4a)) goto l_0xb31e;     /* jae 0xb31e */
            ii(0xb2d4, 3);    mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0xb2d7, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xb2d9, 2);    cmp(al, -0x80 /* 0x80 */);                /* cmp al, 0x80 */
            ii(0xb2db, 2);    if(jnzw(0xb31f, 0x42)) goto l_0xb31f;     /* jnz 0xb31f */
            ii(0xb2dd, 1);    pushw(es);                                /* push es */
            ii(0xb2de, 1);    pushw(bp);                                /* push bp */
            ii(0xb2df, 3);    mov(ax, 0x4310);                          /* mov ax, 0x4310 */
            ii(0xb2e2, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xb2e4, 1);    pushw(es);                                /* push es */
            ii(0xb2e5, 1);    pushw(bx);                                /* push bx */
            ii(0xb2e6, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xb2e8, 2);    mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0xb2ea, 3);    mov(dx, 0x40);                            /* mov dx, 0x40 */
            ii(0xb2ed, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xb2f0, 1);    dec(ax);                                  /* dec ax */
            ii(0xb2f1, 2);    if(jnzw(0xb31f, 0x2c)) goto l_0xb31f;     /* jnz 0xb31f */
            ii(0xb2f3, 1);    pushw(ax);                                /* push ax */
            ii(0xb2f4, 1);    pushw(ax);                                /* push ax */
            ii(0xb2f5, 1);    pushw(dx);                                /* push dx */
            ii(0xb2f6, 1);    pushw(ds);                                /* push ds */
            ii(0xb2f7, 1);    pushw(ax);                                /* push ax */
            ii(0xb2f8, 1);    pushw(ax);                                /* push ax */
            ii(0xb2f9, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0xb2fb, 1);    pushw(ax);                                /* push ax */
            ii(0xb2fc, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xb2fe, 2);    mov(ah, 0xb);                             /* mov ah, 0xb */
            ii(0xb300, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xb303, 1);    dec(ax);                                  /* dec ax */
            ii(0xb304, 2);    if(jnzw(0xb31f, 0x19)) goto l_0xb31f;     /* jnz 0xb31f */
            ii(0xb306, 3);    mov(ax, 0x1681);                          /* mov ax, 0x1681 */
            ii(0xb309, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xb30b, 4);    mov(memb_a16[cs, 0x6d4b], al);            /* mov [cs:0x6d4b], al */
            ii(0xb30f, 2);    mov(ah, 0xb);                             /* mov ah, 0xb */
            ii(0xb311, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xb314, 2);    mov(ah, 0xa);                             /* mov ah, 0xa */
            ii(0xb316, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xb319, 3);    add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0xb31c, 1);    popw(bp);                                 /* pop bp */
            ii(0xb31d, 1);    popw(es);                                 /* pop es */
        l_0xb31e:
            ii(0xb31e, 1);    retw(); return;                           /* ret */
        l_0xb31f:
            ii(0xb31f, 2);    pushw(0x21);                              /* push 0x21 */
            ii(0xb321, 3);    callw(0x604d, -0x52d7);                   /* call 0x604d */
            ii(0xb324, 1);    pushw(ds);                                /* push ds */
            ii(0xb325, 5);    mov(ds, memw_a16[cs, 0x208e]);            /* mov ds, [cs:0x208e] */
            ii(0xb32a, 4);    inc(memb_a16[ds, 0xc45]);                 /* inc byte [0xc45] */
            ii(0xb32e, 1);    popw(ds);                                 /* pop ds */
            ii(0xb32f, 2);    iretd();                                  /* iretd */
        }
    }
}
