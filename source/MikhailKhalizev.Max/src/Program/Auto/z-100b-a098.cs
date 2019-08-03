using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a7d87e6a-66d0-4dd4-9f71-feb1537081e3")]
        public void Method_100b_a098()
        {
            ii(0x100b_a098, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_a09d, 5); calld(Definitions.sys_check_available_stack_size, 0xabcb0); /* call 0x10165d52 */
            ii(0x100b_a0a2, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_a0a3, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_a0a4, 1); pushd(edx);                             /* push edx */
            ii(0x100b_a0a5, 1); pushd(esi);                             /* push esi */
            ii(0x100b_a0a6, 1); pushd(edi);                             /* push edi */
            ii(0x100b_a0a7, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_a0a8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_a0aa, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_a0b0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100b_a0b3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_a0b6, 3); add(eax, 0x43);                         /* add eax, 0x43 */
            ii(0x100b_a0b9, 5); calld(0x100c_b000, 0x10f42);            /* call 0x100cb000 */
            ii(0x100b_a0be, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_a0c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_a0c4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_a0c6, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_a0c7, 1); popd(edi);                              /* pop edi */
            ii(0x100b_a0c8, 1); popd(esi);                              /* pop esi */
            ii(0x100b_a0c9, 1); popd(edx);                              /* pop edx */
            ii(0x100b_a0ca, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_a0cb, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_a0cc, 1); retd(); return;                         /* ret */
        }
    }
}
