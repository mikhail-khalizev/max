using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("53144af8-2376-466c-97a5-c3d7f3e363db")]
        public void Method_1011_fdcd()
        {
            ii(0x1011_fdcd, 5); pushd(0x1c);                            /* push 0x1c */
            ii(0x1011_fdd2, 5); calld(Definitions.sys_check_available_stack_size, 0x4_5f7b); /* call 0x10165d52 */
            ii(0x1011_fdd7, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_fdd8, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_fdd9, 1); pushd(edx);                             /* push edx */
            ii(0x1011_fdda, 1); pushd(esi);                             /* push esi */
            ii(0x1011_fddb, 1); pushd(edi);                             /* push edi */
            ii(0x1011_fddc, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_fddd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fddf, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_fde5, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fdea, 5); calld(0x1011_df2e, -0x1ec1);            /* call 0x1011df2e */
            ii(0x1011_fdef, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_fdf0, 1); popd(edi);                              /* pop edi */
            ii(0x1011_fdf1, 1); popd(esi);                              /* pop esi */
            ii(0x1011_fdf2, 1); popd(edx);                              /* pop edx */
            ii(0x1011_fdf3, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_fdf4, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_fdf5, 1); retd(); return;                         /* ret */
        }
    }
}
