using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("218cf15d-3d75-481d-a6b8-fd5240eaa698")]
        public void Method_1014_160c()
        {
            ii(0x1014_160c, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1014_1611, 5); calld(Definitions.sys_check_available_stack_size, 0x2_473c); /* call 0x10165d52 */
            ii(0x1014_1616, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_1617, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_1618, 1); pushd(esi);                             /* push esi */
            ii(0x1014_1619, 1); pushd(edi);                             /* push edi */
            ii(0x1014_161a, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_161b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_161d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1014_1623, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1626, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_1629, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1014_162d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1630, 5); calld(0x1013_b052, -0x65e3);            /* call 0x1013b052 */
            ii(0x1014_1635, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_1638, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1014_163b, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_163e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_1641, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_1644, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_1647, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_1649, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_164a, 1); popd(edi);                              /* pop edi */
            ii(0x1014_164b, 1); popd(esi);                              /* pop esi */
            ii(0x1014_164c, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_164d, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_164e, 1); retd(); return;                         /* ret */
        }
    }
}
