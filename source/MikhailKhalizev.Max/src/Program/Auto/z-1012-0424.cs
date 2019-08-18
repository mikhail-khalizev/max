using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ea075f48-7f13-4ddd-a8fc-f2ab32b344a5")]
        public void Method_1012_0424()
        {
            ii(0x1012_0424, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1012_0429, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5924); /* call 0x10165d52 */
            ii(0x1012_042e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_042f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_0430, 1); pushd(esi);                             /* push esi */
            ii(0x1012_0431, 1); pushd(edi);                             /* push edi */
            ii(0x1012_0432, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_0433, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0435, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_043b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_043e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1012_0441, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1012_0446, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0449, 5); calld(0x1013_a1be, 0x1_9d70);           /* call 0x1013a1be */
            ii(0x1012_044e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1012_0451, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_0454, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1012_0457, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1012_045a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_045c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_045d, 1); popd(edi);                              /* pop edi */
            ii(0x1012_045e, 1); popd(esi);                              /* pop esi */
            ii(0x1012_045f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_0460, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_0461, 1); retd(); return;                         /* ret */
        }
    }
}
