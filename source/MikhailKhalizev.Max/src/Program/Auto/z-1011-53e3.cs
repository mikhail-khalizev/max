using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_53e3-626823b4")]
        public void Method_1011_53e3()
        {
            ii(0x1011_53e3, 5); pushd(0x14);                            /* push 0x14 */
            ii(0x1011_53e8, 5); calld(Definitions.sys_check_available_stack_size, 0x5_0965); /* call 0x10165d52 */
            ii(0x1011_53ed, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_53ee, 1); pushd(esi);                             /* push esi */
            ii(0x1011_53ef, 1); pushd(edi);                             /* push edi */
            ii(0x1011_53f0, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_53f1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_53f3, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_53f9, 3); mov(eax, memd_a32[ss, ebp + 0x14]);     /* mov eax, [ebp+0x14] */
            ii(0x1011_53fc, 5); calld(Definitions.sys_free, 0x5_5cc0);  /* call 0x1016b0c1 */
            ii(0x1011_5401, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_5402, 1); popd(edi);                              /* pop edi */
            ii(0x1011_5403, 1); popd(esi);                              /* pop esi */
            ii(0x1011_5404, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_5405, 1); retd(); return;                         /* ret */
        }
    }
}
