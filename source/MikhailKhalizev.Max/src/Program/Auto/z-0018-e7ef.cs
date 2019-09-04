using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e7ef-27cc41d6")]
        public void Method_0018_e7ef()
        {
            ii(0x18_e7ef, 4); mov(memw[es, di + 36], dx);               /* mov [es:di+0x24], dx */
            ii(0x18_e7f3, 4); mov(ax, memw_a32[ds, esi + 36]);          /* mov ax, [esi+0x24] */
            ii(0x18_e7f7, 1); stosw();                                  /* stosw */
            ii(0x18_e7f8, 4); mov(ax, memw_a32[ds, esi + 34]);          /* mov ax, [esi+0x22] */
            ii(0x18_e7fc, 1); stosw();                                  /* stosw */
            ii(0x18_e7fd, 1); xchg(cx, ax);                             /* xchg cx, ax */
            ii(0x18_e7fe, 6); mov(ecx, 8);                              /* mov ecx, 0x8 */
            ii(0x18_e804, 4); movzx(edi, di);                           /* movzx edi, di */
            ii(0x18_e808, 4); rep_a32(() => movsd_a32());               /* a32 rep movsd */
            ii(0x18_e80c, 2); xchg(cx, ax);                             /* a32 xchg cx, ax */
            ii(0x18_e80e, 1); push(ss);                                 /* push ss */
            ii(0x18_e80f, 1); pop(ds);                                  /* pop ds */
            ii(0x18_e810, 4); mov(bp, memw[ds, 0x996]);                 /* mov bp, [0x996] */
            ii(0x18_e814, 5); jmp_far_abs(0x18, 0x1fa6);                /* jmp word 0x18:0x1fa6 */
        }
    }
}
