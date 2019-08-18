using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("33e60864-c036-48fa-b425-646ba89c5ec2")]
        public void Method_1013_c7d0()
        {
            ii(0x1013_c7d0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1013_c7d5, 5); calld(Definitions.sys_check_available_stack_size, 0x2_9578); /* call 0x10165d52 */
            ii(0x1013_c7da, 1); pushd(ebx);                             /* push ebx */
            ii(0x1013_c7db, 1); pushd(ecx);                             /* push ecx */
            ii(0x1013_c7dc, 1); pushd(esi);                             /* push esi */
            ii(0x1013_c7dd, 1); pushd(edi);                             /* push edi */
            ii(0x1013_c7de, 1); pushd(ebp);                             /* push ebp */
            ii(0x1013_c7df, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c7e1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c7e7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1013_c7ea, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1013_c7ed, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1013_c7f1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1013_c7f4, 5); calld(0x100a_b494, -0x9_1365);          /* call 0x100ab494 */
            ii(0x1013_c7f9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1013_c7fc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1013_c7ff, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c801, 1); popd(ebp);                              /* pop ebp */
            ii(0x1013_c802, 1); popd(edi);                              /* pop edi */
            ii(0x1013_c803, 1); popd(esi);                              /* pop esi */
            ii(0x1013_c804, 1); popd(ecx);                              /* pop ecx */
            ii(0x1013_c805, 1); popd(ebx);                              /* pop ebx */
            ii(0x1013_c806, 1); retd(); return;                         /* ret */
        }
    }
}
