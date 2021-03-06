using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f41f-d6fa7be")]
        public void my_fopen()
        {
            ii(0x100e_f41f, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_f424, 5);  call(Definitions.sys_check_available_stack_size, 0x7_6929);/* call 0x10165d52 */
            ii(0x100e_f429, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_f42a, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_f42b, 1);  push(esi);                            /* push esi */
            ii(0x100e_f42c, 1);  push(edi);                            /* push edi */
            ii(0x100e_f42d, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_f42e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_f430, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_f436, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_f439, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_f43c, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_f43f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_f442, 5);  call(Definitions.sys_fopen, 0x8_2f33);/* call 0x1017237a */
            ii(0x100e_f447, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_f44a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_f44d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_f44f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_f450, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_f451, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_f452, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_f453, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_f454, 1);  ret();                                /* ret */
        }
    }
}
