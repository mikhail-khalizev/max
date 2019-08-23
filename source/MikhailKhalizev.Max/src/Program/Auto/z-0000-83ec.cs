using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x83ec-815c226a")]
        public void Method_0000_83ec()
        {
            ii(0x83ec, 1);    pushw(bp);                                /* push bp */
            ii(0x83ed, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x83ef, 1);    pushw(si);                                /* push si */
            ii(0x83f0, 1);    pushw(di);                                /* push di */
            ii(0x83f1, 1);    pushw(ds);                                /* push ds */
            ii(0x83f2, 3);    sub(sp, 0xa);                             /* sub sp, 0xa */
            ii(0x83f5, 4);    mov(memb_a16[ss, bp - 0xc], 0xcd);        /* mov byte [bp-0xc], 0xcd */
            ii(0x83f9, 3);    mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x83fc, 3);    mov(memb_a16[ss, bp - 0xb], al);          /* mov [bp-0xb], al */
            ii(0x83ff, 2);    cmp(al, 0x25);                            /* cmp al, 0x25 */
            ii(0x8401, 2);    if(jzw(0x840d, 0xa)) goto l_0x840d;       /* jz 0x840d */
            ii(0x8403, 2);    cmp(al, 0x26);                            /* cmp al, 0x26 */
            ii(0x8405, 2);    if(jzw(0x840d, 0x6)) goto l_0x840d;       /* jz 0x840d */
            ii(0x8407, 4);    mov(memb_a16[ss, bp - 0xa], 0xcb);        /* mov byte [bp-0xa], 0xcb */
            ii(0x840b, 2);    jmpw(0x8419, 0xc); goto l_0x8419;         /* jmp 0x8419 */
        l_0x840d:
            ii(0x840d, 4);    mov(memb_a16[ss, bp - 0x8], 0xcb);        /* mov byte [bp-0x8], 0xcb */
            ii(0x8411, 4);    mov(memb_a16[ss, bp - 0x9], 0x44);        /* mov byte [bp-0x9], 0x44 */
            ii(0x8415, 4);    mov(memb_a16[ss, bp - 0xa], 0x44);        /* mov byte [bp-0xa], 0x44 */
        l_0x8419:
            ii(0x8419, 3);    mov(memw_a16[ss, bp - 0xe], ss);          /* mov [bp-0xe], ss */
            ii(0x841c, 3);    lea(ax, bp - 0xc);                        /* lea ax, [bp-0xc] */
            ii(0x841f, 3);    mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x8422, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x8425, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x8427, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x842a, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x842d, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x8430, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x8433, 3);    pushw(memw_a16[ds, di + 0xa]);            /* push word [di+0xa] */
            ii(0x8436, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0x8439, 2);    mov(es, memw_a16[ds, di]);                /* mov es, [di] */
            ii(0x843b, 3);    mov(ds, memw_a16[ds, di + 0x6]);          /* mov ds, [di+0x6] */
            ii(0x843e, 1);    popw(di);                                 /* pop di */
            ii(0x843f, 1);    pushw(bp);                                /* push bp */
            ii(0x8440, 3);    callw_a16_far_ind(ss, bp - 0x10);         /* call far word [bp-0x10] */
            ii(0x8443, 1);    popw(bp);                                 /* pop bp */
            ii(0x8444, 1);    cld();                                    /* cld */
            ii(0x8445, 1);    pushw(di);                                /* push di */
            ii(0x8446, 1);    pushw(ds);                                /* push ds */
            ii(0x8447, 1);    pushw(ss);                                /* push ss */
            ii(0x8448, 1);    popw(ds);                                 /* pop ds */
            ii(0x8449, 3);    mov(di, memw_a16[ss, bp + 0xa]);          /* mov di, [bp+0xa] */
            ii(0x844c, 2);    mov(memw_a16[ds, di], es);                /* mov [di], es */
            ii(0x844e, 3);    popw(memw_a16[ds, di + 0x6]);             /* pop word [di+0x6] */
            ii(0x8451, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x8454, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x8456, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x8459, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x845c, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x845f, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x8462, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x8465, 2);    if(jbw(0x846b, 0x4)) goto l_0x846b;       /* jb 0x846b */
            ii(0x8467, 2);    xor(si, si);                              /* xor si, si */
            ii(0x8469, 2);    jmpw(0x8473, 0x8); goto l_0x8473;         /* jmp 0x8473 */
        l_0x846b:
            ii(0x846b, 3);    callw(0x858e, 0x120);                     /* call 0x858e */
            ii(0x846e, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x8471, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x8473:
            ii(0x8473, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x8476, 3);    add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x8479, 1);    popw(ds);                                 /* pop ds */
            ii(0x847a, 1);    popw(di);                                 /* pop di */
            ii(0x847b, 1);    popw(si);                                 /* pop si */
            ii(0x847c, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x847e, 1);    popw(bp);                                 /* pop bp */
            ii(0x847f, 1);    retw();                                   /* ret */
        }
    }
}
