using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("543ba228-4b07-4e7c-8c42-5a420ced1fcf")]
        public void Method_100e_0cc0()
        {
            ii(0x100e_0cc0, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x100e_0cc5, 5); calld(Definitions.sys_check_available_stack_size, 0x85088); /* call 0x10165d52 */
            ii(0x100e_0cca, 1); pushd(ebx);                             /* push ebx */
            ii(0x100e_0ccb, 1); pushd(ecx);                             /* push ecx */
            ii(0x100e_0ccc, 1); pushd(esi);                             /* push esi */
            ii(0x100e_0ccd, 1); pushd(edi);                             /* push edi */
            ii(0x100e_0cce, 1); pushd(ebp);                             /* push ebp */
            ii(0x100e_0ccf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_0cd1, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100e_0cd7, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100e_0cda, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100e_0cdd, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100e_0ce0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100e_0ce3, 5); calld(0x1013_a2ab, 0x595c3);            /* call 0x1013a2ab */
            ii(0x100e_0ce8, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_0cea, 1); popd(ebp);                              /* pop ebp */
            ii(0x100e_0ceb, 1); popd(edi);                              /* pop edi */
            ii(0x100e_0cec, 1); popd(esi);                              /* pop esi */
            ii(0x100e_0ced, 1); popd(ecx);                              /* pop ecx */
            ii(0x100e_0cee, 1); popd(ebx);                              /* pop ebx */
            ii(0x100e_0cef, 1); retd(); return;                         /* ret */
        }
    }
}
