using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a4a0-23347ceb")]
        public void Method_1008_a4a0()
        {
            ii(0x1008_a4a0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1008_a4a5, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b8a8); /* call 0x10165d52 */
            ii(0x1008_a4aa, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a4ab, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a4ac, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a4ad, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a4ae, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a4af, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a4b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a4b2, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_a4b8, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a4bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a4be, 5); calld(0x1008_b410, 0xf4d);              /* call 0x1008b410 */
            ii(0x1008_a4c3, 3); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x1008_a4c6, 5); calld(Definitions.my_3_get_count, 0xfb5); /* call 0x1008b480 */
            ii(0x1008_a4cb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a4ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a4d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a4d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a4d4, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a4d5, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a4d6, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a4d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a4d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a4d9, 1); retd(); return;                         /* ret */
        }
    }
}
