using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7c48-d9e7ef35")]
        public void Method_1014_7c48()
        {
            ii(0x1014_7c48, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7c4d, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e100); /* call 0x10165d52 */
            ii(0x1014_7c52, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7c53, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7c54, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7c55, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7c56, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7c57, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7c58, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7c5a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7c60, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7c63, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7c66, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1014_7c69, 5); calld(0x1014_81a4, 0x536);              /* call 0x101481a4 */
            ii(0x1014_7c6e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7c71, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7c74, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7c76, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7c77, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7c78, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7c79, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7c7a, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7c7b, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7c7c, 1); retd(); return;                         /* ret */
        }
    }
}
