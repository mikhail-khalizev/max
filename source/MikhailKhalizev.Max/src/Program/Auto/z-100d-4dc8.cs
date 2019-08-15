using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("caf3d25a-9241-4dde-9909-37f30be9fefa")]
        public void Method_100d_4dc8()
        {
            ii(0x100d_4dc8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100d_4dcd, 5); calld(Definitions.sys_check_available_stack_size, 0x9_0f80); /* call 0x10165d52 */
            ii(0x100d_4dd2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_4dd3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_4dd4, 1); pushd(edx);                             /* push edx */
            ii(0x100d_4dd5, 1); pushd(esi);                             /* push esi */
            ii(0x100d_4dd6, 1); pushd(edi);                             /* push edi */
            ii(0x100d_4dd7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_4dd8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_4dda, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100d_4de0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100d_4de3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4de6, 6); mov(memd_a32[ds, eax], 0x101b_5c4c);    /* mov dword [eax], 0x101b5c4c */
            ii(0x100d_4dec, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_4def, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_4df2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_4df5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_4df7, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_4df8, 1); popd(edi);                              /* pop edi */
            ii(0x100d_4df9, 1); popd(esi);                              /* pop esi */
            ii(0x100d_4dfa, 1); popd(edx);                              /* pop edx */
            ii(0x100d_4dfb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_4dfc, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_4dfd, 1); retd(); return;                         /* ret */
        }
    }
}
