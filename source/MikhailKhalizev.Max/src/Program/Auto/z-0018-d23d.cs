using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("210cda6f-cbbb-45a1-a5ff-70b78ea8c940")]
        public void Method_0018_d23d()
        {
            ii(0x18_d23d, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x18_d241, 1); pushw(si);                                /* push si */
            ii(0x18_d242, 2); pushw(0x1);                               /* push 0x1 */
            ii(0x18_d244, 3); callw(0x18_dcef, 0xaa8);                  /* call 0xdcef */
            ii(0x18_d247, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d248, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x18_d24a, 2); or(si, si);                               /* or si, si */
            ii(0x18_d24c, 2); if(jzw(0x18_d278, 0x2a)) goto l_0x18_d278; /* jz 0xd278 */
            ii(0x18_d24e, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x18_d251, 1); dec(ax);                                  /* dec ax */
            ii(0x18_d252, 3); mov(memw_a16[ss, bp - 0x6], ax);          /* mov [bp-0x6], ax */
            ii(0x18_d255, 3); mov(ax, memw_a16[ss, bp + 0x4]);          /* mov ax, [bp+0x4] */
            ii(0x18_d258, 3); mov(dx, memw_a16[ss, bp + 0x6]);          /* mov dx, [bp+0x6] */
            ii(0x18_d25b, 3); mov(memw_a16[ss, bp - 0xa], ax);          /* mov [bp-0xa], ax */
            ii(0x18_d25e, 3); mov(memw_a16[ss, bp - 0x8], dx);          /* mov [bp-0x8], dx */
            ii(0x18_d261, 4); mov(memb_a16[ss, bp - 0x2], 0x92);        /* mov byte [bp-0x2], 0x92 */
            ii(0x18_d265, 5); mov(memw_a16[ss, bp - 0x4], 0);           /* mov word [bp-0x4], 0x0 */
            ii(0x18_d26a, 4); mov(memb_a16[ss, bp - 0x1], 0);           /* mov byte [bp-0x1], 0x0 */
            ii(0x18_d26e, 3); lea(ax, bp - 0xa);                        /* lea ax, [bp-0xa] */
            ii(0x18_d271, 1); pushw(ax);                                /* push ax */
            ii(0x18_d272, 1); pushw(si);                                /* push si */
            ii(0x18_d273, 3); callw(0x18_dc28, 0x9b2);                  /* call 0xdc28 */
            ii(0x18_d276, 1); popw(bx);                                 /* pop bx */
            ii(0x18_d277, 1); popw(bx);                                 /* pop bx */
        l_0x18_d278:
            ii(0x18_d278, 2); mov(ax, si);                              /* mov ax, si */
            ii(0x18_d27a, 1); popw(si);                                 /* pop si */
            ii(0x18_d27b, 1); leavew();                                 /* leave */
            ii(0x18_d27c, 1); retw(); return;                           /* ret */
        }
    }
}
