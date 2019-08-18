using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_48e0-76a51201")]
        public void Method_1016_48e0()
        {
            ii(0x1016_48e0, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1016_48e5, 5); calld(Definitions.sys_check_available_stack_size, 0x1468); /* call 0x10165d52 */
            ii(0x1016_48ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_48eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_48ec, 1); pushd(esi);                             /* push esi */
            ii(0x1016_48ed, 1); pushd(edi);                             /* push edi */
            ii(0x1016_48ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_48ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_48f1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1016_48f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1016_48fa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1016_48fd, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x1016_4901, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1016_4904, 5); calld(0x100a_b494, -0xb_9475);          /* call 0x100ab494 */
            ii(0x1016_4909, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1016_490c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1016_490f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4911, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_4912, 1); popd(edi);                              /* pop edi */
            ii(0x1016_4913, 1); popd(esi);                              /* pop esi */
            ii(0x1016_4914, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_4915, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_4916, 1); retd(); return;                         /* ret */
        }
    }
}
