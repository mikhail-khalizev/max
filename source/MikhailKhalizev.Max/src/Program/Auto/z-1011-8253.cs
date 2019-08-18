using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("27e1b4ac-f6a4-46a6-b86e-6302431daa40")]
        public void Method_1011_8253()
        {
            ii(0x1011_8253, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1011_8258, 5); calld(Definitions.sys_check_available_stack_size, 0x4_daf5); /* call 0x10165d52 */
            ii(0x1011_825d, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_825e, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_825f, 1); pushd(esi);                             /* push esi */
            ii(0x1011_8260, 1); pushd(edi);                             /* push edi */
            ii(0x1011_8261, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_8262, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_8264, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1011_826a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_826d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_8270, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
            ii(0x1011_8277, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_827a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_827c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_827d, 1); popd(edi);                              /* pop edi */
            ii(0x1011_827e, 1); popd(esi);                              /* pop esi */
            ii(0x1011_827f, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_8280, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_8281, 1); retd(); return;                         /* ret */
        }
    }
}
