using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ac5c2efa-29d6-448d-bb3b-3373eec08eff")]
        public void Method_0000_6470()
        {
            ii(0x6470, 1);    pushw(bp);                                /* push bp */
            ii(0x6471, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x6473, 1);    pushw(si);                                /* push si */
            ii(0x6474, 1);    pushw(di);                                /* push di */
            ii(0x6475, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x6478, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x647a, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x647d, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x6480, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x6483, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x6486, 3);    mov(di, memw_a16[ds, di + 0xa]);          /* mov di, [di+0xa] */
            ii(0x6489, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x648b, 1);    pushw(di);                                /* push di */
            ii(0x648c, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x648f, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x6491, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x6494, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x6497, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x649a, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x649d, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x64a0, 2);    if(jbw(0x64a6, 0x4)) goto l_0x64a6;       /* jb 0x64a6 */
            ii(0x64a2, 2);    xor(si, si);                              /* xor si, si */
            ii(0x64a4, 2);    jmpw(0x64ae, 0x8); goto l_0x64ae;         /* jmp 0x64ae */
        l_0x64a6:
            ii(0x64a6, 3);    callw(0x657e, 0xd5);                      /* call 0x657e */
            ii(0x64a9, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x64ac, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x64ae:
            ii(0x64ae, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x64b1, 1);    popw(di);                                 /* pop di */
            ii(0x64b2, 1);    popw(si);                                 /* pop si */
            ii(0x64b3, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x64b5, 1);    popw(bp);                                 /* pop bp */
            ii(0x64b6, 1);    retw(); return;                           /* ret */
        }
    }
}
