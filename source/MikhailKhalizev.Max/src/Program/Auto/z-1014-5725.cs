using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce016237-e906-4fc4-87a5-31ad8a70ec7c")]
        public void Method_1014_5725()
        {
            ii(0x1014_5725, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_572a, 5); calld(Definitions.sys_check_available_stack_size, 0x2_0623); /* call 0x10165d52 */
            ii(0x1014_572f, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5730, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5731, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5732, 1); pushd(edi);                             /* push edi */
            ii(0x1014_5733, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_5734, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_5736, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_573c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_573f, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_5742, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_5745, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_5748, 5); calld(0x1013_b57c, -0xa1d1);            /* call 0x1013b57c */
            ii(0x1014_574d, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1014_5750, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_5753, 5); calld(0x1013_b4b3, -0xa2a5);            /* call 0x1013b4b3 */
            ii(0x1014_5758, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_575b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_575e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5760, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5761, 1); popd(edi);                              /* pop edi */
            ii(0x1014_5762, 1); popd(esi);                              /* pop esi */
            ii(0x1014_5763, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_5764, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_5765, 1); retd(); return;                         /* ret */
        }
    }
}
