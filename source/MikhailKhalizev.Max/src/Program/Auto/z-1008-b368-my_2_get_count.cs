using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("104719c9-40d8-4344-8649-3b04dfa67325")]
        public void my_2_get_count()
        {
            ii(0x1008_b368, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_b36d, 5); calld(Definitions.sys_check_available_stack_size, 0xda9e0); /* call 0x10165d52 */
            ii(0x1008_b372, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_b373, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_b374, 1); pushd(edx);                             /* push edx */
            ii(0x1008_b375, 1); pushd(esi);                             /* push esi */
            ii(0x1008_b376, 1); pushd(edi);                             /* push edi */
            ii(0x1008_b377, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_b378, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_b37a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_b380, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_b383, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_b386, 5); calld(0x1008_b410, 0x85);               /* call 0x1008b410 */
            ii(0x1008_b38b, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_b38e, 5); calld(Definitions.my_3_get_count, 0xed); /* call 0x1008b480 */
            ii(0x1008_b393, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_b396, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_b399, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_b39b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_b39c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_b39d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_b39e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_b39f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_b3a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_b3a1, 1); retd(); return;                         /* ret */
        }
    }
}
