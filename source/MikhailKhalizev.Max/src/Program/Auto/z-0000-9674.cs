using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x9674-7c9191a6")]
        public void Method_0000_9674()
        {
            ii(0x9674, 1);    push(bp);                                 /* push bp */
            ii(0x9675, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x9677, 1);    push(si);                                 /* push si */
            ii(0x9678, 1);    push(di);                                 /* push di */
            ii(0x9679, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0x967c, 4);    mov(memb[ss, bp - 10], 0xcd);             /* mov byte [bp-0xa], 0xcd */
            ii(0x9680, 3);    mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x9683, 3);    mov(memb[ss, bp - 9], al);                /* mov [bp-0x9], al */
            ii(0x9686, 2);    cmp(al, 0x25);                            /* cmp al, 0x25 */
            ii(0x9688, 2);    if(jz(0x9694, 0xa)) goto l_0x9694;        /* jz 0x9694 */
            ii(0x968a, 2);    cmp(al, 0x26);                            /* cmp al, 0x26 */
            ii(0x968c, 2);    if(jz(0x9694, 6)) goto l_0x9694;          /* jz 0x9694 */
            ii(0x968e, 4);    mov(memb[ss, bp - 8], 0xcb);              /* mov byte [bp-0x8], 0xcb */
            ii(0x9692, 2);    jmp(0x96a0, 0xc); goto l_0x96a0;          /* jmp 0x96a0 */
        l_0x9694:
            ii(0x9694, 4);    mov(memb[ss, bp - 6], 0xcb);              /* mov byte [bp-0x6], 0xcb */
            ii(0x9698, 4);    mov(memb[ss, bp - 7], 0x44);              /* mov byte [bp-0x7], 0x44 */
            ii(0x969c, 4);    mov(memb[ss, bp - 8], 0x44);              /* mov byte [bp-0x8], 0x44 */
        l_0x96a0:
            ii(0x96a0, 3);    mov(memw[ss, bp - 12], ss);               /* mov [bp-0xc], ss */
            ii(0x96a3, 3);    lea(ax, memw[ss, bp - 10]);               /* lea ax, [bp-0xa] */
            ii(0x96a6, 3);    mov(memw[ss, bp - 14], ax);               /* mov [bp-0xe], ax */
            ii(0x96a9, 3);    mov(di, memw[ss, bp + 6]);                /* mov di, [bp+0x6] */
            ii(0x96ac, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x96ae, 3);    mov(bx, memw[ds, di + 2]);                /* mov bx, [di+0x2] */
            ii(0x96b1, 3);    mov(cx, memw[ds, di + 4]);                /* mov cx, [di+0x4] */
            ii(0x96b4, 3);    mov(dx, memw[ds, di + 6]);                /* mov dx, [di+0x6] */
            ii(0x96b7, 3);    mov(si, memw[ds, di + 8]);                /* mov si, [di+0x8] */
            ii(0x96ba, 3);    mov(di, memw[ds, di + 10]);               /* mov di, [di+0xa] */
            ii(0x96bd, 1);    push(bp);                                 /* push bp */
            ii(0x96be, 3);    call_far_ind(memw[ss, bp - 14]);          /* call far word [bp-0xe] */
            ii(0x96c1, 1);    pop(bp);                                  /* pop bp */
            ii(0x96c2, 1);    cld();                                    /* cld */
            ii(0x96c3, 1);    push(di);                                 /* push di */
            ii(0x96c4, 3);    mov(di, memw[ss, bp + 8]);                /* mov di, [bp+0x8] */
            ii(0x96c7, 2);    mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0x96c9, 3);    mov(memw[ds, di + 2], bx);                /* mov [di+0x2], bx */
            ii(0x96cc, 3);    mov(memw[ds, di + 4], cx);                /* mov [di+0x4], cx */
            ii(0x96cf, 3);    mov(memw[ds, di + 6], dx);                /* mov [di+0x6], dx */
            ii(0x96d2, 3);    mov(memw[ds, di + 8], si);                /* mov [di+0x8], si */
            ii(0x96d5, 3);    pop(memw[ds, di + 10]);                   /* pop word [di+0xa] */
            ii(0x96d8, 2);    if(jb(0x96de, 4)) goto l_0x96de;          /* jb 0x96de */
            ii(0x96da, 2);    xor(si, si);                              /* xor si, si */
            ii(0x96dc, 2);    jmp(0x96e6, 8); goto l_0x96e6;            /* jmp 0x96e6 */
        l_0x96de:
            ii(0x96de, 3);    call(0x5dce, -0x3913);                    /* call 0x5dce */
            ii(0x96e1, 3);    mov(si, 1);                               /* mov si, 0x1 */
            ii(0x96e4, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
        l_0x96e6:
            ii(0x96e6, 3);    mov(memw[ds, di + 12], si);               /* mov [di+0xc], si */
            ii(0x96e9, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x96ec, 1);    pop(di);                                  /* pop di */
            ii(0x96ed, 1);    pop(si);                                  /* pop si */
            ii(0x96ee, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x96f0, 1);    pop(bp);                                  /* pop bp */
            ii(0x96f1, 1);    ret();                                    /* ret */
        }
    }
}
