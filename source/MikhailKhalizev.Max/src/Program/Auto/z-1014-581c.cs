using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_581c-f4e32229")]
        public void Method_1014_581c()
        {
            ii(0x1014_581c, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x1014_5821, 5); calld(Definitions.sys_check_available_stack_size, 0x2_052c); /* call 0x10165d52 */
            ii(0x1014_5826, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_5827, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_5828, 1); pushd(esi);                             /* push esi */
            ii(0x1014_5829, 1); pushd(edi);                             /* push edi */
            ii(0x1014_582a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_582b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_582d, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1014_5833, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_5836, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_5839, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_583d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1014_5840, 5); calld(0x1013_b603, -0xa242);            /* call 0x1013b603 */
            ii(0x1014_5845, 3); lea(edx, ebp - 0x10);                   /* lea edx, [ebp-0x10] */
            ii(0x1014_5848, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_584b, 5); calld(0x1013_b4b3, -0xa39d);            /* call 0x1013b4b3 */
            ii(0x1014_5850, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_5853, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_5856, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_5858, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_5859, 1); popd(edi);                              /* pop edi */
            ii(0x1014_585a, 1); popd(esi);                              /* pop esi */
            ii(0x1014_585b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_585c, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_585d, 1); retd(); return;                         /* ret */
        }
    }
}
