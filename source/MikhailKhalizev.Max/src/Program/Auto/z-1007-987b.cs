using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_987b-37fb76e8")]
        public void Method_1007_987b()
        {
            ii(0x1007_987b, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_9880, 5); call(Definitions.sys_check_available_stack_size, 0xe_c4cd); /* call 0x10165d52 */
            ii(0x1007_9885, 1); push(ebx);                              /* push ebx */
            ii(0x1007_9886, 1); push(ecx);                              /* push ecx */
            ii(0x1007_9887, 1); push(edx);                              /* push edx */
            ii(0x1007_9888, 1); push(esi);                              /* push esi */
            ii(0x1007_9889, 1); push(edi);                              /* push edi */
            ii(0x1007_988a, 1); push(ebp);                              /* push ebp */
            ii(0x1007_988b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_988d, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_9893, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_9896, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9899, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1007_989c, 5); call(0x1013_a794, 0xc_0ef3);            /* call 0x1013a794 */
            ii(0x1007_98a1, 3); sub(eax, 0x6);                          /* sub eax, 0x6 */
            ii(0x1007_98a4, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_98a7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_98aa, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_98ac, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_98ad, 1); pop(edi);                               /* pop edi */
            ii(0x1007_98ae, 1); pop(esi);                               /* pop esi */
            ii(0x1007_98af, 1); pop(edx);                               /* pop edx */
            ii(0x1007_98b0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_98b1, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_98b2, 1); ret();                                  /* ret */
        }
    }
}
