using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5164-280d8cf6")]
        public void Method_100d_5164()
        {
            ii(0x100d_5164, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_5169, 5);  call(Definitions.sys_check_available_stack_size, 0x9_0be4);/* call 0x10165d52 */
            ii(0x100d_516e, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_516f, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_5170, 1);  push(esi);                            /* push esi */
            ii(0x100d_5171, 1);  push(edi);                            /* push edi */
            ii(0x100d_5172, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_5173, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_5175, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_517b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_517e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_5181, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_5184, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_5187, 3);  mov(memd[ds, edx + 28], eax);         /* mov [edx+0x1c], eax */
            ii(0x100d_518a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_518c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_518d, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_518e, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_518f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5190, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5191, 1);  ret();                                /* ret */
        }
    }
}
