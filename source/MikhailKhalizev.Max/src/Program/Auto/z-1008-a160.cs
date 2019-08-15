using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0b366abd-df55-4edb-b8d7-e49b1f416a9d")]
        public void Method_1008_a160()
        {
            ii(0x1008_a160, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1008_a165, 5); calld(Definitions.sys_check_available_stack_size, 0xd_bbe8); /* call 0x10165d52 */
            ii(0x1008_a16a, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_a16b, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_a16c, 1); pushd(esi);                             /* push esi */
            ii(0x1008_a16d, 1); pushd(edi);                             /* push edi */
            ii(0x1008_a16e, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_a16f, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_a171, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_a177, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a17a, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_a17d, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_a180, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a183, 5); calld(0x1007_6cd0, -0x1_34b8);          /* call 0x10076cd0 */
            ii(0x1008_a188, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_a18b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1008_a18e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_a191, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_a194, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_a197, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_a19a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_a19c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_a19d, 1); popd(edi);                              /* pop edi */
            ii(0x1008_a19e, 1); popd(esi);                              /* pop esi */
            ii(0x1008_a19f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_a1a0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_a1a1, 1); retd(); return;                         /* ret */
        }
    }
}
