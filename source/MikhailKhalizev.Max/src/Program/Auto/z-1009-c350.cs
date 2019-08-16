using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("6e3dcf42-62f7-49fe-8a14-0e52db1ef047")]
        public void Method_1009_c350()
        {
            ii(0x1009_c350, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_c355, 5); calld(Definitions.sys_check_available_stack_size, 0xc_99f8); /* call 0x10165d52 */
            ii(0x1009_c35a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c35b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c35c, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c35d, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c35e, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c35f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c360, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c362, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c368, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c36b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c36e, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x2_552f); /* call 0x10076e44 */
            ii(0x1009_c373, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c376, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1009_c379, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c37c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c37f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c382, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c385, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c387, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c388, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c389, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c38a, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c38b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c38c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c38d, 1); retd(); return;                         /* ret */
        }
    }
}