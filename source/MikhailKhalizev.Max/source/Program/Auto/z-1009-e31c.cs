using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e31c-b6442a5d")]
        public void Method_1009_e31c()
        {
            ii(0x1009_e31c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_e321, 5);  call(Definitions.sys_check_available_stack_size, 0xc_7a2c);/* call 0x10165d52 */
            ii(0x1009_e326, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_e327, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e328, 1);  push(edx);                            /* push edx */
            ii(0x1009_e329, 1);  push(esi);                            /* push esi */
            ii(0x1009_e32a, 1);  push(edi);                            /* push edi */
            ii(0x1009_e32b, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e32c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e32e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_e334, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_e337, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e339, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e33c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e33f, 5);  call(0x1013_ad11, 0x9_c9cd);          /* call 0x1013ad11 */
            ii(0x1009_e344, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e346, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e348, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e34b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e34e, 5);  call(0x1013_ad71, 0x9_ca1e);          /* call 0x1013ad71 */
            ii(0x1009_e353, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_e355, 2);  if(jz(0x1009_e3a4, 0x4d)) goto l_0x1009_e3a4;/* jz 0x1009e3a4 */
            ii(0x1009_e357, 5);  call(0x1008_ac50, -0x1_370c);         /* call 0x1008ac50 */
            ii(0x1009_e35c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_e35e, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1009_e360, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e363, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e366, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e369, 5);  call(0x1007_6574, -0x2_7dfa);         /* call 0x10076574 */
            ii(0x1009_e36e, 5);  call(0x1015_2962, 0xb_45ef);          /* call 0x10152962 */
            ii(0x1009_e373, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e375, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e378, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_e37b, 5);  call(0x1007_6630, -0x2_7d50);         /* call 0x10076630 */
            ii(0x1009_e380, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_e382, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e385, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1009_e388, 5);  call(0x1008_afe4, -0x1_33a9);         /* call 0x1008afe4 */
            ii(0x1009_e38d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e390, 7);  mov(memd[ds, eax + 27], 0);           /* mov dword [eax+0x1b], 0x0 */
            ii(0x1009_e397, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_e39a, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_e39f, 5);  call(0x100a_5e27, 0x7a83);            /* call 0x100a5e27 */
        l_0x1009_e3a4:
            ii(0x1009_e3a4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e3a6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e3a7, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e3a8, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e3a9, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_e3aa, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e3ab, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_e3ac, 1);  ret();                                /* ret */
        }
    }
}
