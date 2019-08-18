using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d338-4f02f9a5")]
        public void Method_1009_d338()
        {
            ii(0x1009_d338, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_d33d, 5); calld(Definitions.sys_check_available_stack_size, 0xc_8a10); /* call 0x10165d52 */
            ii(0x1009_d342, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_d343, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_d344, 1); pushd(edx);                             /* push edx */
            ii(0x1009_d345, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d346, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d347, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d348, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d34a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_d350, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_d353, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_d35a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_d35d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d35f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d360, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d361, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d362, 1); popd(edx);                              /* pop edx */
            ii(0x1009_d363, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_d364, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_d365, 1); retd(); return;                         /* ret */
        }
    }
}
