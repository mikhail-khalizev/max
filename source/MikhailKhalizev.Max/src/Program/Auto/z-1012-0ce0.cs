using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c61259fb-a4e7-4aab-a40c-ca57801d3976")]
        public void Method_1012_0ce0()
        {
            ii(0x1012_0ce0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1012_0ce5, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5068); /* call 0x10165d52 */
            ii(0x1012_0cea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_0ceb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0cec, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0ced, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0cee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0cef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0cf1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_0cf7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0cfa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0cfd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1012_0d00, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0d03, 5); calld(0x1013_abc3, 0x1_9ebb);           /* call 0x1013abc3 */
            ii(0x1012_0d08, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0d0b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1012_0d0e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0d11, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0d14, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1012_0d17, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_0d1a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0d1c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_0d1d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_0d1e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_0d1f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0d20, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0d21, 1); retd(); return;                         /* ret */
        }
    }
}
