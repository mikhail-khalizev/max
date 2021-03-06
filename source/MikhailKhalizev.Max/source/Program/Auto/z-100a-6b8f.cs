using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_6b8f-a78eb811")]
        public void Method_100a_6b8f()
        {
            ii(0x100a_6b8f, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100a_6b94, 5);  call(Definitions.sys_check_available_stack_size, 0xb_f1b9);/* call 0x10165d52 */
            ii(0x100a_6b99, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_6b9a, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_6b9b, 1);  push(edx);                            /* push edx */
            ii(0x100a_6b9c, 1);  push(esi);                            /* push esi */
            ii(0x100a_6b9d, 1);  push(edi);                            /* push edi */
            ii(0x100a_6b9e, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_6b9f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_6ba1, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100a_6ba7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_6baa, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_6bad, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_6bb0, 5);  call(0x1009_caf8, -0xa0bd);           /* call 0x1009caf8 */
            ii(0x100a_6bb5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_6bb7, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_6bba, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x100a_6bbd, 5);  call(0x1008_afe4, -0x1_bbde);         /* call 0x1008afe4 */
            ii(0x100a_6bc2, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100a_6bc5, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x100a_6bca, 5);  call(0x100a_5e27, -0xda8);            /* call 0x100a5e27 */
            ii(0x100a_6bcf, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_6bd1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_6bd2, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_6bd3, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_6bd4, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_6bd5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_6bd6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_6bd7, 1);  ret();                                /* ret */
        }
    }
}
