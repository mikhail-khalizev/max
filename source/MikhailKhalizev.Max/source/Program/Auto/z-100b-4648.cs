using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4648-c853e353")]
        public void Method_100b_4648()
        {
            ii(0x100b_4648, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100b_464d, 5);  call(Definitions.sys_check_available_stack_size, 0xb_1700);/* call 0x10165d52 */
            ii(0x100b_4652, 1);  push(ebx);                            /* push ebx */
            ii(0x100b_4653, 1);  push(ecx);                            /* push ecx */
            ii(0x100b_4654, 1);  push(edx);                            /* push edx */
            ii(0x100b_4655, 1);  push(esi);                            /* push esi */
            ii(0x100b_4656, 1);  push(edi);                            /* push edi */
            ii(0x100b_4657, 1);  push(ebp);                            /* push ebp */
            ii(0x100b_4658, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100b_465a, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100b_4660, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_4663, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4666, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_4669, 5);  call(0x1007_6574, -0x3_e0fa);         /* call 0x10076574 */
            ii(0x100b_466e, 5);  call(0x1007_623c, -0x3_e437);         /* call 0x1007623c */
            ii(0x100b_4673, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100b_4676, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100b_4679, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_467b, 2);  if(jle(0x100b_4690, 0x13)) goto l_0x100b_4690;/* jle 0x100b4690 */
            ii(0x100b_467d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_4680, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4683, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_4686, 5);  call(0x1007_6574, -0x3_e117);         /* call 0x10076574 */
            ii(0x100b_468b, 5);  call(0x1015_27ed, 0x9_e15d);          /* call 0x101527ed */
        l_0x100b_4690:
            ii(0x100b_4690, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_4693, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_4696, 5);  call(0x1007_6574, -0x3_e127);         /* call 0x10076574 */
            ii(0x100b_469b, 5);  call(0x1007_623c, -0x3_e464);         /* call 0x1007623c */
            ii(0x100b_46a0, 3);  mov(eax, memd[ds, eax + 14]);         /* mov eax, [eax+0xe] */
            ii(0x100b_46a3, 3);  sar(eax, 0x10);                       /* sar eax, 0x10 */
            ii(0x100b_46a6, 2);  test(eax, eax);                       /* test eax, eax */
            ii(0x100b_46a8, 2);  if(jle(0x100b_46bd, 0x13)) goto l_0x100b_46bd;/* jle 0x100b46bd */
            ii(0x100b_46aa, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100b_46ad, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_46b0, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x100b_46b3, 5);  call(0x1007_6574, -0x3_e144);         /* call 0x10076574 */
            ii(0x100b_46b8, 5);  call(0x1015_27ed, 0x9_e130);          /* call 0x101527ed */
        l_0x100b_46bd:
            ii(0x100b_46bd, 5);  call(0x1008_b0e4, -0x2_95de);         /* call 0x1008b0e4 */
            ii(0x100b_46c2, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100b_46c4, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x100b_46c6, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100b_46c9, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100b_46cc, 5);  call(0x1007_65d0, -0x3_e101);         /* call 0x100765d0 */
            ii(0x100b_46d1, 5);  call(0x100a_297d, -0x1_1d59);         /* call 0x100a297d */
            ii(0x100b_46d6, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100b_46d8, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100b_46d9, 1);  pop(edi);                             /* pop edi */
            ii(0x100b_46da, 1);  pop(esi);                             /* pop esi */
            ii(0x100b_46db, 1);  pop(edx);                             /* pop edx */
            ii(0x100b_46dc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100b_46dd, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100b_46de, 1);  ret();                                /* ret */
        }
    }
}
