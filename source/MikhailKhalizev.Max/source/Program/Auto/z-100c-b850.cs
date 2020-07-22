using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_b850-aa2c9c27")]
        public void Method_100c_b850()
        {
            ii(0x100c_b850, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_b855, 5);  call(Definitions.sys_check_available_stack_size, 0x9_a4f8);/* call 0x10165d52 */
            ii(0x100c_b85a, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_b85b, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_b85c, 1);  push(esi);                            /* push esi */
            ii(0x100c_b85d, 1);  push(edi);                            /* push edi */
            ii(0x100c_b85e, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_b85f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_b861, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_b867, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_b86a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_b86d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100c_b870, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_b873, 5);  call(0x1013_acc5, 0x6_f44d);          /* call 0x1013acc5 */
            ii(0x100c_b878, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_b87b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_b87e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_b880, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_b881, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_b882, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_b883, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_b884, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_b885, 1);  ret();                                /* ret */
        }
    }
}
