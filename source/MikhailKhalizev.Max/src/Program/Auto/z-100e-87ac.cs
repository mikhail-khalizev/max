using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a673e860-50fd-4159-812c-f85d8163cc06")]
        public void Method_100e_87ac()
        {
            ii(0x100e_87ac, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100e_87b1, 5); calld(Definitions.sys_check_available_stack_size, 0x7d59c); /* call 0x10165d52 */
            ii(0x100e_87b6, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_87b7, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_87b8, 1); pushd(edx);                             /* push edx */
            ii(0x100e_87b9, 1); pushd(esi);                             /* push esi */
            ii(0x100e_87ba, 1); pushd(edi);                             /* push edi */
            ii(0x100e_87bb, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_87bc, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_87be, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_87c4, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100e_87c7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100e_87ca, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x100e_87cd, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_87d0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_87d3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_87d5, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_87d6, 1); popd(edi);                              /* pop edi */
            ii(0x100e_87d7, 1); popd(esi);                              /* pop esi */
            ii(0x100e_87d8, 1); popd(edx);                              /* pop edx */
            ii(0x100e_87d9, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_87da, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_87db, 1); retd(); return;                         /* ret */
        }
    }
}
