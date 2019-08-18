using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2e4d-71ed6015")]
        public void Method_100a_2e4d()
        {
            ii(0x100a_2e4d, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100a_2e52, 5); calld(Definitions.sys_check_available_stack_size, 0xc_2efb); /* call 0x10165d52 */
            ii(0x100a_2e57, 1); pushd(ebx);                             /* push ebx */
            ii(0x100a_2e58, 1); pushd(ecx);                             /* push ecx */
            ii(0x100a_2e59, 1); pushd(edx);                             /* push edx */
            ii(0x100a_2e5a, 1); pushd(esi);                             /* push esi */
            ii(0x100a_2e5b, 1); pushd(edi);                             /* push edi */
            ii(0x100a_2e5c, 1); pushd(ebp);                             /* push ebp */
            ii(0x100a_2e5d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2e5f, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x100a_2e65, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100a_2e68, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_2e6a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100a_2e6d, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x100a_2e70, 5); calld(0x1008_afe4, -0x1_7e91);          /* call 0x1008afe4 */
            ii(0x100a_2e75, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100a_2e78, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100a_2e7d, 5); calld(0x100a_5e27, 0x2fa5);             /* call 0x100a5e27 */
            ii(0x100a_2e82, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_2e84, 1); popd(ebp);                              /* pop ebp */
            ii(0x100a_2e85, 1); popd(edi);                              /* pop edi */
            ii(0x100a_2e86, 1); popd(esi);                              /* pop esi */
            ii(0x100a_2e87, 1); popd(edx);                              /* pop edx */
            ii(0x100a_2e88, 1); popd(ecx);                              /* pop ecx */
            ii(0x100a_2e89, 1); popd(ebx);                              /* pop ebx */
            ii(0x100a_2e8a, 1); retd(); return;                         /* ret */
        }
    }
}
