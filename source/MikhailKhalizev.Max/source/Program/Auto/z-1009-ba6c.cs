using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ba6c-a3e8bdeb")]
        public void Method_1009_ba6c()
        {
            ii(0x1009_ba6c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_ba71, 5);  call(Definitions.sys_check_available_stack_size, 0xc_a2dc);/* call 0x10165d52 */
            ii(0x1009_ba76, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_ba77, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_ba78, 1);  push(esi);                            /* push esi */
            ii(0x1009_ba79, 1);  push(edi);                            /* push edi */
            ii(0x1009_ba7a, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_ba7b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_ba7d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_ba83, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ba86, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_ba89, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_ba8e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ba91, 5);  call(0x1007_5e24, -0x2_5c72);         /* call 0x10075e24 */
            ii(0x1009_ba96, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_ba99, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_ba9c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_ba9f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_baa2, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_baa4, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_baa5, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_baa6, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_baa7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_baa8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_baa9, 1);  ret();                                /* ret */
        }
    }
}
