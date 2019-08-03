using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("82db2e76-eb9a-4fdd-bb51-773aa98be35e")]
        public void Method_0000_5d08()
        {
            ii(0x5d08, 1);    pushw(bp);                                /* push bp */
            ii(0x5d09, 2);    mov(bp, sp);                              /* mov bp, sp */
            ii(0x5d0b, 1);    pushw(si);                                /* push si */
            ii(0x5d0c, 1);    pushw(di);                                /* push di */
            ii(0x5d0d, 3);    mov(di, memw_a16[ss, bp + 0x4]);          /* mov di, [bp+0x4] */
            ii(0x5d10, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
            ii(0x5d12, 3);    mov(bx, memw_a16[ds, di + 0x2]);          /* mov bx, [di+0x2] */
            ii(0x5d15, 3);    mov(cx, memw_a16[ds, di + 0x4]);          /* mov cx, [di+0x4] */
            ii(0x5d18, 3);    mov(dx, memw_a16[ds, di + 0x6]);          /* mov dx, [di+0x6] */
            ii(0x5d1b, 3);    mov(si, memw_a16[ds, di + 0x8]);          /* mov si, [di+0x8] */
            ii(0x5d1e, 3);    pushw(memw_a16[ds, di + 0xa]);            /* push word [di+0xa] */
            ii(0x5d21, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x5d24, 2);    mov(es, memw_a16[ds, di]);                /* mov es, [di] */
            ii(0x5d26, 3);    mov(ds, memw_a16[ds, di + 0x6]);          /* mov ds, [di+0x6] */
            ii(0x5d29, 1);    popw(di);                                 /* pop di */
            ii(0x5d2a, 2);    @int(0x21);                               /* int 0x21 */
            ii(0x5d2c, 1);    pushw(di);                                /* push di */
            ii(0x5d2d, 1);    pushw(ds);                                /* push ds */
            ii(0x5d2e, 2);    mov(di, ss);                              /* mov di, ss */
            ii(0x5d30, 2);    mov(ds, di);                              /* mov ds, di */
            ii(0x5d32, 3);    mov(di, memw_a16[ss, bp + 0x8]);          /* mov di, [bp+0x8] */
            ii(0x5d35, 2);    mov(memw_a16[ds, di], es);                /* mov [di], es */
            ii(0x5d37, 3);    popw(memw_a16[ds, di + 0x6]);             /* pop word [di+0x6] */
            ii(0x5d3a, 3);    mov(di, memw_a16[ss, bp + 0x6]);          /* mov di, [bp+0x6] */
            ii(0x5d3d, 2);    mov(memw_a16[ds, di], ax);                /* mov [di], ax */
            ii(0x5d3f, 3);    mov(memw_a16[ds, di + 0x2], bx);          /* mov [di+0x2], bx */
            ii(0x5d42, 3);    mov(memw_a16[ds, di + 0x4], cx);          /* mov [di+0x4], cx */
            ii(0x5d45, 3);    mov(memw_a16[ds, di + 0x6], dx);          /* mov [di+0x6], dx */
            ii(0x5d48, 3);    mov(memw_a16[ds, di + 0x8], si);          /* mov [di+0x8], si */
            ii(0x5d4b, 3);    popw(memw_a16[ds, di + 0xa]);             /* pop word [di+0xa] */
            ii(0x5d4e, 2);    if(jbw(0x5d54, 0x4)) goto l_0x5d54;       /* jb 0x5d54 */
            ii(0x5d50, 2);    xor(si, si);                              /* xor si, si */
            ii(0x5d52, 2);    jmpw(0x5d5c, 0x8); goto l_0x5d5c;         /* jmp 0x5d5c */
        l_0x5d54:
            ii(0x5d54, 3);    callw(0x5dce, 0x77);                      /* call 0x5dce */
            ii(0x5d57, 3);    mov(si, 0x1);                             /* mov si, 0x1 */
            ii(0x5d5a, 2);    mov(ax, memw_a16[ds, di]);                /* mov ax, [di] */
        l_0x5d5c:
            ii(0x5d5c, 3);    mov(memw_a16[ds, di + 0xc], si);          /* mov [di+0xc], si */
            ii(0x5d5f, 1);    popw(di);                                 /* pop di */
            ii(0x5d60, 1);    popw(si);                                 /* pop si */
            ii(0x5d61, 2);    mov(sp, bp);                              /* mov sp, bp */
            ii(0x5d63, 1);    popw(bp);                                 /* pop bp */
            ii(0x5d64, 1);    retw(); return;                           /* ret */
        }
    }
}