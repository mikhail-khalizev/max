using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ba7cb87c-8f44-4404-bfa4-3b864186973b")]
        public void Method_0014_e7ef()
        {
            ii(0x14_e7ef, 4); mov(memw_a16[es, di + 0x24], dx);         /* mov [es:di+0x24], dx */
            ii(0x14_e7f3, 4); mov(ax, memw_a32[ds, esi + 0x24]);        /* mov ax, [esi+0x24] */
            ii(0x14_e7f7, 1); stosw_a16();                              /* stosw */
            ii(0x14_e7f8, 4); mov(ax, memw_a32[ds, esi + 0x22]);        /* mov ax, [esi+0x22] */
            ii(0x14_e7fc, 1); stosw_a16();                              /* stosw */
            ii(0x14_e7fd, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x14_e7fe, 6); mov(ecx, 0x8);                            /* mov ecx, 0x8 */
            ii(0x14_e804, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x14_e808, 4); rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0x14_e80c, 2); xchg(cx, ax);                             /* a32 xchg cx, ax */
            ii(0x14_e80e, 1); pushw(ss);                                /* push ss */
            ii(0x14_e80f, 1); popw(ds);                                 /* pop ds */
            ii(0x14_e810, 4); mov(bp, memw_a16[ds, 0x996]);             /* mov bp, [0x996] */
            ii(0x14_e814, 5); if(jmpw_far_abs(0x18, 0x1fa6)) return;    /* jmp word 0x18:0x1fa6 */
        }
    }
}
