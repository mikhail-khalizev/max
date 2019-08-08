using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f03ec08-4d67-4ec5-a7e7-b6d6c3ddce0e")]
        public void Method_1013_c404()
        {
            ii(0x1013_c404, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_c409, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9944); /* call 0x10165d52 */
            ii(0x1013_c40e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c40f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c410, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c411, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c412, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c413, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c415, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c41b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c41e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c421, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1013_c426, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c429, 5); calld(0x1013_a1be, -0x2270);            /* call 0x1013a1be */
            ii(0x1013_c42e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c431, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c434, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c437, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c43a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c43c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c43d, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c43e, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c43f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c440, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c441, 1); retd(); return;                         /* ret */
        }
    }
}
