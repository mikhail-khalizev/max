using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ff50b3b0-f817-428d-ab54-6c5b00d3e96c")]
        public void Method_100d_6f2d()
        {
            ii(0x100d_6f2d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100d_6f32, 5); calld(Definitions.sys_check_available_stack_size, 0x8ee1b); /* call 0x10165d52 */
            ii(0x100d_6f37, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6f38, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6f39, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6f3a, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6f3b, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6f3c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6f3e, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_6f44, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6f47, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6f4a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_6f4d, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100d_6f50, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100d_6f54, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6f56, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6f57, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6f58, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6f59, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6f5a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6f5b, 1); retd(); return;                         /* ret */
        }
    }
}
