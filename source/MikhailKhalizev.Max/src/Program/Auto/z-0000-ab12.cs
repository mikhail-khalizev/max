using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xab12-4672337b")]
        public void Method_0000_ab12()
        {
            ii(0xab12, 3);    mov(ax, 0x1600);                          /* mov ax, 0x1600 */
            ii(0xab15, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xab17, 2);    test(al, 0x7f);                           /* test al, 0x7f */
            ii(0xab19, 2);    if(jzw(0xab6e, 0x53)) goto l_0xab6e;      /* jz 0xab6e */
            ii(0xab1b, 2);    cmp(al, 0x3);                             /* cmp al, 0x3 */
            ii(0xab1d, 2);    if(jnzw(0xab6e, 0x4f)) goto l_0xab6e;     /* jnz 0xab6e */
            ii(0xab1f, 3);    cmp(ah, 0xa);                             /* cmp ah, 0xa */
            ii(0xab22, 2);    if(jaew(0xab6e, 0x4a)) goto l_0xab6e;     /* jae 0xab6e */
            ii(0xab24, 3);    mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0xab27, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xab29, 2);    cmp(al, -0x80 /* 0x80 */);                /* cmp al, 0x80 */
            ii(0xab2b, 2);    if(jnzw(0xab6f, 0x42)) goto l_0xab6f;     /* jnz 0xab6f */
            ii(0xab2d, 1);    pushw(es);                                /* push es */
            ii(0xab2e, 1);    pushw(bp);                                /* push bp */
            ii(0xab2f, 3);    mov(ax, 0x4310);                          /* mov ax, 0x4310 */
            ii(0xab32, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xab34, 1);    pushw(es);                                /* push es */
            ii(0xab35, 1);    pushw(bx);                                /* push bx */
            ii(0xab36, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xab38, 2);    mov(ah, 0x9);                             /* mov ah, 0x9 */
            ii(0xab3a, 3);    mov(dx, 0x40);                            /* mov dx, 0x40 */
            ii(0xab3d, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xab40, 1);    dec(ax);                                  /* dec ax */
            ii(0xab41, 2);    if(jnzw(0xab6f, 0x2c)) goto l_0xab6f;     /* jnz 0xab6f */
            ii(0xab43, 1);    pushw(ax);                                /* push ax */
            ii(0xab44, 1);    pushw(ax);                                /* push ax */
            ii(0xab45, 1);    pushw(dx);                                /* push dx */
            ii(0xab46, 1);    pushw(ds);                                /* push ds */
            ii(0xab47, 1);    pushw(ax);                                /* push ax */
            ii(0xab48, 1);    pushw(ax);                                /* push ax */
            ii(0xab49, 2);    pushw(0x1);                               /* push 0x1 */
            ii(0xab4b, 1);    pushw(ax);                                /* push ax */
            ii(0xab4c, 2);    mov(si, sp);                              /* mov si, sp */
            ii(0xab4e, 2);    mov(ah, 0xb);                             /* mov ah, 0xb */
            ii(0xab50, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xab53, 1);    dec(ax);                                  /* dec ax */
            ii(0xab54, 2);    if(jnzw(0xab6f, 0x19)) goto l_0xab6f;     /* jnz 0xab6f */
            ii(0xab56, 3);    mov(ax, 0x1681);                          /* mov ax, 0x1681 */
            ii(0xab59, 2);    @int(0x2f);                               /* int 0x2f */
            ii(0xab5b, 4);    mov(memb_a16[cs, 0x6d4b], al);            /* mov [cs:0x6d4b], al */
            ii(0xab5f, 2);    mov(ah, 0xb);                             /* mov ah, 0xb */
            ii(0xab61, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xab64, 2);    mov(ah, 0xa);                             /* mov ah, 0xa */
            ii(0xab66, 3);    callw_a16_far_ind(ss, bp + 0);            /* call far word [bp] */
            ii(0xab69, 3);    add(sp, 0x14);                            /* add sp, 0x14 */
            ii(0xab6c, 1);    popw(bp);                                 /* pop bp */
            ii(0xab6d, 1);    popw(es);                                 /* pop es */
        l_0xab6e:
            ii(0xab6e, 1);    retw(); return;                           /* ret */
        l_0xab6f:
            ii(0xab6f, 2);    pushw(0x21);                              /* push 0x21 */
            ii(0xab71, 3);    callw(0x589d, -0x52d7);                   /* call 0x589d */
            ii(0xab74, 1);    pushw(ds);                                /* push ds */
            ii(0xab75, 5);    mov(ds, memw_a16[cs, 0x208e]);            /* mov ds, [cs:0x208e] */
            ii(0xab7a, 4);    inc(memb_a16[ds, 0xc45]);                 /* inc byte [0xc45] */
            ii(0xab7e, 1);    popw(ds);                                 /* pop ds */
            ii(0xab7f, 2);    iretd();                                  /* iretd */
        }
    }
}
