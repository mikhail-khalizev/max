using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_cbcd-d96da15d")]
        public void Method_0019_cbcd()
        {
            ii(0x19_cbcd, 4); enter(4, 0);                              /* enter 0x4, 0x0 */
            ii(0x19_cbd1, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_cbd3, 3); mov(memw[ss, bp - 2], ax);                /* mov [bp-0x2], ax */
            ii(0x19_cbd6, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_cbd9, 3); mov(ax, memw[ss, bp + 0x10]);             /* mov ax, [bp+0x10] */
            ii(0x19_cbdc, 3); or(ax, memw[ss, bp + 0xe]);               /* or ax, [bp+0xe] */
            ii(0x19_cbdf, 2); if(jz(0x19_cbff, 0x1e)) goto l_0x19_cbff; /* jz 0xcbff */
            ii(0x19_cbe1, 3); push(memw[ss, bp + 0xc]);                 /* push word [bp+0xc] */
            ii(0x19_cbe4, 3); push(memw[ss, bp + 0xa]);                 /* push word [bp+0xa] */
            ii(0x19_cbe7, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_cbea, 3); push(memw[ss, bp + 0x10]);                /* push word [bp+0x10] */
            ii(0x19_cbed, 3); push(memw[ss, bp + 0xe]);                 /* push word [bp+0xe] */
            ii(0x19_cbf0, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_cbf3, 3); push(memw[ss, bp + 4]);                   /* push word [bp+0x4] */
            ii(0x19_cbf6, 3); call(0x19_c4e3, -0x716);                  /* call 0xc4e3 */
            ii(0x19_cbf9, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x19_cbfc, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
        l_0x19_cbff:
            ii(0x19_cbff, 3); mov(ax, memw[ss, bp + 4]);                /* mov ax, [bp+0x4] */
            ii(0x19_cc02, 3); mov(dx, memw[ss, bp + 6]);                /* mov dx, [bp+0x6] */
            ii(0x19_cc05, 3); cmp(memw[ss, bp - 4], ax);                /* cmp [bp-0x4], ax */
            ii(0x19_cc08, 2); if(jnz(0x19_cc13, 9)) goto l_0x19_cc13;   /* jnz 0xcc13 */
            ii(0x19_cc0a, 3); cmp(memw[ss, bp - 2], dx);                /* cmp [bp-0x2], dx */
            ii(0x19_cc0d, 2); if(jnz(0x19_cc13, 4)) goto l_0x19_cc13;   /* jnz 0xcc13 */
            ii(0x19_cc0f, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_cc11, 2); jmp(0x19_cc16, 3); goto l_0x19_cc16;      /* jmp 0xcc16 */
        l_0x19_cc13:
            ii(0x19_cc13, 3); mov(ax, 0x519);                           /* mov ax, 0x519 */
        l_0x19_cc16:
            ii(0x19_cc16, 1); leave();                                  /* leave */
            ii(0x19_cc17, 3); ret(0xe);                                 /* ret 0xe */
        }
    }
}
