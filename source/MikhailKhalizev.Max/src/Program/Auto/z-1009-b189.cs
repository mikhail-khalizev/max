using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b189-c92b38cb")]
        public void Method_1009_b189()
        {
            ii(0x1009_b189, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_b18e, 5); calld(Definitions.sys_check_available_stack_size, 0xc_abbf); /* call 0x10165d52 */
            ii(0x1009_b193, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_b194, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_b195, 1); pushd(edx);                             /* push edx */
            ii(0x1009_b196, 1); pushd(esi);                             /* push esi */
            ii(0x1009_b197, 1); pushd(edi);                             /* push edi */
            ii(0x1009_b198, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_b199, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_b19b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_b1a1, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_b1a4, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_b1ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_b1ae, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_b1b0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_b1b1, 1); popd(edi);                              /* pop edi */
            ii(0x1009_b1b2, 1); popd(esi);                              /* pop esi */
            ii(0x1009_b1b3, 1); popd(edx);                              /* pop edx */
            ii(0x1009_b1b4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_b1b5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_b1b6, 1); retd();                                 /* ret */
        }
    }
}
