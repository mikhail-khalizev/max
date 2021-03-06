using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6bb0-6e49e8e7")]
        public void Method_1010_6bb0()
        {
            ii(0x1010_6bb0, 5);  push(0x7c);                           /* push 0x7c */
            ii(0x1010_6bb5, 5);  call(Definitions.sys_check_available_stack_size, 0x5_f198);/* call 0x10165d52 */
            ii(0x1010_6bba, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_6bbb, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6bbc, 1);  push(edx);                            /* push edx */
            ii(0x1010_6bbd, 1);  push(esi);                            /* push esi */
            ii(0x1010_6bbe, 1);  push(edi);                            /* push edi */
            ii(0x1010_6bbf, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6bc0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6bc2, 6);  sub(esp, 0x60);                       /* sub esp, 0x60 */
            ii(0x1010_6bc8, 7);  mov(memd[ss, ebp - 4], 0);            /* mov dword [ebp-0x4], 0x0 */
            ii(0x1010_6bcf, 5);  mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
            ii(0x1010_6bd4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_6bd6, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1010_6bd9, 5);  call(Definitions.sys_memset, 0x5_f202);/* call 0x10165de0 */
            ii(0x1010_6bde, 7);  mov(memd[ss, ebp - 36], 0x400);       /* mov dword [ebp-0x24], 0x400 */
            ii(0x1010_6be5, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1010_6be8, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1010_6beb, 5);  mov(eax, 0x31);                       /* mov eax, 0x31 */
            ii(0x1010_6bf0, 5);  call(/* sys */ 0x1016_c606, 0x6_5a11);/* call 0x1016c606 */
            ii(0x1010_6bf5, 4);  cmp(memd[ss, ebp - 12], 0);           /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_6bf9, 2);  if(jnz(0x1010_6c53, 0x58)) goto l_0x1010_6c53;/* jnz 0x10106c53 */
            ii(0x1010_6bfb, 5);  mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
            ii(0x1010_6c00, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_6c02, 3);  lea(eax, memd[ss, ebp - 36]);         /* lea eax, [ebp-0x24] */
            ii(0x1010_6c05, 5);  call(Definitions.sys_memset, 0x5_f1d6);/* call 0x10165de0 */
            ii(0x1010_6c0a, 5);  mov(ebx, 0xc);                        /* mov ebx, 0xc */
            ii(0x1010_6c0f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1010_6c11, 3);  lea(eax, memd[ss, ebp - 48]);         /* lea eax, [ebp-0x30] */
            ii(0x1010_6c14, 5);  call(Definitions.sys_memset, 0x5_f1c7);/* call 0x10165de0 */
            ii(0x1010_6c19, 7);  mov(memd[ss, ebp - 36], 0x500);       /* mov dword [ebp-0x24], 0x500 */
            ii(0x1010_6c20, 2);  mov(ebx, ss);                         /* mov ebx, ss */
            ii(0x1010_6c22, 3);  lea(edx, memd[ss, ebp - 96]);         /* lea edx, [ebp-0x60] */
            ii(0x1010_6c25, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1010_6c27, 2);  mov(ebx, edx);                        /* mov ebx, edx */
            ii(0x1010_6c29, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1010_6c2b, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1010_6c2d, 4);  mov(memw[ss, ebp - 48], dx);          /* mov [ebp-0x30], dx */
            ii(0x1010_6c31, 3);  lea(eax, memd[ss, ebp - 96]);         /* lea eax, [ebp-0x60] */
            ii(0x1010_6c34, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_6c37, 3);  lea(ecx, memd[ss, ebp - 48]);         /* lea ecx, [ebp-0x30] */
            ii(0x1010_6c3a, 3);  lea(ebx, memd[ss, ebp - 36]);         /* lea ebx, [ebp-0x24] */
            ii(0x1010_6c3d, 3);  lea(edx, memd[ss, ebp - 36]);         /* lea edx, [ebp-0x24] */
            ii(0x1010_6c40, 5);  mov(eax, 0x31);                       /* mov eax, 0x31 */
            ii(0x1010_6c45, 5);  call(/* sys */ 0x1016_c623, 0x6_59d9);/* call 0x1016c623 */
            ii(0x1010_6c4a, 3);  mov(eax, memd[ss, ebp - 72]);         /* mov eax, [ebp-0x48] */
            ii(0x1010_6c4d, 3);  shl(eax, 0xc);                        /* shl eax, 0xc */
            ii(0x1010_6c50, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1010_6c53:
            ii(0x1010_6c53, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_6c56, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_6c59, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_6c5c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_6c5e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_6c5f, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_6c60, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6c61, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_6c62, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6c63, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_6c64, 1);  ret();                                /* ret */
        }
    }
}
