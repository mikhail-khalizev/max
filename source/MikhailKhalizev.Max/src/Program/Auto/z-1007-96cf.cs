using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_96cf-1369121e")]
        public void Method_1007_96cf()
        {
            ii(0x1007_96cf, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_96d4, 5);  call(Definitions.sys_check_available_stack_size, 0xe_c679);/* call 0x10165d52 */
            ii(0x1007_96d9, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_96da, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_96db, 1);  push(edx);                            /* push edx */
            ii(0x1007_96dc, 1);  push(esi);                            /* push esi */
            ii(0x1007_96dd, 1);  push(edi);                            /* push edi */
            ii(0x1007_96de, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_96df, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_96e1, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_96e7, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_96ea, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_96ed, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_96f0, 5);  call(0x1007_6338, -0x33bd);           /* call 0x10076338 */
            ii(0x1007_96f5, 3);  lea(ebx, memd[ss, ebp - 8]);          /* lea ebx, [ebp-0x8] */
            ii(0x1007_96f8, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_96fa, 2);  mov(eax, ebx);                        /* mov eax, ebx */
            ii(0x1007_96fc, 5);  call(0x1007_64b8, -0x3249);           /* call 0x100764b8 */
            ii(0x1007_9701, 2);  jmp(0x1007_970b, 8); goto l_0x1007_970b;/* jmp 0x1007970b */
        l_0x1007_9703:
            ii(0x1007_9703, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_9706, 5);  call(0x1007_6bf8, -0x2b13);           /* call 0x10076bf8 */
        l_0x1007_970b:
            ii(0x1007_970b, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_970d, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_9710, 5);  call(0x1013_ad71, 0xc_165c);          /* call 0x1013ad71 */
            ii(0x1007_9715, 2);  test(al, al);                         /* test al, al */
            ii(0x1007_9717, 2);  if(jz(0x1007_9738, 0x1f)) goto l_0x1007_9738;/* jz 0x10079738 */
            ii(0x1007_9719, 5);  call(0x1008_a79c, 0x1_107e);          /* call 0x1008a79c */
            ii(0x1007_971e, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1007_9720, 2);  mov(bl, al);                          /* mov bl, al */
            ii(0x1007_9722, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_9725, 5);  call(0x1007_63d4, -0x3356);           /* call 0x100763d4 */
            ii(0x1007_972a, 2);  mov(edx, eax);                        /* mov edx, eax */
            ii(0x1007_972c, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_9731, 5);  call(0x100a_53ac, 0x2_bc76);          /* call 0x100a53ac */
            ii(0x1007_9736, 2);  jmp(0x1007_9703, -0x35); goto l_0x1007_9703;/* jmp 0x10079703 */
        l_0x1007_9738:
            ii(0x1007_9738, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_973b, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x1007_973e, 5);  call(0x1013_a6f4, 0xc_0fb1);          /* call 0x1013a6f4 */
            ii(0x1007_9743, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_9745, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_9748, 3);  add(eax, 0xf);                        /* add eax, 0xf */
            ii(0x1007_974b, 5);  call(0x1008_afe4, 0x1_1894);          /* call 0x1008afe4 */
            ii(0x1007_9750, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_9753, 5);  mov(eax, 0x101c_3180);                /* mov eax, 0x101c3180 */
            ii(0x1007_9758, 5);  call(0x100a_5e27, 0x2_c6ca);          /* call 0x100a5e27 */
            ii(0x1007_975d, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1007_975f, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x1007_9762, 5);  call(0x1007_5f6c, -0x37fb);           /* call 0x10075f6c */
            ii(0x1007_9767, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_9769, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_976a, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_976b, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_976c, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_976d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_976e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_976f, 1);  ret();                                /* ret */
        }
    }
}
