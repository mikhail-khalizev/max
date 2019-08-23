using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_93d0-166102df")]
        public void Method_100e_93d0()
        {
            ii(0x100e_93d0, 5); push(0x20);                             /* push 0x20 */
            ii(0x100e_93d5, 5); call(Definitions.sys_check_available_stack_size, 0x7_c978); /* call 0x10165d52 */
            ii(0x100e_93da, 1); push(ebx);                              /* push ebx */
            ii(0x100e_93db, 1); push(ecx);                              /* push ecx */
            ii(0x100e_93dc, 1); push(edx);                              /* push edx */
            ii(0x100e_93dd, 1); push(esi);                              /* push esi */
            ii(0x100e_93de, 1); push(edi);                              /* push edi */
            ii(0x100e_93df, 1); push(ebp);                              /* push ebp */
            ii(0x100e_93e0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_93e2, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100e_93e8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_93eb, 4); movsx(ebx, memw[ss, ebp - 0x4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_93ef, 6); mov(edx, memd[ds, 0x101c_365c]);        /* mov edx, [0x101c365c] */
            ii(0x100e_93f5, 5); mov(eax, 0x101b_dec0);                  /* mov eax, 0x101bdec0 */
            ii(0x100e_93fa, 5); call(/* sys */ 0x1016_cb28, 0x8_3729);  /* call 0x1016cb28 */
            ii(0x100e_93ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_9401, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_9402, 1); pop(edi);                               /* pop edi */
            ii(0x100e_9403, 1); pop(esi);                               /* pop esi */
            ii(0x100e_9404, 1); pop(edx);                               /* pop edx */
            ii(0x100e_9405, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_9406, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_9407, 1); ret();                                  /* ret */
        }
    }
}
