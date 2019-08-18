using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_f4dd-3b8b8e1c")]
        public void Method_1009_f4dd()
        {
            ii(0x1009_f4dd, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1009_f4e2, 5); calld(Definitions.sys_check_available_stack_size, 0xc_686b); /* call 0x10165d52 */
            ii(0x1009_f4e7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1009_f4e8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1009_f4e9, 1); pushd(edx);                             /* push edx */
            ii(0x1009_f4ea, 1); pushd(esi);                             /* push esi */
            ii(0x1009_f4eb, 1); pushd(edi);                             /* push edi */
            ii(0x1009_f4ec, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_f4ed, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_f4ef, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_f4f5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1009_f4f8, 7); mov(memd_a32[ss, ebp - 0x8], 0x4);      /* mov dword [ebp-0x8], 0x4 */
            ii(0x1009_f4ff, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1009_f502, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_f504, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_f505, 1); popd(edi);                              /* pop edi */
            ii(0x1009_f506, 1); popd(esi);                              /* pop esi */
            ii(0x1009_f507, 1); popd(edx);                              /* pop edx */
            ii(0x1009_f508, 1); popd(ecx);                              /* pop ecx */
            ii(0x1009_f509, 1); popd(ebx);                              /* pop ebx */
            ii(0x1009_f50a, 1); retd(); return;                         /* ret */
        }
    }
}
