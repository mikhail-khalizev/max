using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a06bc02e-8a01-48b2-8a23-ac44ae868356")]
        public void Method_0000_9674()
        {
            ii(0x9674, 1);    pushw(bp);                                /* push bp */
            ii(0x9675, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9677, 1);    pushw(si);                                /* push si */
            ii(0x9678, 1);    pushw(di);                                /* push di */
            ii(0x9679, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0x967c, 4);    mov(memb_a16[ss, bp - 0xa], 0xcd);        /* mov byte [bp-0xa], 0xcd */
            ii(0x9680, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x9683, 3);    mov(memb_a16[ss, bp - 0x9], al);          /* mov [bp-0x9], al */
            ii(0x9686, 2);    cmp(al, 0x25);                            /* cmp al, 0x25 */
            ii(0x9688, 2);    if(jzw(0x9694, 0xa)) goto l_0x9694;       /* jz 0x9694 */
            ii(0x968a, 2);    cmp(al, 0x26);                            /* cmp al, 0x26 */
            ii(0x968c, 2);    if(jzw(0x9694, 0x6)) goto l_0x9694;       /* jz 0x9694 */
            ii(0x968e, 4);    mov(memb_a16[ss, bp - 0x8], 0xcb);        /* mov byte [bp-0x8], 0xcb */
            ii(0x9692, 2);    goto l_0x96a0;                            /* jmp 0x96a0 */
        l_0x9694:
            ii(0x9694, 4);    mov(memb_a16[ss, bp - 0x6], 0xcb);        /* mov byte [bp-0x6], 0xcb */
            ii(0x9698, 4);    mov(memb_a16[ss, bp - 0x7], 0x44);        /* mov byte [bp-0x7], 0x44 */
            ii(0x969c, 4);    mov(memb_a16[ss, bp - 0x8], 0x44);        /* mov byte [bp-0x8], 0x44 */
        l_0x96a0:
            ii(0x96a0, 3);    mov(memw_a16[ss, bp - 0xc], ss);          /* mov [bp-0xc], ss */
            ii(0x96a3, 3);    lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x96a6, 3);    mov(memw_a16[ss, bp - 0xe], ax);          /* mov [bp-0xe], ax */
            ii(0x96a9, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x96ac, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x96ae, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x96b1, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x96b4, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x96b7, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x96ba, 3);    mov(di, memw_a16[ds, di + 0xa]);          /* mov di, [di+0xa] */
            ii(0x96bd, 1);    pushw(bp);                                /* push bp */
            ii(0x96be, 3);    callw_a16_far_ind(ss, bp - 0xe);          /* call far word [bp-0xe] */
            ii(0x96c1, 1);    popw(bp);                                 /* pop bp */
            ii(0x96c2, 1);    cld();                                    /* cld */
            ii(0x96c3, 1);    pushw(di);                                /* push di */
            ii(0x96c4, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x96c7, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x96c9, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x96cc, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x96cf, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x96d2, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x96d5, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x96d8, 2);    if(jbw(0x96de, 0x4)) goto l_0x96de;       /* jb 0x96de */
            ii(0x96da, 2);    xor(si, si);                              /* xor si, si */
            ii(0x96dc, 2);    goto l_0x96e6;                            /* jmp 0x96e6 */
        l_0x96de:
            ii(0x96de, 3);    callw(0x5dce, -0x3913);                   /* call 0x5dce */
            ii(0x96e1, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x96e4, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x96e6:
            ii(0x96e6, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x96e9, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x96ec, 1);    popw(di);                                 /* pop di */
            ii(0x96ed, 1);    popw(si);                                 /* pop si */
            ii(0x96ee, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x96f0, 1);    popw(bp);                                 /* pop bp */
            ii(0x96f1, 1);    retw();                                   /* ret */
        }
    }
}
