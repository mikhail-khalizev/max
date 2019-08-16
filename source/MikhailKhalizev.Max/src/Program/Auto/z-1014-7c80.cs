using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc89a05b-5a78-40bc-97ce-a7e3f824d172")]
        public void Method_1014_7c80()
        {
            ii(0x1014_7c80, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_7c85, 5); calld(Definitions.sys_check_available_stack_size, 0x1_e0c8); /* call 0x10165d52 */
            ii(0x1014_7c8a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_7c8b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_7c8c, 1); pushd(edx);                             /* push edx */
            ii(0x1014_7c8d, 1); pushd(esi);                             /* push esi */
            ii(0x1014_7c8e, 1); pushd(edi);                             /* push edi */
            ii(0x1014_7c8f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_7c90, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7c92, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_7c98, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_7c9b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_7c9e, 3); add(eax, 0xe);                          /* add eax, 0xe */
            ii(0x1014_7ca1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_7ca4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_7ca7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7ca9, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_7caa, 1); popd(edi);                              /* pop edi */
            ii(0x1014_7cab, 1); popd(esi);                              /* pop esi */
            ii(0x1014_7cac, 1); popd(edx);                              /* pop edx */
            ii(0x1014_7cad, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_7cae, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_7caf, 1); retd(); return;                         /* ret */
        }
    }
}