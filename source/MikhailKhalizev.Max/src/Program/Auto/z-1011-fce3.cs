using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ac89b86e-a1b5-4029-910d-57bda1633b9e")]
        public void Method_1011_fce3()
        {
            ii(0x1011_fce3, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1011_fce8, 5); calld(Definitions.sys_check_available_stack_size, 0x4_6065); /* call 0x10165d52 */
            ii(0x1011_fced, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fcee, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fcef, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fcf0, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fcf1, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fcf2, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fcf3, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fcf5, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_fcfb, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fd00, 5); calld(0x1011_dd89, -0x1f7c);            /* call 0x1011dd89 */
            ii(0x1011_fd05, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fd06, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fd07, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fd08, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fd09, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fd0a, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fd0b, 1); retd(); return;                         /* ret */
        }
    }
}
