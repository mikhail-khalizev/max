using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_a74c-6dfc2c04")]
        public void Method_100c_a74c()
        {
            ii(0x100c_a74c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_a751, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b5fc);/* call 0x10165d52 */
            ii(0x100c_a756, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_a757, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_a758, 1);  push(esi);                            /* push esi */
            ii(0x100c_a759, 1);  push(edi);                            /* push edi */
            ii(0x100c_a75a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_a75b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_a75d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_a763, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a766, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_a769, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100c_a770, 2);  if(jz(0x100c_a786, 0x14)) goto l_0x100c_a786;/* jz 0x100ca786 */
            ii(0x100c_a772, 5);  mov(edx, 0x101b_5698);                /* mov edx, 0x101b5698 */
            ii(0x100c_a777, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a77a, 5);  call(Definitions.sys_call_dtor_arr, 0x9_b839);/* call 0x10165fb8 */
            ii(0x100c_a77f, 5);  call(Definitions.sys_delete_arr, 0x9_b854);/* call 0x10165fd8 */
            ii(0x100c_a784, 2);  jmp(0x100c_a7a7, 0x21); goto l_0x100c_a7a7;/* jmp 0x100ca7a7 */
        l_0x100c_a786:
            ii(0x100c_a786, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100c_a78b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a78e, 5);  call(0x100a_284c, -0x2_7f47);         /* call 0x100a284c */
            ii(0x100c_a793, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_a796, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100c_a79d, 2);  if(jz(0x100c_a7a7, 8)) goto l_0x100c_a7a7;/* jz 0x100ca7a7 */
            ii(0x100c_a79f, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a7a2, 5);  call(Definitions.sys_delete, 0x9_b7bd);/* call 0x10165f64 */
        l_0x100c_a7a7:
            ii(0x100c_a7a7, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_a7aa, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_a7ad, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_a7b0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_a7b2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_a7b3, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_a7b4, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_a7b5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_a7b6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_a7b7, 1);  ret();                                /* ret */
        }
    }
}
