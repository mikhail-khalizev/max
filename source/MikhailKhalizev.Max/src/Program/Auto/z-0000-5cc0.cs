using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c62a7e18-7769-491e-8473-838e233dcc0c")]
        public void Method_0000_5cc0()
        {
            ii(0x5cc0, 1);    pushw(bp);                                /* push bp */
            ii(0x5cc1, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5cc3, 1);    pushw(si);                                /* push si */
            ii(0x5cc4, 1);    pushw(di);                                /* push di */
            ii(0x5cc5, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x5cc8, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x5cca, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x5ccd, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x5cd0, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x5cd3, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x5cd6, 3);    mov(di, memw_a16[ds, di + 0xa]);          /* mov di, [di+0xa] */
            ii(0x5cd9, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x5cdb, 1);    pushw(di);                                /* push di */
            ii(0x5cdc, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x5cdf, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x5ce1, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x5ce4, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x5ce7, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x5cea, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x5ced, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x5cf0, 2);    if(jbw(0x5cf6, 0x4)) goto l_0x5cf6;       /* jb 0x5cf6 */
            ii(0x5cf2, 2);    xor(si, si);                              /* xor si, si */
            ii(0x5cf4, 2);    jmpw(0x5cfe, 0x8); goto l_0x5cfe;         /* jmp 0x5cfe */
        l_0x5cf6:
            ii(0x5cf6, 3);    callw(0x5dce, 0xd5);                      /* call 0x5dce */
            ii(0x5cf9, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x5cfc, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x5cfe:
            ii(0x5cfe, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x5d01, 1);    popw(di);                                 /* pop di */
            ii(0x5d02, 1);    popw(si);                                 /* pop si */
            ii(0x5d03, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5d05, 1);    popw(bp);                                 /* pop bp */
            ii(0x5d06, 1);    retw(); return;                           /* ret */
        }
    }
}
