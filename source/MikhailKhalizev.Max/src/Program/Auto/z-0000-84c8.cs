using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x84c8-43d08df7")]
        public void Method_0000_84c8()
        {
            ii(0x84c8, 1);    push(bp);                                 /* push bp */
            ii(0x84c9, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x84cb, 1);    push(si);                                 /* push si */
            ii(0x84cc, 1);    push(di);                                 /* push di */
            ii(0x84cd, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x84d0, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x84d2, 3);    mov(bx, memw[ds, di + 2]);                /* mov bx, [di+0x2] */
            ii(0x84d5, 3);    mov(cx, memw[ds, di + 4]);                /* mov cx, [di+0x4] */
            ii(0x84d8, 3);    mov(dx, memw[ds, di + 6]);                /* mov dx, [di+0x6] */
            ii(0x84db, 3);    mov(si, memw[ds, di + 8]);                /* mov si, [di+0x8] */
            ii(0x84de, 3);    push(memw[ds, di + 10]);                  /* push word [di+0xa] */
            ii(0x84e1, 3);    mov(di, memw[ss, bp + 8]);                /* mov di, [bp+0x8] */
            ii(0x84e4, 2);    mov(es, memw[ds, di]);                    /* mov es, [di] */
            ii(0x84e6, 3);    mov(ds, memw[ds, di + 6]);                /* mov ds, [di+0x6] */
            ii(0x84e9, 1);    pop(di);                                  /* pop di */
            ii(0x84ea, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x84ec, 1);    push(di);                                 /* push di */
            ii(0x84ed, 1);    push(ds);                                 /* push ds */
            ii(0x84ee, 2);    mov(di, ss);                              /* mov di, ss */
            ii(0x84f0, 2);    mov(ds, di);                              /* mov ds, di */
            ii(0x84f2, 3);    mov(di, memw[ss, bp + 8]);                /* mov di, [bp+0x8] */
            ii(0x84f5, 2);    mov(memw[ds, di], es);                    /* mov [di], es */
            ii(0x84f7, 3);    pop(memw[ds, di + 6]);                    /* pop word [di+0x6] */
            ii(0x84fa, 3);    mov(di, memw[ss, bp + 6]);                /* mov di, [bp+0x6] */
            ii(0x84fd, 2);    mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0x84ff, 3);    mov(memw[ds, di + 2], bx);                /* mov [di+0x2], bx */
            ii(0x8502, 3);    mov(memw[ds, di + 4], cx);                /* mov [di+0x4], cx */
            ii(0x8505, 3);    mov(memw[ds, di + 6], dx);                /* mov [di+0x6], dx */
            ii(0x8508, 3);    mov(memw[ds, di + 8], si);                /* mov [di+0x8], si */
            ii(0x850b, 3);    pop(memw[ds, di + 10]);                   /* pop word [di+0xa] */
            ii(0x850e, 2);    if(jb(0x8514, 4)) goto l_0x8514;          /* jb 0x8514 */
            ii(0x8510, 2);    xor(si, si);                              /* xor si, si */
            ii(0x8512, 2);    jmp(0x851c, 8); goto l_0x851c;            /* jmp 0x851c */
        l_0x8514:
            ii(0x8514, 3);    call(0x858e, 0x77);                       /* call 0x858e */
            ii(0x8517, 3);    mov(si, 1);                               /* mov si, 0x1 */
            ii(0x851a, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
        l_0x851c:
            ii(0x851c, 3);    mov(memw[ds, di + 12], si);               /* mov [di+0xc], si */
            ii(0x851f, 1);    pop(di);                                  /* pop di */
            ii(0x8520, 1);    pop(si);                                  /* pop si */
            ii(0x8521, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x8523, 1);    pop(bp);                                  /* pop bp */
            ii(0x8524, 1);    ret();                                    /* ret */
        }
    }
}
