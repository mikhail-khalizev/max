using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_57e9-102eca85")]
        public void Method_1014_57e9()
        {
            ii(0x1014_57e9, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_57ee, 5);  call(Definitions.sys_check_available_stack_size, 0x2_055f);/* call 0x10165d52 */
            ii(0x1014_57f3, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_57f4, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_57f5, 1);  push(esi);                            /* push esi */
            ii(0x1014_57f6, 1);  push(edi);                            /* push edi */
            ii(0x1014_57f7, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_57f8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_57fa, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_5800, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5803, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_5806, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_5809, 5);  call(0x1014_7c80, 0x2472);            /* call 0x10147c80 */
            ii(0x1014_580e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_5811, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_5814, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_5816, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_5817, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5818, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5819, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_581a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_581b, 1);  ret();                                /* ret */
        }
    }
}
