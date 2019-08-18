using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c7e0-be4825b7")]
        public void Method_1009_c7e0()
        {
            ii(0x1009_c7e0, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x1009_c7e5, 5); calld(Definitions.sys_check_available_stack_size, 0xc_9568); /* call 0x10165d52 */
            ii(0x1009_c7ea, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_c7eb, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_c7ec, 1); pushd(esi);                             /* push esi */
            ii(0x1009_c7ed, 1); pushd(edi);                             /* push edi */
            ii(0x1009_c7ee, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_c7ef, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_c7f1, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1009_c7f7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c7fa, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1009_c7fd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1009_c800, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c803, 5); calld(0x1013_abc3, 0x9_e3bb);           /* call 0x1013abc3 */
            ii(0x1009_c808, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_c80b, 3); lea(eax, ebp - 0x8);                    /* lea eax, [ebp-0x8] */
            ii(0x1009_c80e, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1009_c811, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_c814, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_c817, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_c81a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_c81c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_c81d, 1); popd(edi);                              /* pop edi */
            ii(0x1009_c81e, 1); popd(esi);                              /* pop esi */
            ii(0x1009_c81f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_c820, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_c821, 1); retd(); return;                         /* ret */
        }
    }
}
