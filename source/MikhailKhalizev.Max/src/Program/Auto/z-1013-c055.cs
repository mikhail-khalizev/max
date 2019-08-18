using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("684d1c55-1097-4232-9b3c-cbea3081521a")]
        public void Method_1013_c055()
        {
            ii(0x1013_c055, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1013_c05a, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9cf3); /* call 0x10165d52 */
            ii(0x1013_c05f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c060, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c061, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c062, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c063, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c065, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c06b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c06e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1013_c071, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1013_c074, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c077, 2); mov(ecx, memd_a32[ds, eax]);            /* mov ecx, [eax] */
            ii(0x1013_c079, 5); mov(ebx, 0x1);                          /* mov ebx, 0x1 */
            ii(0x1013_c07e, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1013_c081, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c084, 5); calld(/* sys */ 0x1017_2831, 0x3_67a8); /* call 0x10172831 */
            ii(0x1013_c089, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c08b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c08c, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c08d, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c08e, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c08f, 1); retd(); return;                         /* ret */
        }
    }
}
