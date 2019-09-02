using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0748-fc1cf06e")]
        public void Method_1012_0748()
        {
            ii(0x1012_0748, 5); push(0x28);                             /* push 0x28 */
            ii(0x1012_074d, 5); call(Definitions.sys_check_available_stack_size, 0x4_5600); /* call 0x10165d52 */
            ii(0x1012_0752, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0753, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0754, 1); push(esi);                              /* push esi */
            ii(0x1012_0755, 1); push(edi);                              /* push edi */
            ii(0x1012_0756, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0757, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0759, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_075f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_0762, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_0765, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_0768, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_076b, 5); call(0x1007_6d14, -0xa_9a5c);           /* call 0x10076d14 */
            ii(0x1012_0770, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_0773, 3); lea(eax, memd[ss, ebp - 8]);            /* lea eax, [ebp-0x8] */
            ii(0x1012_0776, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_0779, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_077c, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1012_077f, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_0782, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0784, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0785, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0786, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0787, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0788, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0789, 1); ret();                                  /* ret */
        }
    }
}
