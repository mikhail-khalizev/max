using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x63dc-815c226a")]
        public void Method_0000_63dc()
        {
            ii(0x63dc, 1);    push(bp);                                 /* push bp */
            ii(0x63dd, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x63df, 1);    push(si);                                 /* push si */
            ii(0x63e0, 1);    push(di);                                 /* push di */
            ii(0x63e1, 1);    push(ds);                                 /* push ds */
            ii(0x63e2, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0x63e5, 4);    mov(memb[ss, bp - 0xc], 0xcd);            /* mov byte [bp-0xc], 0xcd */
            ii(0x63e9, 3);    mov(ax, memw[ss, bp + 0x4]);              /* mov ax, [bp+0x4] */
            ii(0x63ec, 3);    mov(memb[ss, bp - 0xb], al);              /* mov [bp-0xb], al */
            ii(0x63ef, 2);    cmp(al, 0x25);                            /* cmp al, 0x25 */
            ii(0x63f1, 2);    if(jz(0x63fd, 0xa)) goto l_0x63fd;        /* jz 0x63fd */
            ii(0x63f3, 2);    cmp(al, 0x26);                            /* cmp al, 0x26 */
            ii(0x63f5, 2);    if(jz(0x63fd, 0x6)) goto l_0x63fd;        /* jz 0x63fd */
            ii(0x63f7, 4);    mov(memb[ss, bp - 0xa], 0xcb);            /* mov byte [bp-0xa], 0xcb */
            ii(0x63fb, 2);    jmp(0x6409, 0xc); goto l_0x6409;          /* jmp 0x6409 */
        l_0x63fd:
            ii(0x63fd, 4);    mov(memb[ss, bp - 0x8], 0xcb);            /* mov byte [bp-0x8], 0xcb */
            ii(0x6401, 4);    mov(memb[ss, bp - 0x9], 0x44);            /* mov byte [bp-0x9], 0x44 */
            ii(0x6405, 4);    mov(memb[ss, bp - 0xa], 0x44);            /* mov byte [bp-0xa], 0x44 */
        l_0x6409:
            ii(0x6409, 3);    mov(memw[ss, bp - 0xe], ss);              /* mov [bp-0xe], ss */
            ii(0x640c, 3);    lea(ax, memw[ss, bp - 0xc]);              /* lea ax, [bp-0xc] */
            ii(0x640f, 3);    mov(memw[ss, bp - 0x10], ax);             /* mov [bp-0x10], ax */
            ii(0x6412, 3);    mov(di, memw[ss, bp + 0x6]);              /* mov di, [bp+0x6] */
            ii(0x6415, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x6417, 3);    mov(bx, memw[ds, di + 0x2]);              /* mov bx, [di+0x2] */
            ii(0x641a, 3);    mov(cx, memw[ds, di + 0x4]);              /* mov cx, [di+0x4] */
            ii(0x641d, 3);    mov(dx, memw[ds, di + 0x6]);              /* mov dx, [di+0x6] */
            ii(0x6420, 3);    mov(si, memw[ds, di + 0x8]);              /* mov si, [di+0x8] */
            ii(0x6423, 3);    push(memw[ds, di + 0xa]);                 /* push word [di+0xa] */
            ii(0x6426, 3);    mov(di, memw[ss, bp + 0xa]);              /* mov di, [bp+0xa] */
            ii(0x6429, 2);    mov(es, memw[ds, di]);                    /* mov es, [di] */
            ii(0x642b, 3);    mov(ds, memw[ds, di + 0x6]);              /* mov ds, [di+0x6] */
            ii(0x642e, 1);    pop(di);                                  /* pop di */
            ii(0x642f, 1);    push(bp);                                 /* push bp */
            ii(0x6430, 3);    call_far_ind(ss, bp - 0x10);              /* call far word [bp-0x10] */
            ii(0x6433, 1);    pop(bp);                                  /* pop bp */
            ii(0x6434, 1);    cld();                                    /* cld */
            ii(0x6435, 1);    push(di);                                 /* push di */
            ii(0x6436, 1);    push(ds);                                 /* push ds */
            ii(0x6437, 1);    push(ss);                                 /* push ss */
            ii(0x6438, 1);    pop(ds);                                  /* pop ds */
            ii(0x6439, 3);    mov(di, memw[ss, bp + 0xa]);              /* mov di, [bp+0xa] */
            ii(0x643c, 2);    mov(memw[ds, di], es);                    /* mov [di], es */
            ii(0x643e, 3);    pop(memw[ds, di + 0x6]);                  /* pop word [di+0x6] */
            ii(0x6441, 3);    mov(di, memw[ss, bp + 0x8]);              /* mov di, [bp+0x8] */
            ii(0x6444, 2);    mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0x6446, 3);    mov(memw[ds, di + 0x2], bx);              /* mov [di+0x2], bx */
            ii(0x6449, 3);    mov(memw[ds, di + 0x4], cx);              /* mov [di+0x4], cx */
            ii(0x644c, 3);    mov(memw[ds, di + 0x6], dx);              /* mov [di+0x6], dx */
            ii(0x644f, 3);    mov(memw[ds, di + 0x8], si);              /* mov [di+0x8], si */
            ii(0x6452, 3);    pop(memw[ds, di + 0xa]);                  /* pop word [di+0xa] */
            ii(0x6455, 2);    if(jb(0x645b, 0x4)) goto l_0x645b;        /* jb 0x645b */
            ii(0x6457, 2);    xor(si, si);                              /* xor si, si */
            ii(0x6459, 2);    jmp(0x6463, 0x8); goto l_0x6463;          /* jmp 0x6463 */
        l_0x645b:
            ii(0x645b, 3);    call(0x657e, 0x120);                      /* call 0x657e */
            ii(0x645e, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x6461, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
        l_0x6463:
            ii(0x6463, 3);    mov(memw[ds, di + 0xc], si);              /* mov [di+0xc], si */
            ii(0x6466, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x6469, 1);    pop(ds);                                  /* pop ds */
            ii(0x646a, 1);    pop(di);                                  /* pop di */
            ii(0x646b, 1);    pop(si);                                  /* pop si */
            ii(0x646c, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x646e, 1);    pop(bp);                                  /* pop bp */
            ii(0x646f, 1);    ret();                                    /* ret */
        }
    }
}
