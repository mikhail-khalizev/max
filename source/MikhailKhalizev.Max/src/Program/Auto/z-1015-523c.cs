using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("343f5716-eb1a-45c9-b686-d9496ac755bf")]
        public void Method_1015_523c()
        {
            ii(0x1015_523c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1015_5241, 5); calld(Definitions.sys_check_available_stack_size, 0x1_0b0c); /* call 0x10165d52 */
            ii(0x1015_5246, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_5247, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_5248, 1); pushd(esi);                             /* push esi */
            ii(0x1015_5249, 1); pushd(edi);                             /* push edi */
            ii(0x1015_524a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_524b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_524d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1015_5253, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_5256, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1015_5259, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_525c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_525f, 5); calld(0x1013_a112, -0x1_b152);          /* call 0x1013a112 */
            ii(0x1015_5264, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1015_5267, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1015_526a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1015_526d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1015_5270, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1015_5273, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1015_5276, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_5278, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_5279, 1); popd(edi);                              /* pop edi */
            ii(0x1015_527a, 1); popd(esi);                              /* pop esi */
            ii(0x1015_527b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_527c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_527d, 1); retd(); return;                         /* ret */
        }
    }
}
