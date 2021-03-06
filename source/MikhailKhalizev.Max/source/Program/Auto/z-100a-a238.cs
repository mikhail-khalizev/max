using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a238-4c4b3e52")]
        public void Method_100a_a238()
        {
            ii(0x100a_a238, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_a23d, 5);  call(Definitions.sys_check_available_stack_size, 0xb_bb10);/* call 0x10165d52 */
            ii(0x100a_a242, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_a243, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_a244, 1);  push(esi);                            /* push esi */
            ii(0x100a_a245, 1);  push(edi);                            /* push edi */
            ii(0x100a_a246, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_a247, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_a249, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_a24f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a252, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_a255, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a25c, 2);  if(jz(0x100a_a272, 0x14)) goto l_0x100a_a272;/* jz 0x100aa272 */
            ii(0x100a_a25e, 5);  mov(edx, 0x101b_4c68);                /* mov edx, 0x101b4c68 */
            ii(0x100a_a263, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a266, 5);  call(Definitions.sys_call_dtor_arr, 0xb_bd4d);/* call 0x10165fb8 */
            ii(0x100a_a26b, 5);  call(Definitions.sys_delete_arr, 0xb_bd68);/* call 0x10165fd8 */
            ii(0x100a_a270, 2);  jmp(0x100a_a2a6, 0x34); goto l_0x100a_a2a6;/* jmp 0x100aa2a6 */
        l_0x100a_a272:
            ii(0x100a_a272, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a274, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a277, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100a_a27a, 5);  call(0x1007_5f2c, -0x3_4353);         /* call 0x10075f2c */
            ii(0x100a_a27f, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x100a_a282, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a285, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_a28a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a28d, 5);  call(0x100a_36c9, -0x6bc9);           /* call 0x100a36c9 */
            ii(0x100a_a292, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a295, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a29c, 2);  if(jz(0x100a_a2a6, 8)) goto l_0x100a_a2a6;/* jz 0x100aa2a6 */
            ii(0x100a_a29e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a2a1, 5);  call(Definitions.sys_delete, 0xb_bcbe);/* call 0x10165f64 */
        l_0x100a_a2a6:
            ii(0x100a_a2a6, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a2a9, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_a2ac, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_a2af, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_a2b1, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_a2b2, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_a2b3, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_a2b4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_a2b5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_a2b6, 1);  ret();                                /* ret */
        }
    }
}
