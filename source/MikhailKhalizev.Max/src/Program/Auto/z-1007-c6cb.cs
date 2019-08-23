using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c6cb-c7360c32")]
        public void Method_1007_c6cb()
        {
            ii(0x1007_c6cb, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_c6d0, 5); call(Definitions.sys_check_available_stack_size, 0xe_967d); /* call 0x10165d52 */
            ii(0x1007_c6d5, 1); push(ebx);                              /* push ebx */
            ii(0x1007_c6d6, 1); push(ecx);                              /* push ecx */
            ii(0x1007_c6d7, 1); push(edx);                              /* push edx */
            ii(0x1007_c6d8, 1); push(esi);                              /* push esi */
            ii(0x1007_c6d9, 1); push(edi);                              /* push edi */
            ii(0x1007_c6da, 1); push(ebp);                              /* push ebp */
            ii(0x1007_c6db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c6dd, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_c6e3, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_c6e6, 4); mov(memb[ss, ebp - 0x8], 0);            /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_c6ea, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x1007_c6ed, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c6ef, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_c6f0, 1); pop(edi);                               /* pop edi */
            ii(0x1007_c6f1, 1); pop(esi);                               /* pop esi */
            ii(0x1007_c6f2, 1); pop(edx);                               /* pop edx */
            ii(0x1007_c6f3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_c6f4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_c6f5, 1); ret();                                  /* ret */
        }
    }
}
