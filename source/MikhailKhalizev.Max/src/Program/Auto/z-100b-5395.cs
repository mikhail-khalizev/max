using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("7a5e267d-e112-4ae8-b7b7-050da3a5d0b8")]
        public void Method_100b_5395()
        {
            ii(0x100b_5395, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_539a, 5); calld(Definitions.sys_check_available_stack_size, 0xb_09b3); /* call 0x10165d52 */
            ii(0x100b_539f, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_53a0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_53a1, 1); pushd(edx);                             /* push edx */
            ii(0x100b_53a2, 1); pushd(esi);                             /* push esi */
            ii(0x100b_53a3, 1); pushd(edi);                             /* push edi */
            ii(0x100b_53a4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_53a5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_53a7, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_53ad, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_53b0, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x100b_53b7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_53ba, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_53bc, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_53bd, 1); popd(edi);                              /* pop edi */
            ii(0x100b_53be, 1); popd(esi);                              /* pop esi */
            ii(0x100b_53bf, 1); popd(edx);                              /* pop edx */
            ii(0x100b_53c0, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_53c1, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_53c2, 1); retd(); return;                         /* ret */
        }
    }
}
