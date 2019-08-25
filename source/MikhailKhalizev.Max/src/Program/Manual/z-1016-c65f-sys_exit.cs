using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_c65f-76283757")]
        public void /* sys */ sys_exit()
        {
            throw new InvalidOperationException("sys_exit.");

#if false
            ii(0x1016_c65f, 1); push(edx);                             /* push edx */
            ii(0x1016_c660, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_c662, 6); call_abs(memd_a32[ds, 0x101b_de80]);   /* call dword [0x101bde80] */ /* Вызов '0x1016_c65e'. */
            ii(0x1016_c668, 6); call_abs(memd_a32[ds, 0x101b_de84]);   /* call dword [0x101bde84] */ /* Вызов '0x1016_c65e'. */
            ii(0x1016_c66e, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_c670, 5); if(call_up(/* sys */ 0x1016_c677, 0x2)) return; /* call 0x1016c677 */
            ii(0x1016_c675, 1); pop(edx);                              /* pop edx */
            ii(0x1016_c676, 1); ret();                                 /* ret */
#endif
        }
    }
}
