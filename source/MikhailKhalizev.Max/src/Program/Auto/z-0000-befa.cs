using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b9530c54-7c8a-4b55-8787-72f761ab3512")]
        public void Method_0000_befa()
        {
            ii(0xbefa, 1);    pushw(bp);                                /* push bp */
            ii(0xbefb, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xbefd, 3);    sub(sp, 0x2);                             /* sub sp, 0x2 */
            ii(0xbf00, 1);    pushw(si);                                /* push si */
            ii(0xbf01, 1);    pushw(di);                                /* push di */
            ii(0xbf02, 1);    pushw(ds);                                /* push ds */
            ii(0xbf03, 1);    popw(es);                                 /* pop es */
            ii(0xbf04, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0xbf07, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xbf09, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0xbf0c, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0xbf0e, 2);    not(cx);                                  /* not cx */
            ii(0xbf10, 1);    dec(cx);                                  /* dec cx */
            ii(0xbf11, 2);    if(jcxzw(0xbf4d, 0x3a)) goto l_0xbf4d;    /* jcxz 0xbf4d */
            ii(0xbf13, 1);    dec(cx);                                  /* dec cx */
            ii(0xbf14, 3);    mov(memw_a16[ss, bp - 0x2], cx);          /* mov [bp-0x2], cx */
            ii(0xbf17, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0xbf1a, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0xbf1c, 2);    xor(ax, ax);                              /* xor ax, ax */
            ii(0xbf1e, 3);    mov(cx, 0xffff);                          /* mov cx, 0xffff */
            ii(0xbf21, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0xbf23, 2);    not(cx);                                  /* not cx */
            ii(0xbf25, 1);    dec(cx);                                  /* dec cx */
            ii(0xbf26, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xbf28, 3);    sub(dx, memw_a16[ss, bp - 0x2]);          /* sub dx, [bp-0x2] */
            ii(0xbf2b, 2);    if(jbew(0xbf52, 0x25)) goto l_0xbf52;     /* jbe 0xbf52 */
            ii(0xbf2d, 2);    mov(di, bx);                              /* mov di, bx */
        l_0xbf2f:
            ii(0xbf2f, 3);    mov(si, memw_a16[ss, bp + 0x6]);          /* mov si, [bp+0x6] */
            ii(0xbf32, 1);    lodsb_a16();                              /* lodsb */
            ii(0xbf33, 2);    mov(di, bx);                              /* mov di, bx */
            ii(0xbf35, 2);    mov(cx, dx);                              /* mov cx, dx */
            ii(0xbf37, 2);    repne_a16(() => scasb_a16());             /* repne scasb */
            ii(0xbf39, 2);    if(jnzw(0xbf52, 0x17)) goto l_0xbf52;     /* jnz 0xbf52 */
            ii(0xbf3b, 2);    mov(dx, cx);                              /* mov dx, cx */
            ii(0xbf3d, 2);    mov(bx, di);                              /* mov bx, di */
            ii(0xbf3f, 3);    mov(cx, memw_a16[ss, bp - 0x2]);          /* mov cx, [bp-0x2] */
            ii(0xbf42, 2);    if(jcxzw(0xbf48, 0x4)) goto l_0xbf48;     /* jcxz 0xbf48 */
            ii(0xbf44, 2);    repe_a16(() => cmpsb_a16());              /* repe cmpsb */
            ii(0xbf46, 2);    if(jnzw(0xbf2f, -0x19)) goto l_0xbf2f;    /* jnz 0xbf2f */
        l_0xbf48:
            ii(0xbf48, 3);    lea(ax, bx - 0x1);                        /* lea ax, [bx-0x1] */
            ii(0xbf4b, 2);    jmpw(0xbf54, 0x7); goto l_0xbf54;         /* jmp 0xbf54 */
        l_0xbf4d:
            ii(0xbf4d, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0xbf50, 2);    jmpw(0xbf54, 0x2); goto l_0xbf54;         /* jmp 0xbf54 */
        l_0xbf52:
            ii(0xbf52, 2);    xor(ax, ax);                              /* xor ax, ax */
        l_0xbf54:
            ii(0xbf54, 1);    popw(di);                                 /* pop di */
            ii(0xbf55, 1);    popw(si);                                 /* pop si */
            ii(0xbf56, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0xbf58, 1);    popw(bp);                                 /* pop bp */
            ii(0xbf59, 1);    retw(); return;                           /* ret */
        }
    }
}
