using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("a93aaf77-bc88-4d0e-947b-7311dfcce161")]
        public void Method_1016_4660()
        {
            ii(0x1016_4660, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_4665, 5); calld(Definitions.sys_check_available_stack_size, 0x16e8); /* call 0x10165d52 */
            ii(0x1016_466a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_466b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_466c, 1); pushd(esi);                             /* push esi */
            ii(0x1016_466d, 1); pushd(edi);                             /* push edi */
            ii(0x1016_466e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_466f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4671, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_4677, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_467a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_467d, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1016_4682, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4685, 5); calld(0x1013_b0a5, -0x2_95e5);          /* call 0x1013b0a5 */
            ii(0x1016_468a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_468d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4690, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_4693, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_4696, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4698, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4699, 1); popd(edi);                              /* pop edi */
            ii(0x1016_469a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_469b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_469c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_469d, 1); retd(); return;                         /* ret */
        }
    }
}