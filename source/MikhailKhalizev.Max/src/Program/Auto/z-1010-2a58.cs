using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_2a58-1913267b")]
        public void Method_1010_2a58()
        {
            ii(0x1010_2a58, 5); push(0x24);                             /* push 0x24 */
            ii(0x1010_2a5d, 5); call(Definitions.sys_check_available_stack_size, 0x6_32f0); /* call 0x10165d52 */
            ii(0x1010_2a62, 1); push(ebx);                              /* push ebx */
            ii(0x1010_2a63, 1); push(ecx);                              /* push ecx */
            ii(0x1010_2a64, 1); push(edx);                              /* push edx */
            ii(0x1010_2a65, 1); push(esi);                              /* push esi */
            ii(0x1010_2a66, 1); push(edi);                              /* push edi */
            ii(0x1010_2a67, 1); push(ebp);                              /* push ebp */
            ii(0x1010_2a68, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_2a6a, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_2a70, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_2a73, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_2a76, 5); call(0x1007_6c30, -0x8_be4b);           /* call 0x10076c30 */
            ii(0x1010_2a7b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_2a7e, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_2a81, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_2a83, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_2a84, 1); pop(edi);                               /* pop edi */
            ii(0x1010_2a85, 1); pop(esi);                               /* pop esi */
            ii(0x1010_2a86, 1); pop(edx);                               /* pop edx */
            ii(0x1010_2a87, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_2a88, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_2a89, 1); ret();                                  /* ret */
        }
    }
}
