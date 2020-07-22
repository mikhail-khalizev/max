using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_a5c8-c1347cc4")]
        public void Method_100a_a5c8()
        {
            ii(0x100a_a5c8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_a5cd, 5);  call(Definitions.sys_check_available_stack_size, 0xb_b780);/* call 0x10165d52 */
            ii(0x100a_a5d2, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_a5d3, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_a5d4, 1);  push(esi);                            /* push esi */
            ii(0x100a_a5d5, 1);  push(edi);                            /* push edi */
            ii(0x100a_a5d6, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_a5d7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_a5d9, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100a_a5df, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a5e2, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100a_a5e5, 7);  test(memd[ss, ebp - 4], 4);           /* test dword [ebp-0x4], 0x4 */
            ii(0x100a_a5ec, 2);  if(jz(0x100a_a605, 0x17)) goto l_0x100a_a605;/* jz 0x100aa605 */
            ii(0x100a_a5ee, 5);  mov(edx, 0x101b_4ccc);                /* mov edx, 0x101b4ccc */
            ii(0x100a_a5f3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a5f6, 5);  call(Definitions.sys_call_dtor_arr, 0xb_b9bd);/* call 0x10165fb8 */
            ii(0x100a_a5fb, 5);  call(Definitions.sys_delete_arr, 0xb_b9d8);/* call 0x10165fd8 */
            ii(0x100a_a600, 5);  jmp(0x100a_a685, 0x80); goto l_0x100a_a685;/* jmp 0x100aa685 */
        l_0x100a_a605:
            ii(0x100a_a605, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a607, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a60a, 3);  add(eax, 0x4e);                       /* add eax, 0x4e */
            ii(0x100a_a60d, 5);  call(0x1007_5f2c, -0x3_46e6);         /* call 0x10075f2c */
            ii(0x100a_a612, 3);  sub(eax, 0x4e);                       /* sub eax, 0x4e */
            ii(0x100a_a615, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a618, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a61a, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a61d, 3);  add(eax, 0x3e);                       /* add eax, 0x3e */
            ii(0x100a_a620, 5);  call(0x100a_a3c0, -0x265);            /* call 0x100aa3c0 */
            ii(0x100a_a625, 3);  sub(eax, 0x3e);                       /* sub eax, 0x3e */
            ii(0x100a_a628, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a62b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a62d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a630, 3);  add(eax, 0x2e);                       /* add eax, 0x2e */
            ii(0x100a_a633, 5);  call(0x100a_a3c0, -0x278);            /* call 0x100aa3c0 */
            ii(0x100a_a638, 3);  sub(eax, 0x2e);                       /* sub eax, 0x2e */
            ii(0x100a_a63b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a63e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a640, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a643, 3);  add(eax, 0x1e);                       /* add eax, 0x1e */
            ii(0x100a_a646, 5);  call(0x100a_a55c, -0xef);             /* call 0x100aa55c */
            ii(0x100a_a64b, 3);  sub(eax, 0x1e);                       /* sub eax, 0x1e */
            ii(0x100a_a64e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a651, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100a_a653, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a656, 3);  add(eax, 0x14);                       /* add eax, 0x14 */
            ii(0x100a_a659, 5);  call(0x100a_a4d4, -0x18a);            /* call 0x100aa4d4 */
            ii(0x100a_a65e, 3);  sub(eax, 0x14);                       /* sub eax, 0x14 */
            ii(0x100a_a661, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a664, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x100a_a669, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a66c, 5);  call(0x100a_284c, -0x7e25);           /* call 0x100a284c */
            ii(0x100a_a671, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_a674, 7);  test(memd[ss, ebp - 4], 2);           /* test dword [ebp-0x4], 0x2 */
            ii(0x100a_a67b, 2);  if(jz(0x100a_a685, 8)) goto l_0x100a_a685;/* jz 0x100aa685 */
            ii(0x100a_a67d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a680, 5);  call(Definitions.sys_delete, 0xb_b8df);/* call 0x10165f64 */
        l_0x100a_a685:
            ii(0x100a_a685, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_a688, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100a_a68b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100a_a68e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_a690, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_a691, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_a692, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_a693, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_a694, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_a695, 1);  ret();                                /* ret */
        }
    }
}
