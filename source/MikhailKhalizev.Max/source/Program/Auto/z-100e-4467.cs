using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4467-cd2ca65a")]
        public void Method_100e_4467()
        {
            ii(0x100e_4467, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100e_446c, 5);  call(Definitions.sys_check_available_stack_size, 0x8_18e1);/* call 0x10165d52 */
            ii(0x100e_4471, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_4472, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_4473, 1);  push(edx);                            /* push edx */
            ii(0x100e_4474, 1);  push(esi);                            /* push esi */
            ii(0x100e_4475, 1);  push(edi);                            /* push edi */
            ii(0x100e_4476, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_4477, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_4479, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_447f, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_4482, 5);  mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
            ii(0x100e_4487, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_4489, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_448c, 5);  call(Definitions.sys_memset, 0x8_194f);/* call 0x10165de0 */
            ii(0x100e_4491, 7);  mov(memd[ss, ebp - 32], 0x101);       /* mov dword [ebp-0x20], 0x101 */
            ii(0x100e_4498, 2);  xor(eax, eax);                        /* xor eax, eax */
            ii(0x100e_449a, 4);  mov(ax, memw[ss, ebp - 4]);           /* mov ax, [ebp-0x4] */
            ii(0x100e_449e, 3);  mov(memd[ss, ebp - 28], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100e_44a1, 3);  lea(ebx, memd[ss, ebp - 32]);         /* lea ebx, [ebp-0x20] */
            ii(0x100e_44a4, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100e_44a7, 5);  mov(eax, 0x31);                       /* mov eax, 0x31 */
            ii(0x100e_44ac, 5);  call(/* sys */ 0x1016_c606, 0x8_8155);/* call 0x1016c606 */
            ii(0x100e_44b1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_44b3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_44b4, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_44b5, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_44b6, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_44b7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_44b8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_44b9, 1);  ret();                                /* ret */
        }
    }
}
