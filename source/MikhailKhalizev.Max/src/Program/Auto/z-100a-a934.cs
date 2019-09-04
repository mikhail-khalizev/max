using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a934-11d84e81")]
        public void Method_100a_a934()
        {
            ii(0x100a_a934, 5); push(0x24);                             /* push 0x24 */
            ii(0x100a_a939, 5); call(Definitions.sys_check_available_stack_size, 0xb_b414); /* call 0x10165d52 */
            ii(0x100a_a93e, 1); push(ebx);                              /* push ebx */
            ii(0x100a_a93f, 1); push(ecx);                              /* push ecx */
            ii(0x100a_a940, 1); push(esi);                              /* push esi */
            ii(0x100a_a941, 1); push(edi);                              /* push edi */
            ii(0x100a_a942, 1); push(ebp);                              /* push ebp */
            ii(0x100a_a943, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_a945, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_a94b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100a_a94e, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100a_a951, 4); movsx(edx, memw[ss, ebp - 4]);          /* movsx edx, word [ebp-0x4] */
            ii(0x100a_a955, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_a958, 5); call(0x100a_b494, 0xb37);               /* call 0x100ab494 */
            ii(0x100a_a95d, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_a960, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_a963, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_a965, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_a966, 1); pop(edi);                               /* pop edi */
            ii(0x100a_a967, 1); pop(esi);                               /* pop esi */
            ii(0x100a_a968, 1); pop(ecx);                               /* pop ecx */
            ii(0x100a_a969, 1); pop(ebx);                               /* pop ebx */
            ii(0x100a_a96a, 1); ret();                                  /* ret */
        }
    }
}
