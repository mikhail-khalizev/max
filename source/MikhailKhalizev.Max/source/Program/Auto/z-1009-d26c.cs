using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_d26c-b808675c")]
        public void Method_1009_d26c()
        {
            ii(0x1009_d26c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_d271, 5);  call(Definitions.sys_check_available_stack_size, 0xc_8adc);/* call 0x10165d52 */
            ii(0x1009_d276, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_d277, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_d278, 1);  push(edx);                            /* push edx */
            ii(0x1009_d279, 1);  push(esi);                            /* push esi */
            ii(0x1009_d27a, 1);  push(edi);                            /* push edi */
            ii(0x1009_d27b, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_d27c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_d27e, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1009_d284, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_d287, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_d289, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d28c, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_d28f, 5);  call(0x1013_ad71, 0x9_dadd);          /* call 0x1013ad71 */
            ii(0x1009_d294, 2);  test(al, al);                         /* test al, al */
            ii(0x1009_d296, 2);  if(jz(0x1009_d2b4, 0x1c)) goto l_0x1009_d2b4;/* jz 0x1009d2b4 */
            ii(0x1009_d298, 5);  call(0x1008_ac50, -0x1_264d);         /* call 0x1008ac50 */
            ii(0x1009_d29d, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1009_d29f, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1009_d2a1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d2a4, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d2a7, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_d2aa, 5);  call(0x1007_6574, -0x2_6d3b);         /* call 0x10076574 */
            ii(0x1009_d2af, 5);  call(0x1015_2962, 0xb_56ae);          /* call 0x10152962 */
        l_0x1009_d2b4:
            ii(0x1009_d2b4, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_d2b6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d2b9, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1009_d2bc, 5);  call(0x1007_6630, -0x2_6c91);         /* call 0x10076630 */
            ii(0x1009_d2c1, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d2c4, 7);  mov(memd[ds, eax + 27], 0);           /* mov dword [eax+0x1b], 0x0 */
            ii(0x1009_d2cb, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1009_d2cd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_d2d0, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1009_d2d3, 5);  call(0x1008_afe4, -0x1_22f4);         /* call 0x1008afe4 */
            ii(0x1009_d2d8, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_d2db, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1009_d2e0, 5);  call(0x100a_5e27, 0x8b42);            /* call 0x100a5e27 */
            ii(0x1009_d2e5, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_d2e7, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_d2e8, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_d2e9, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_d2ea, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_d2eb, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_d2ec, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_d2ed, 1);  ret();                                /* ret */
        }
    }
}
