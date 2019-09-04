using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6304-31e8906d")]
        public void Method_1007_6304()
        {
            ii(0x1007_6304, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6309, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fa44);/* call 0x10165d52 */
            ii(0x1007_630e, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_630f, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6310, 1);  push(edx);                            /* push edx */
            ii(0x1007_6311, 1);  push(esi);                            /* push esi */
            ii(0x1007_6312, 1);  push(edi);                            /* push edi */
            ii(0x1007_6313, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_6314, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_6316, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_631c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_631f, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6322, 5);  call(0x1007_6b20, 0x7f9);             /* call 0x10076b20 */
            ii(0x1007_6327, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_632a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_632d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_632f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_6330, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_6331, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_6332, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_6333, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_6334, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6335, 1);  ret();                                /* ret */
        }
    }
}
