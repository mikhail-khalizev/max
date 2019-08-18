using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("29063e59-b4ec-4da1-9eba-eafee3d9c88f")]
        public void Method_1009_c1c4()
        {
            ii(0x1009_c1c4, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1009_c1c9, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9b84); /* call 0x10165d52 */
            ii(0x1009_c1ce, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c1cf, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c1d0, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c1d1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c1d2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c1d4, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_c1da, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c1dd, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1009_c1e0, 3); mov(memd_a32[ss, ebp - 0x4], ebx);      /* mov [ebp-0x4], ebx */
            ii(0x1009_c1e3, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1009_c1e7, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_c1ea, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_c1ed, 5); calld(0x100c_d990, 0x3_179e);           /* call 0x100cd990 */
            ii(0x1009_c1f2, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c1f4, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c1f5, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c1f6, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c1f7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c1f8, 1); retd(); return;                         /* ret */
        }
    }
}
