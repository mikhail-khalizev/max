using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_4373-e32b34d5")]
        public void Method_100e_4373()
        {
            ii(0x100e_4373, 5);  push(0x3c);                           /* push 0x3c */
            ii(0x100e_4378, 5);  call(Definitions.sys_check_available_stack_size, 0x8_19d5);/* call 0x10165d52 */
            ii(0x100e_437d, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_437e, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_437f, 1);  push(edx);                            /* push edx */
            ii(0x100e_4380, 1);  push(esi);                            /* push esi */
            ii(0x100e_4381, 1);  push(edi);                            /* push edi */
            ii(0x100e_4382, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_4383, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_4385, 6);  sub(esp, 0x20);                       /* sub esp, 0x20 */
            ii(0x100e_438b, 5);  mov(ebx, 0x1c);                       /* mov ebx, 0x1c */
            ii(0x100e_4390, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100e_4392, 3);  lea(eax, memd[ss, ebp - 32]);         /* lea eax, [ebp-0x20] */
            ii(0x100e_4395, 5);  call(Definitions.sys_memset, 0x8_1a46);/* call 0x10165de0 */
            ii(0x100e_439a, 7);  mov(memd[ss, ebp - 32], 0x100);       /* mov dword [ebp-0x20], 0x100 */
            ii(0x100e_43a1, 7);  mov(memd[ss, ebp - 28], 0xffff);      /* mov dword [ebp-0x1c], 0xffff */
            ii(0x100e_43a8, 3);  lea(ebx, memd[ss, ebp - 32]);         /* lea ebx, [ebp-0x20] */
            ii(0x100e_43ab, 3);  lea(edx, memd[ss, ebp - 32]);         /* lea edx, [ebp-0x20] */
            ii(0x100e_43ae, 5);  mov(eax, 0x31);                       /* mov eax, 0x31 */
            ii(0x100e_43b3, 5);  call(/* sys */ 0x1016_c606, 0x8_824e);/* call 0x1016c606 */
            ii(0x100e_43b8, 4);  cmp(memd[ss, ebp - 8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100e_43bc, 2);  if(jz(0x100e_43ce, 0x10)) goto l_0x100e_43ce;/* jz 0x100e43ce */
            ii(0x100e_43be, 3);  mov(eax, memd[ss, ebp - 28]);         /* mov eax, [ebp-0x1c] */
            ii(0x100e_43c1, 5);  and(eax, 0xffff);                     /* and eax, 0xffff */
            ii(0x100e_43c6, 3);  shl(eax, 4);                          /* shl eax, 0x4 */
            ii(0x100e_43c9, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_43cc, 2);  jmp(0x100e_43d5, 7); goto l_0x100e_43d5;/* jmp 0x100e43d5 */
        l_0x100e_43ce:
            ii(0x100e_43ce, 7);  mov(memd[ss, ebp - 4], 0xa_0000);     /* mov dword [ebp-0x4], 0xa0000 */
        l_0x100e_43d5:
            ii(0x100e_43d5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_43d8, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_43da, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_43db, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_43dc, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_43dd, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_43de, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_43df, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_43e0, 1);  ret();                                /* ret */
        }
    }
}
