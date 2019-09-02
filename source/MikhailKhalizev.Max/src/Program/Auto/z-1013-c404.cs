using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c404-193078e4")]
        public void Method_1013_c404()
        {
            ii(0x1013_c404, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_c409, 5); call(Definitions.sys_check_available_stack_size, 0x2_9944); /* call 0x10165d52 */
            ii(0x1013_c40e, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c40f, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c410, 1); push(esi);                              /* push esi */
            ii(0x1013_c411, 1); push(edi);                              /* push edi */
            ii(0x1013_c412, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c413, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c415, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_c41b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c41e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c421, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_c426, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c429, 5); call(0x1013_a1be, -0x2270);             /* call 0x1013a1be */
            ii(0x1013_c42e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c431, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c434, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_c437, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_c43a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c43c, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c43d, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c43e, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c43f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c440, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c441, 1); ret();                                  /* ret */
        }
    }
}
