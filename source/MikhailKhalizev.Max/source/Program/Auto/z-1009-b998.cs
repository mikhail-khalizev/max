using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_b998-1333efbc")]
        public void Method_1009_b998()
        {
            ii(0x1009_b998, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_b99d, 5);  call(Definitions.sys_check_available_stack_size, 0xc_a3b0);/* call 0x10165d52 */
            ii(0x1009_b9a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_b9a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_b9a4, 1);  push(esi);                            /* push esi */
            ii(0x1009_b9a5, 1);  push(edi);                            /* push edi */
            ii(0x1009_b9a6, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_b9a7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_b9a9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_b9af, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b9b2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_b9b5, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_b9b7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b9ba, 3);  add(eax, 0x15);                       /* add eax, 0x15 */
            ii(0x1009_b9bd, 5);  call(0x1007_5f2c, -0x2_5a96);         /* call 0x10075f2c */
            ii(0x1009_b9c2, 3);  sub(eax, 0x15);                       /* sub eax, 0x15 */
            ii(0x1009_b9c5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b9c8, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1009_b9cd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b9d0, 5);  call(0x100a_284c, 0x6e77);            /* call 0x100a284c */
            ii(0x1009_b9d5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_b9d8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_b9db, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_b9de, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_b9e1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_b9e3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_b9e4, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_b9e5, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_b9e6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_b9e7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_b9e8, 1);  ret();                                /* ret */
        }
    }
}
