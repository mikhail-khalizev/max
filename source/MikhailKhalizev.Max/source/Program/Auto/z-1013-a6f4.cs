using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_a6f4-4c7a8826")]
        public void Method_1013_a6f4()
        {
            ii(0x1013_a6f4, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_a6f9, 5);  call(Definitions.sys_check_available_stack_size, 0x2_b654);/* call 0x10165d52 */
            ii(0x1013_a6fe, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_a6ff, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_a700, 1);  push(edx);                            /* push edx */
            ii(0x1013_a701, 1);  push(esi);                            /* push esi */
            ii(0x1013_a702, 1);  push(edi);                            /* push edi */
            ii(0x1013_a703, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_a704, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_a706, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_a70c, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
        l_0x1013_a70f:
            ii(0x1013_a70f, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a711, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a714, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a717, 5);  call(0x1013_ad71, 0x655);             /* call 0x1013ad71 */
            ii(0x1013_a71c, 2);  test(al, al);                         /* test al, al */
            ii(0x1013_a71e, 2);  if(jz(0x1013_a776, 0x56)) goto l_0x1013_a776;/* jz 0x1013a776 */
            ii(0x1013_a720, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a723, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a726, 5);  call(0x1013_aa3c, 0x311);             /* call 0x1013aa3c */
            ii(0x1013_a72b, 3);  lea(edx, memd[ds, eax + 10]);         /* lea edx, [eax+0xa] */
            ii(0x1013_a72e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a731, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_a734, 5);  call(0x1013_aa70, 0x337);             /* call 0x1013aa70 */
            ii(0x1013_a739, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a73b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a73e, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a741, 5);  call(0x1013_aa3c, 0x2f6);             /* call 0x1013aa3c */
            ii(0x1013_a746, 3);  add(eax, 0xe);                        /* add eax, 0xe */
            ii(0x1013_a749, 5);  call(0x1007_6c98, -0xc_3ab6);         /* call 0x10076c98 */
            ii(0x1013_a74e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a750, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a753, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a756, 5);  call(0x1013_aa3c, 0x2e1);             /* call 0x1013aa3c */
            ii(0x1013_a75b, 3);  add(eax, 0xa);                        /* add eax, 0xa */
            ii(0x1013_a75e, 5);  call(0x1007_6c98, -0xc_3acb);         /* call 0x10076c98 */
            ii(0x1013_a763, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_a766, 3);  add(edx, 6);                          /* add edx, 0x6 */
            ii(0x1013_a769, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a76c, 3);  add(eax, 2);                          /* add eax, 0x2 */
            ii(0x1013_a76f, 5);  call(0x1013_aa70, 0x2fc);             /* call 0x1013aa70 */
            ii(0x1013_a774, 2);  jmp(0x1013_a70f, -0x67); goto l_0x1013_a70f;/* jmp 0x1013a70f */
        l_0x1013_a776:
            ii(0x1013_a776, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1013_a778, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a77b, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1013_a77e, 5);  call(0x1007_6c98, -0xc_3aeb);         /* call 0x10076c98 */
            ii(0x1013_a783, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_a786, 5);  mov(memw[ds, eax], 0);                /* mov word [eax], 0x0 */
            ii(0x1013_a78b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_a78d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_a78e, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_a78f, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_a790, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_a791, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_a792, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_a793, 1);  ret();                                /* ret */
        }
    }
}
