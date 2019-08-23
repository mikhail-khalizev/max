using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0908-67c275aa")]
        public void Method_1012_0908()
        {
            ii(0x1012_0908, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_090d, 5); call(Definitions.sys_check_available_stack_size, 0x4_5440); /* call 0x10165d52 */
            ii(0x1012_0912, 1); push(ebx);                              /* push ebx */
            ii(0x1012_0913, 1); push(ecx);                              /* push ecx */
            ii(0x1012_0914, 1); push(esi);                              /* push esi */
            ii(0x1012_0915, 1); push(edi);                              /* push edi */
            ii(0x1012_0916, 1); push(ebp);                              /* push ebp */
            ii(0x1012_0917, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_0919, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1012_091f, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0922, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_0925, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_0928, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_092b, 5); call(0x1013_acc5, 0x1_a395);            /* call 0x1013acc5 */
            ii(0x1012_0930, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1012_0933, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_0936, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_0938, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_0939, 1); pop(edi);                               /* pop edi */
            ii(0x1012_093a, 1); pop(esi);                               /* pop esi */
            ii(0x1012_093b, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_093c, 1); pop(ebx);                               /* pop ebx */
            ii(0x1012_093d, 1); ret();                                  /* ret */
        }
    }
}
