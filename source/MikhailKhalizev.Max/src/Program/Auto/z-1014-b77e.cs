using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18306d33-f488-492c-aede-fb75a189525c")]
        public void Method_1014_b77e()
        {
            ii(0x1014_b77e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1014_b783, 5); calld(Definitions.sys_check_available_stack_size, 0x1_a5ca); /* call 0x10165d52 */
            ii(0x1014_b788, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_b789, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_b78a, 1); pushd(edx);                             /* push edx */
            ii(0x1014_b78b, 1); pushd(esi);                             /* push esi */
            ii(0x1014_b78c, 1); pushd(edi);                             /* push edi */
            ii(0x1014_b78d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_b78e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_b790, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_b796, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_b799, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_b79c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b79f, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b7a2, 5); calld(0x1008_aab4, -0xc_0cf3);          /* call 0x1008aab4 */
            ii(0x1014_b7a7, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_b7aa, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_b7ad, 3); mov(eax, memd_a32[ds, eax + 0x7e]);     /* mov eax, [eax+0x7e] */
            ii(0x1014_b7b0, 5); calld(0x1010_4890, -0x4_6f25);          /* call 0x10104890 */
            ii(0x1014_b7b5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_b7b7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_b7b8, 1); popd(edi);                              /* pop edi */
            ii(0x1014_b7b9, 1); popd(esi);                              /* pop esi */
            ii(0x1014_b7ba, 1); popd(edx);                              /* pop edx */
            ii(0x1014_b7bb, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_b7bc, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_b7bd, 1); retd(); return;                         /* ret */
        }
    }
}
