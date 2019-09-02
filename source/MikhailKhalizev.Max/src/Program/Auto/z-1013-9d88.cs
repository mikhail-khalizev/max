using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_9d88-6c1c36e")]
        public void Method_1013_9d88()
        {
            ii(0x1013_9d88, 5); push(0x24);                             /* push 0x24 */
            ii(0x1013_9d8d, 5); call(Definitions.sys_check_available_stack_size, 0x2_bfc0); /* call 0x10165d52 */
            ii(0x1013_9d92, 1); push(ebx);                              /* push ebx */
            ii(0x1013_9d93, 1); push(ecx);                              /* push ecx */
            ii(0x1013_9d94, 1); push(esi);                              /* push esi */
            ii(0x1013_9d95, 1); push(edi);                              /* push edi */
            ii(0x1013_9d96, 1); push(ebp);                              /* push ebp */
            ii(0x1013_9d97, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_9d99, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1013_9d9f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9da2, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_9da5, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x1013_9daa, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9dad, 5); call(0x1013_9ccc, -0xe6);               /* call 0x10139ccc */
            ii(0x1013_9db2, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_9db5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_9db8, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1013_9dbb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1013_9dbe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_9dc0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_9dc1, 1); pop(edi);                               /* pop edi */
            ii(0x1013_9dc2, 1); pop(esi);                               /* pop esi */
            ii(0x1013_9dc3, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_9dc4, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_9dc5, 1); ret();                                  /* ret */
        }
    }
}
