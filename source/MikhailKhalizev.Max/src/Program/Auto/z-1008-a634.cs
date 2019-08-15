using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cce18830-32cb-422c-8bae-924c4cdc55fd")]
        public void Method_1008_a634()
        {
            ii(0x1008_a634, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a639, 5); calld(Definitions.sys_check_available_stack_size, 0xd_b714); /* call 0x10165d52 */
            ii(0x1008_a63e, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a63f, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a640, 1); pushd(edx);                             /* push edx */
            ii(0x1008_a641, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a642, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a643, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a644, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a646, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1008_a64c, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a64f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a652, 5); calld(Definitions.my_ctor_0x101b_6edc, -0x1_3813); /* call 0x10076e44 */
            ii(0x1008_a657, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1008_a65a, 3); lea(eax, ebp - 0x4);                    /* lea eax, [ebp-0x4] */
            ii(0x1008_a65d, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a660, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_a663, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a666, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1008_a669, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a66b, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a66c, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a66d, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a66e, 1); popd(edx);                              /* pop edx */
            ii(0x1008_a66f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a670, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a671, 1); retd(); return;                         /* ret */
        }
    }
}
