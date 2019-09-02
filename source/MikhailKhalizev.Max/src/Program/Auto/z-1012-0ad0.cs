using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0ad0-842c8cce")]
        public void Method_1012_0ad0()
        {
            ii(0x1012_0ad0, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_0ad5, 5); call(Definitions.sys_check_available_stack_size, 0x4_5278); /* call 0x10165d52 */
            ii(0x1012_0ada, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0adb, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0adc, 1); push(esi);                              /* push esi */
            ii(0x1012_0add, 1); push(edi);                              /* push edi */
            ii(0x1012_0ade, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0adf, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0ae1, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_0ae7, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1012_0aea, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1012_0aed, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1012_0af0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1012_0af3, 5); call(0x1013_acc5, 0x1_a1cd);            /* call 0x1013acc5 */
            ii(0x1012_0af8, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1012_0afb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1012_0afe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0b00, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0b01, 1); pop(edi);                               /* pop edi */
            ii(0x1012_0b02, 1); pop(esi);                               /* pop esi */
            ii(0x1012_0b03, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_0b04, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_0b05, 1); ret();                                  /* ret */
        }
    }
}
