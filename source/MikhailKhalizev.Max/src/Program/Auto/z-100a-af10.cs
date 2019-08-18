using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("295079b0-f947-46b1-a0cb-427f23b4e41c")]
        public void Method_100a_af10()
        {
            ii(0x100a_af10, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100a_af15, 5); calld(Definitions.sys_check_available_stack_size, 0xb_ae38); /* call 0x10165d52 */
            ii(0x100a_af1a, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_af1b, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_af1c, 1); pushd(edx);                             /* push edx */
            ii(0x100a_af1d, 1); pushd(esi);                             /* push esi */
            ii(0x100a_af1e, 1); pushd(edi);                             /* push edi */
            ii(0x100a_af1f, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_af20, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_af22, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100a_af28, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_af2b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_af2e, 5); calld(0x1007_6c30, -0x3_4303);          /* call 0x10076c30 */
            ii(0x100a_af33, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100a_af36, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100a_af39, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_af3b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_af3c, 1); popd(edi);                              /* pop edi */
            ii(0x100a_af3d, 1); popd(esi);                              /* pop esi */
            ii(0x100a_af3e, 1); popd(edx);                              /* pop edx */
            ii(0x100a_af3f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_af40, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_af41, 1); retd(); return;                         /* ret */
        }
    }
}
