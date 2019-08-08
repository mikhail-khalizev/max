using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("94a3fb24-171c-4720-a407-67a5ea80f298")]
        public void Method_1008_a330()
        {
            ii(0x1008_a330, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a335, 5); calld(Definitions.sys_check_available_stack_size, 0xd_ba18); /* call 0x10165d52 */
            ii(0x1008_a33a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a33b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a33c, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a33d, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a33e, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a33f, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a340, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a342, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a348, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a34b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a34e, 5); calld(Definitions.my_ctor_0x101b6edc, -0x1_350f); /* call 0x10076e44 */
            ii(0x1008_a353, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a356, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_a359, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a35c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a35f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a362, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_a365, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a367, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a368, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a369, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a36a, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a36b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a36c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a36d, 1); retd(); return;                         /* ret */
        }
    }
}
