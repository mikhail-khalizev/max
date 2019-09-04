using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_c9a1-b84107c9")]
        public void Method_1007_c9a1()
        {
            ii(0x1007_c9a1, 5); push(0x20);                             /* push 0x20 */
            ii(0x1007_c9a6, 5); call(Definitions.sys_check_available_stack_size, 0xe_93a7); /* call 0x10165d52 */
            ii(0x1007_c9ab, 1); push(ebx);                              /* push ebx */
            ii(0x1007_c9ac, 1); push(ecx);                              /* push ecx */
            ii(0x1007_c9ad, 1); push(esi);                              /* push esi */
            ii(0x1007_c9ae, 1); push(edi);                              /* push edi */
            ii(0x1007_c9af, 1); push(ebp);                              /* push ebp */
            ii(0x1007_c9b0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_c9b2, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1007_c9b8, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1007_c9bb, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1007_c9be, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_c9c0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_c9c1, 1); pop(edi);                               /* pop edi */
            ii(0x1007_c9c2, 1); pop(esi);                               /* pop esi */
            ii(0x1007_c9c3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_c9c4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_c9c5, 1); ret();                                  /* ret */
        }
    }
}
