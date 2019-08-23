using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x8480-74b7bb39")]
        public void Method_0000_8480()
        {
            ii(0x8480, 1);    pushw(bp);                                /* push bp */
            ii(0x8481, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x8483, 1);    pushw(si);                                /* push si */
            ii(0x8484, 1);    pushw(di);                                /* push di */
            ii(0x8485, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x8488, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x848a, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x848d, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x8490, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x8493, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x8496, 3);    mov(di, memw_a16[ds, di + 0xa]);          /* mov di, [di+0xa] */
            ii(0x8499, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x849b, 1);    pushw(di);                                /* push di */
            ii(0x849c, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x849f, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x84a1, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x84a4, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x84a7, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x84aa, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x84ad, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x84b0, 2);    if(jbw(0x84b6, 0x4)) goto l_0x84b6;       /* jb 0x84b6 */
            ii(0x84b2, 2);    xor(si, si);                              /* xor si, si */
            ii(0x84b4, 2);    jmpw(0x84be, 0x8); goto l_0x84be;         /* jmp 0x84be */
        l_0x84b6:
            ii(0x84b6, 3);    callw(0x858e, 0xd5);                      /* call 0x858e */
            ii(0x84b9, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x84bc, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x84be:
            ii(0x84be, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x84c1, 1);    popw(di);                                 /* pop di */
            ii(0x84c2, 1);    popw(si);                                 /* pop si */
            ii(0x84c3, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x84c5, 1);    popw(bp);                                 /* pop bp */
            ii(0x84c6, 1);    retw();                                   /* ret */
        }
    }
}
