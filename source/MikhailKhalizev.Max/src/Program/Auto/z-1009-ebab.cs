using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("135374da-a911-415e-9cf7-46bfd1f77532")]
        public void Method_1009_ebab()
        {
            ii(0x1009_ebab, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_ebb0, 5); calld(Definitions.sys_check_available_stack_size, 0xc_719d); /* call 0x10165d52 */
            ii(0x1009_ebb5, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_ebb6, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_ebb7, 1); pushd(edx);                             /* push edx */
            ii(0x1009_ebb8, 1); pushd(esi);                             /* push esi */
            ii(0x1009_ebb9, 1); pushd(edi);                             /* push edi */
            ii(0x1009_ebba, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_ebbb, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ebbd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_ebc3, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_ebc6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_ebc9, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_ebcc, 5); calld(0x1013_a794, 0x9_bbc3);           /* call 0x1013a794 */
            ii(0x1009_ebd1, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1009_ebd4, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1009_ebd7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_ebda, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_ebdc, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_ebdd, 1); popd(edi);                              /* pop edi */
            ii(0x1009_ebde, 1); popd(esi);                              /* pop esi */
            ii(0x1009_ebdf, 1); popd(edx);                              /* pop edx */
            ii(0x1009_ebe0, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_ebe1, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_ebe2, 1); retd(); return;                         /* ret */
        }
    }
}
