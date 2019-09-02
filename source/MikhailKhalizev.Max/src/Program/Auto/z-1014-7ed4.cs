using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_7ed4-86e69b5b")]
        public void Method_1014_7ed4()
        {
            ii(0x1014_7ed4, 5); push(0x28);                             /* push 0x28 */
            ii(0x1014_7ed9, 5); call(Definitions.sys_check_available_stack_size, 0x1_de74); /* call 0x10165d52 */
            ii(0x1014_7ede, 1); push(ebx);                              /* push ebx */
            ii(0x1014_7edf, 1); push(ecx);                              /* push ecx */
            ii(0x1014_7ee0, 1); push(edx);                              /* push edx */
            ii(0x1014_7ee1, 1); push(esi);                              /* push esi */
            ii(0x1014_7ee2, 1); push(edi);                              /* push edi */
            ii(0x1014_7ee3, 1); push(ebp);                              /* push ebp */
            ii(0x1014_7ee4, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_7ee6, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_7eec, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_7eef, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7ef2, 5); call(0x1013_a0af, -0xde48);             /* call 0x1013a0af */
            ii(0x1014_7ef7, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1014_7efa, 3); lea(eax, memd[ss, ebp - 4]);            /* lea eax, [ebp-0x4] */
            ii(0x1014_7efd, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1014_7f00, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1014_7f03, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1014_7f06, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1014_7f09, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_7f0b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_7f0c, 1); pop(edi);                               /* pop edi */
            ii(0x1014_7f0d, 1); pop(esi);                               /* pop esi */
            ii(0x1014_7f0e, 1); pop(edx);                               /* pop edx */
            ii(0x1014_7f0f, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_7f10, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_7f11, 1); ret();                                  /* ret */
        }
    }
}
