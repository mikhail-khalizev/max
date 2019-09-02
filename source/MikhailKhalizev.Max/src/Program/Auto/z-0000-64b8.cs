using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x64b8-43d08df7")]
        public void Method_0000_64b8()
        {
            ii(0x64b8, 1);    push(bp);                                 /* push bp */
            ii(0x64b9, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x64bb, 1);    push(si);                                 /* push si */
            ii(0x64bc, 1);    push(di);                                 /* push di */
            ii(0x64bd, 3);    mov(di, memw[ss, bp + 4]);                /* mov di, [bp+0x4] */
            ii(0x64c0, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
            ii(0x64c2, 3);    mov(bx, memw[ds, di + 2]);                /* mov bx, [di+0x2] */
            ii(0x64c5, 3);    mov(cx, memw[ds, di + 4]);                /* mov cx, [di+0x4] */
            ii(0x64c8, 3);    mov(dx, memw[ds, di + 6]);                /* mov dx, [di+0x6] */
            ii(0x64cb, 3);    mov(si, memw[ds, di + 8]);                /* mov si, [di+0x8] */
            ii(0x64ce, 3);    push(memw[ds, di + 0xa]);                 /* push word [di+0xa] */
            ii(0x64d1, 3);    mov(di, memw[ss, bp + 8]);                /* mov di, [bp+0x8] */
            ii(0x64d4, 2);    mov(es, memw[ds, di]);                    /* mov es, [di] */
            ii(0x64d6, 3);    mov(ds, memw[ds, di + 6]);                /* mov ds, [di+0x6] */
            ii(0x64d9, 1);    pop(di);                                  /* pop di */
            ii(0x64da, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x64dc, 1);    push(di);                                 /* push di */
            ii(0x64dd, 1);    push(ds);                                 /* push ds */
            ii(0x64de, 2);    mov(di, ss);                              /* mov di, ss */
            ii(0x64e0, 2);    mov(ds, di);                              /* mov ds, di */
            ii(0x64e2, 3);    mov(di, memw[ss, bp + 8]);                /* mov di, [bp+0x8] */
            ii(0x64e5, 2);    mov(memw[ds, di], es);                    /* mov [di], es */
            ii(0x64e7, 3);    pop(memw[ds, di + 6]);                    /* pop word [di+0x6] */
            ii(0x64ea, 3);    mov(di, memw[ss, bp + 6]);                /* mov di, [bp+0x6] */
            ii(0x64ed, 2);    mov(memw[ds, di], ax);                    /* mov [di], ax */
            ii(0x64ef, 3);    mov(memw[ds, di + 2], bx);                /* mov [di+0x2], bx */
            ii(0x64f2, 3);    mov(memw[ds, di + 4], cx);                /* mov [di+0x4], cx */
            ii(0x64f5, 3);    mov(memw[ds, di + 6], dx);                /* mov [di+0x6], dx */
            ii(0x64f8, 3);    mov(memw[ds, di + 8], si);                /* mov [di+0x8], si */
            ii(0x64fb, 3);    pop(memw[ds, di + 0xa]);                  /* pop word [di+0xa] */
            ii(0x64fe, 2);    if(jb(0x6504, 4)) goto l_0x6504;          /* jb 0x6504 */
            ii(0x6500, 2);    xor(si, si);                              /* xor si, si */
            ii(0x6502, 2);    jmp(0x650c, 8); goto l_0x650c;            /* jmp 0x650c */
        l_0x6504:
            ii(0x6504, 3);    call(0x657e, 0x77);                       /* call 0x657e */
            ii(0x6507, 3);    mov(si, 1);                               /* mov si, 0x1 */
            ii(0x650a, 2);    mov(ax, memw[ds, di]);                    /* mov ax, [di] */
        l_0x650c:
            ii(0x650c, 3);    mov(memw[ds, di + 0xc], si);              /* mov [di+0xc], si */
            ii(0x650f, 1);    pop(di);                                  /* pop di */
            ii(0x6510, 1);    pop(si);                                  /* pop si */
            ii(0x6511, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x6513, 1);    pop(bp);                                  /* pop bp */
            ii(0x6514, 1);    ret();                                    /* ret */
        }
    }
}
