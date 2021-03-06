using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_e948-18296075")]
        public void /* sys */ Method_1018_e948()
        {
            ii(0x1018_e948, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x1018_e94a, 2);  mov(al, memb[ds, esi]);               /* mov al, [esi] */
            ii(0x1018_e94c, 1);  inc(esi);                             /* inc esi */
            ii(0x1018_e94d, 8);  mov(ax, memw[ds, eax * 2 + 0x101b_eed0]);/* mov ax, [eax*2+0x101beed0] */
            ii(0x1018_e955, 2);  neg(al);                              /* neg al */
            ii(0x1018_e957, 2);  neg(ah);                              /* neg ah */
            ii(0x1018_e959, 2);  jmp_func(0x1018_e935, -0x26);         /* jmp 0x1018e935 */
        }
    }
}
