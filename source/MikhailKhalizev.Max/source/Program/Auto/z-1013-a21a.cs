using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a21a-7d1c97e7")]
        public void Method_1013_a21a()
        {
            ii(0x1013_a21a, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1013_a21f, 5);  call(Definitions.sys_check_available_stack_size, 0x2_bb2e);/* call 0x10165d52 */
            ii(0x1013_a224, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_a225, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_a226, 1);  push(esi);                            /* push esi */
            ii(0x1013_a227, 1);  push(edi);                            /* push edi */
            ii(0x1013_a228, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_a229, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_a22b, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1013_a231, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_a234, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_a237, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x1013_a23a, 3);  add(edx, 2);                          /* add edx, 0x2 */
            ii(0x1013_a23d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a240, 5);  call(0x1007_6cd0, -0xc_3575);         /* call 0x10076cd0 */
            ii(0x1013_a245, 2);  jmp(0x1013_a24f, 8); goto l_0x1013_a24f;/* jmp 0x1013a24f */
        l_0x1013_a247:
            ii(0x1013_a247, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a24a, 5);  call(0x1007_6bf8, -0xc_3657);         /* call 0x10076bf8 */
        l_0x1013_a24f:
            ii(0x1013_a24f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a251, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a254, 5);  call(0x1013_ad71, 0xb18);             /* call 0x1013ad71 */
            ii(0x1013_a259, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a25b, 2);  if(jz(0x1013_a283, 0x26)) goto l_0x1013_a283;/* jz 0x1013a283 */
            ii(0x1013_a25d, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a260, 5);  call(0x1007_6c30, -0xc_3635);         /* call 0x10076c30 */
            ii(0x1013_a265, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1013_a268, 2);  if(jnz(0x1013_a281, 0x17)) goto l_0x1013_a281;/* jnz 0x1013a281 */
            ii(0x1013_a26a, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a26d, 5);  call(0x1007_6c68, -0xc_360a);         /* call 0x10076c68 */
            ii(0x1013_a272, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_a275, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a277, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a27a, 5);  call(0x1007_5e24, -0xc_445b);         /* call 0x10075e24 */
            ii(0x1013_a27f, 2);  jmp(0x1013_a2a0, 0x1f); goto l_0x1013_a2a0;/* jmp 0x1013a2a0 */
        l_0x1013_a281:
            ii(0x1013_a281, 2);  jmp(0x1013_a247, -0x3c); goto l_0x1013_a247;/* jmp 0x1013a247 */
        l_0x1013_a283:
            ii(0x1013_a283, 7);  mov(memd[ss, ebp - 16], 0);           /* mov dword [ebp-0x10], 0x0 */
            ii(0x1013_a28a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a28c, 3);  lea(eax, memd[ss, ebp - 12]);         /* lea eax, [ebp-0xc] */
            ii(0x1013_a28f, 5);  call(0x1007_5e24, -0xc_4470);         /* call 0x10075e24 */
            ii(0x1013_a294, 2);  jmp(0x1013_a2a0, 0xa); goto l_0x1013_a2a0;/* jmp 0x1013a2a0 */
        //  ii(0x1013_a296, 10);  Недостижимый код.
        l_0x1013_a2a0:
            ii(0x1013_a2a0, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_a2a3, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_a2a5, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_a2a6, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_a2a7, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_a2a8, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_a2a9, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_a2aa, 1);  ret();                                /* ret */
        }
    }
}
