using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b74e7500-450f-4a90-b0d9-ce36285f1f59")]
        public void Method_100e_07f4()
        {
            ii(0x100e_07f4, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100e_07f9, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5554); /* call 0x10165d52 */
            ii(0x100e_07fe, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_07ff, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0800, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0801, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0802, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0803, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0805, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x100e_080b, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_080e, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0811, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_0814, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0817, 5); calld(0x1013_ac03, 0x5_a3e7);           /* call 0x1013ac03 */
            ii(0x100e_081c, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_081f, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x100e_0822, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100e_0825, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0828, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100e_082b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100e_082e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0830, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0831, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0832, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0833, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0834, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0835, 1); retd(); return;                         /* ret */
        }
    }
}
