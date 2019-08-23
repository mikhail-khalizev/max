using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fdcd-28696e63")]
        public void Method_1011_fdcd()
        {
            ii(0x1011_fdcd, 5); push(0x1c);                             /* push 0x1c */
            ii(0x1011_fdd2, 5); call(Definitions.sys_check_available_stack_size, 0x4_5f7b); /* call 0x10165d52 */
            ii(0x1011_fdd7, 1); push(ebx);                              /* push ebx */
            ii(0x1011_fdd8, 1); push(ecx);                              /* push ecx */
            ii(0x1011_fdd9, 1); push(edx);                              /* push edx */
            ii(0x1011_fdda, 1); push(esi);                              /* push esi */
            ii(0x1011_fddb, 1); push(edi);                              /* push edi */
            ii(0x1011_fddc, 1); push(ebp);                              /* push ebp */
            ii(0x1011_fddd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_fddf, 6); sub(esp, 0);                            /* sub esp, 0x0 */
            ii(0x1011_fde5, 5); mov(eax, 0x101c_536c);                  /* mov eax, 0x101c536c */
            ii(0x1011_fdea, 5); call(0x1011_df2e, -0x1ec1);             /* call 0x1011df2e */
            ii(0x1011_fdef, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_fdf0, 1); pop(edi);                               /* pop edi */
            ii(0x1011_fdf1, 1); pop(esi);                               /* pop esi */
            ii(0x1011_fdf2, 1); pop(edx);                               /* pop edx */
            ii(0x1011_fdf3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_fdf4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_fdf5, 1); ret();                                  /* ret */
        }
    }
}
