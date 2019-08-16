using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("fc1f5b84-5360-4066-a033-e11e529c5343")]
        public void Method_1009_c6c8()
        {
            ii(0x1009_c6c8, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_c6cd, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9680); /* call 0x10165d52 */
            ii(0x1009_c6d2, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c6d3, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c6d4, 1); pushd(edx);                             /* push edx */
            ii(0x1009_c6d5, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c6d6, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c6d7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c6d8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c6da, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_c6e0, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_c6e3, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_c6e6, 5); calld(0x1007_6b58, -0x2_5b93);          /* call 0x10076b58 */
            ii(0x1009_c6eb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c6ee, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c6f1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c6f3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c6f4, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c6f5, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c6f6, 1); popd(edx);                              /* pop edx */
            ii(0x1009_c6f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c6f8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c6f9, 1); retd(); return;                         /* ret */
        }
    }
}