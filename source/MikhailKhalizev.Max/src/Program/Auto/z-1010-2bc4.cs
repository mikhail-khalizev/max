using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2bc4-f7fbf796")]
        public void Method_1010_2bc4()
        {
            ii(0x1010_2bc4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_2bc9, 5); calld(Definitions.sys_check_available_stack_size, 0x6_3184); /* call 0x10165d52 */
            ii(0x1010_2bce, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_2bcf, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_2bd0, 1); pushd(esi);                             /* push esi */
            ii(0x1010_2bd1, 1); pushd(edi);                             /* push edi */
            ii(0x1010_2bd2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_2bd3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2bd5, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_2bdb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_2bde, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_2be1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1010_2be4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_2be7, 3); add(eax, 0x6c);                         /* add eax, 0x6c */
            ii(0x1010_2bea, 5); calld(0x100c_b77c, -0x3_7473);          /* call 0x100cb77c */
            ii(0x1010_2bef, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2bf1, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_2bf2, 1); popd(edi);                              /* pop edi */
            ii(0x1010_2bf3, 1); popd(esi);                              /* pop esi */
            ii(0x1010_2bf4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_2bf5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_2bf6, 1); retd(); return;                         /* ret */
        }
    }
}
