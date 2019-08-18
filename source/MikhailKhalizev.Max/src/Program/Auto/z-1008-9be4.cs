using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9be4-ef44be07")]
        public void Method_1008_9be4()
        {
            ii(0x1008_9be4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_9be9, 5); calld(Definitions.sys_check_available_stack_size, 0xd_c164); /* call 0x10165d52 */
            ii(0x1008_9bee, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_9bef, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_9bf0, 1); pushd(esi);                             /* push esi */
            ii(0x1008_9bf1, 1); pushd(edi);                             /* push edi */
            ii(0x1008_9bf2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_9bf3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9bf5, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_9bfb, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9bfe, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_9c01, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_9c04, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9c07, 5); calld(0x1007_6d14, -0x1_2ef8);          /* call 0x10076d14 */
            ii(0x1008_9c0c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_9c0f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_9c12, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_9c15, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_9c18, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_9c1b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_9c1e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9c20, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_9c21, 1); popd(edi);                              /* pop edi */
            ii(0x1008_9c22, 1); popd(esi);                              /* pop esi */
            ii(0x1008_9c23, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_9c24, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_9c25, 1); retd(); return;                         /* ret */
        }
    }
}
