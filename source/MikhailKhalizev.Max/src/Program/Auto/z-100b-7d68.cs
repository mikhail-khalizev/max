using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_7d68-a87d58a8")]
        public void Method_100b_7d68()
        {
            ii(0x100b_7d68, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_7d6d, 5); call(Definitions.sys_check_available_stack_size, 0xa_dfe0); /* call 0x10165d52 */
            ii(0x100b_7d72, 1); push(ebx);                              /* push ebx */
            ii(0x100b_7d73, 1); push(ecx);                              /* push ecx */
            ii(0x100b_7d74, 1); push(edx);                              /* push edx */
            ii(0x100b_7d75, 1); push(esi);                              /* push esi */
            ii(0x100b_7d76, 1); push(edi);                              /* push edi */
            ii(0x100b_7d77, 1); push(ebp);                              /* push ebp */
            ii(0x100b_7d78, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_7d7a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x100b_7d80, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_7d83, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_7d86, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_7d89, 5); call(0x1007_65d0, -0x4_17be);           /* call 0x100765d0 */
            ii(0x100b_7d8e, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100b_7d91, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100b_7d94, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_7d96, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_7d97, 1); pop(edi);                               /* pop edi */
            ii(0x100b_7d98, 1); pop(esi);                               /* pop esi */
            ii(0x100b_7d99, 1); pop(edx);                               /* pop edx */
            ii(0x100b_7d9a, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_7d9b, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_7d9c, 1); ret();                                  /* ret */
        }
    }
}
