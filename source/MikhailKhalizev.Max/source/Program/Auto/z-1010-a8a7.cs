using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_a8a7-3298b747")]
        public void Method_1010_a8a7()
        {
            ii(0x1010_a8a7, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1010_a8ac, 5);  call(Definitions.sys_check_available_stack_size, 0x5_b4a1);/* call 0x10165d52 */
            ii(0x1010_a8b1, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_a8b2, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_a8b3, 1);  push(edx);                            /* push edx */
            ii(0x1010_a8b4, 1);  push(esi);                            /* push esi */
            ii(0x1010_a8b5, 1);  push(edi);                            /* push edi */
            ii(0x1010_a8b6, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_a8b7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_a8b9, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1010_a8bf, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_a8c2, 5);  mov(edx, 3);                          /* mov edx, 0x3 */
            ii(0x1010_a8c7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a8ca, 5);  call(0x1010_a26b, -0x664);            /* call 0x1010a26b */
            ii(0x1010_a8cf, 5);  mov(eax, 0x49);                       /* mov eax, 0x49 */
            ii(0x1010_a8d4, 5);  call(0x1007_5fdc, -0x9_48fd);         /* call 0x10075fdc */
            ii(0x1010_a8d9, 3);  movsx(ecx, ax);                       /* movsx ecx, ax */
            ii(0x1010_a8dc, 5);  mov(ebx, 0x1d);                       /* mov ebx, 0x1d */
            ii(0x1010_a8e1, 5);  mov(edx, 2);                          /* mov edx, 0x2 */
            ii(0x1010_a8e6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_a8e9, 5);  call(0x1010_a36e, -0x580);            /* call 0x1010a36e */
            ii(0x1010_a8ee, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_a8f0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_a8f1, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_a8f2, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_a8f3, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_a8f4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_a8f5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_a8f6, 1);  ret();                                /* ret */
        }
    }
}
