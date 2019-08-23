using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9906-44e30547")]
        public void Method_1015_9906()
        {
            ii(0x1015_9906, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_990b, 5); call(Definitions.sys_check_available_stack_size, 0xc442); /* call 0x10165d52 */
            ii(0x1015_9910, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9911, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9912, 1); push(esi);                              /* push esi */
            ii(0x1015_9913, 1); push(edi);                              /* push edi */
            ii(0x1015_9914, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9915, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9917, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_991d, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_9920, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1015_9923, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_9926, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1015_9929, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1015_992e, 5); call(0x100f_448c, -0x6_54a7);           /* call 0x100f448c */
            ii(0x1015_9933, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1015_9936, 5); call(0x1013_31d0, -0x2_676b);           /* call 0x101331d0 */
            ii(0x1015_993b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_993d, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_993e, 1); pop(edi);                               /* pop edi */
            ii(0x1015_993f, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9940, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9941, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9942, 1); ret();                                  /* ret */
        }
    }
}
