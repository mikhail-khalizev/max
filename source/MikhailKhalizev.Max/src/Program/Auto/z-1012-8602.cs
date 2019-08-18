using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_8602-1f751205")]
        public void Method_1012_8602()
        {
            ii(0x1012_8602, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1012_8607, 5); calld(Definitions.sys_check_available_stack_size, 0x3_d746); /* call 0x10165d52 */
            ii(0x1012_860c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1012_860d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1012_860e, 1); pushd(edx);                             /* push edx */
            ii(0x1012_860f, 1); pushd(esi);                             /* push esi */
            ii(0x1012_8610, 1); pushd(edi);                             /* push edi */
            ii(0x1012_8611, 1); pushd(ebp);                             /* push ebp */
            ii(0x1012_8612, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_8614, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1012_861a, 5); calld(0x1012_75ed, -0x1032);            /* call 0x101275ed */
            ii(0x1012_861f, 1); popd(ebp);                              /* pop ebp */
            ii(0x1012_8620, 1); popd(edi);                              /* pop edi */
            ii(0x1012_8621, 1); popd(esi);                              /* pop esi */
            ii(0x1012_8622, 1); popd(edx);                              /* pop edx */
            ii(0x1012_8623, 1); popd(ecx);                              /* pop ecx */
            ii(0x1012_8624, 1); popd(ebx);                              /* pop ebx */
            ii(0x1012_8625, 1); retd(); return;                         /* ret */
        }
    }
}
