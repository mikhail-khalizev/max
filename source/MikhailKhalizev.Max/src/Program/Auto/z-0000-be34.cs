using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0xbe34-7c9191a6")]
        public void Method_0000_be34()
        {
            ii(0xbe34, 1);    push(bp);                                 /* push bp */
            ii(0xbe35, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0xbe37, 1);    push(si);                                 /* push si */
            ii(0xbe38, 1);    push(di);                                 /* push di */
            ii(0xbe39, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0xbe3c, 4);    mov(memb[ss, bp - 0xa], 0xcd);            /* mov byte [bp-0xa], 0xcd */
            ii(0xbe40, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0xbe43, 3);    mov(memb[ss, bp - 0x9], al);              /* mov [bp-0x9], al */
            ii(0xbe46, 2);    cmp(al, 0x25);                            /* cmp al, 0x25 */
            ii(0xbe48, 2);    if(jz(0xbe54, 0xa)) goto l_0xbe54;        /* jz 0xbe54 */
            ii(0xbe4a, 2);    cmp(al, 0x26);                            /* cmp al, 0x26 */
            ii(0xbe4c, 2);    if(jz(0xbe54, 0x6)) goto l_0xbe54;        /* jz 0xbe54 */
            ii(0xbe4e, 4);    mov(memb[ss, bp - 0x8], 0xcb);            /* mov byte [bp-0x8], 0xcb */
            ii(0xbe52, 2);    jmp(0xbe60, 0xc); goto l_0xbe60;          /* jmp 0xbe60 */
        l_0xbe54:
            ii(0xbe54, 4);    mov(memb[ss, bp - 0x6], 0xcb);            /* mov byte [bp-0x6], 0xcb */
            ii(0xbe58, 4);    mov(memb[ss, bp - 0x7], 0x44);            /* mov byte [bp-0x7], 0x44 */
            ii(0xbe5c, 4);    mov(memb[ss, bp - 0x8], 0x44);            /* mov byte [bp-0x8], 0x44 */
        l_0xbe60:
            ii(0xbe60, 3);    mov(memw[ss, bp - 0xc], ss);              /* mov [bp-0xc], ss */
            ii(0xbe63, 3);    lea(ax, memw[ss, bp - 0xa]);              /* lea ax, [bp-0xa] */
            ii(0xbe66, 3);    mov(memw[ss, bp - 0xe], ax);              /* mov [bp-0xe], ax */
            ii(0xbe69, 3);    mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0xbe6c, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0xbe6e, 3);    mov(bx, memw[ds, di + 0x2]);              /* mov bx, [di+0x2] */
            ii(0xbe71, 3);    mov(cx, memw[ds, di + 0x4]);              /* mov cx, [di+0x4] */
            ii(0xbe74, 3);    mov(dx, memw[ds, di + 0x6]);              /* mov dx, [di+0x6] */
            ii(0xbe77, 3);    mov(si, memw[ds, di + 0x8]);              /* mov si, [di+0x8] */
            ii(0xbe7a, 3);    mov(di, memw[ds, di + 0xa]);              /* mov di, [di+0xa] */
            ii(0xbe7d, 1);    push(bp);                                 /* push bp */
            ii(0xbe7e, 3);    call_far_ind(memw[ss, bp - 0xe]);         /* call far word [bp-0xe] */
            ii(0xbe81, 1);    pop(bp);                                  /* pop bp */
            ii(0xbe82, 1);    cld();                                    /* cld */
            ii(0xbe83, 1);    push(di);                                 /* push di */
            ii(0xbe84, 3);    mov(di, memw[ss, bp + 0x8]);              /* mov di, [bp+0x8] */
            ii(0xbe87, 2);    mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0xbe89, 3);    mov(memw[ds, di + 0x2], bx);              /* mov [di+0x2], bx */
            ii(0xbe8c, 3);    mov(memw[ds, di + 0x4], cx);              /* mov [di+0x4], cx */
            ii(0xbe8f, 3);    mov(memw[ds, di + 0x6], dx);              /* mov [di+0x6], dx */
            ii(0xbe92, 3);    mov(memw[ds, di + 0x8], si);              /* mov [di+0x8], si */
            ii(0xbe95, 3);    pop(memw[ds, di + 0xa]);                  /* pop word [di+0xa] */
            ii(0xbe98, 2);    if(jb(0xbe9e, 0x4)) goto l_0xbe9e;        /* jb 0xbe9e */
            ii(0xbe9a, 2);    xor(si, si);                              /* xor si, si */
            ii(0xbe9c, 2);    jmp(0xbea6, 0x8); goto l_0xbea6;          /* jmp 0xbea6 */
        l_0xbe9e:
            ii(0xbe9e, 3);    call(0x858e, -0x3913);                    /* call 0x858e */
            ii(0xbea1, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0xbea4, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
        l_0xbea6:
            ii(0xbea6, 3);    mov(memw[ds, di + 0xc], si);              /* mov [di+0xc], si */
            ii(0xbea9, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0xbeac, 1);    pop(di);                                  /* pop di */
            ii(0xbead, 1);    pop(si);                                  /* pop si */
            ii(0xbeae, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0xbeb0, 1);    pop(bp);                                  /* pop bp */
            ii(0xbeb1, 1);    ret();                                    /* ret */
        }
    }
}
