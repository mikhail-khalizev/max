using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_5826-1927519f")]
        public void Method_100b_5826()
        {
            ii(0x100b_5826, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_582b, 5);  call(Definitions.sys_check_available_stack_size, 0xb_0522);/* call 0x10165d52 */
            ii(0x100b_5830, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_5831, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_5832, 1);  push(edx);                            /* push edx */
            ii(0x100b_5833, 1);  push(esi);                            /* push esi */
            ii(0x100b_5834, 1);  push(edi);                            /* push edi */
            ii(0x100b_5835, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_5836, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_5838, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100b_583e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_5841, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_5844, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5847, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_584a, 5);  call(0x1007_6574, -0x3_f2db);         /* call 0x10076574 */
            ii(0x100b_584f, 5);  call(0x1015_27ed, 0x9_cf99);          /* call 0x101527ed */
            ii(0x100b_5854, 5);  call(0x1008_b0e4, -0x2_a775);         /* call 0x1008b0e4 */
            ii(0x100b_5859, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_585b, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100b_585d, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_5860, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_5863, 5);  call(0x1007_65d0, -0x3_f298);         /* call 0x100765d0 */
            ii(0x100b_5868, 5);  call(0x100a_297d, -0x1_2ef0);         /* call 0x100a297d */
            ii(0x100b_586d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_586f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_5870, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_5871, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_5872, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_5873, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_5874, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_5875, 1);  ret();                                /* ret */
        }
    }
}
