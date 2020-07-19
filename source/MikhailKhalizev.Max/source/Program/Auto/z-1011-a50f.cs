using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_a50f-c7259ac3")]
        public void Method_1011_a50f()
        {
            ii(0x1011_a50f, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_a514, 5);  call(Definitions.sys_check_available_stack_size, 0x4_b839);/* call 0x10165d52 */
            ii(0x1011_a519, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_a51a, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_a51b, 1);  push(esi);                            /* push esi */
            ii(0x1011_a51c, 1);  push(edi);                            /* push edi */
            ii(0x1011_a51d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_a51e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_a520, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_a526, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_a529, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_a52c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a52f, 4);  cmp(memb[ds, eax + 62], 5);           /* cmp byte [eax+0x3e], 0x5 */
            ii(0x1011_a533, 2);  if(jnz(0x1011_a548, 0x13)) goto l_0x1011_a548;/* jnz 0x1011a548 */
            ii(0x1011_a535, 5);  call(0x1012_0a90, 0x6556);            /* call 0x10120a90 */
            ii(0x1011_a53a, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_a53c, 2);  mov(dl, al);                          /* mov dl, al */
            ii(0x1011_a53e, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_a541, 5);  call(0x1014_f017, 0x3_4ad1);          /* call 0x1014f017 */
            ii(0x1011_a546, 2);  jmp(0x1011_a568, 0x20); goto l_0x1011_a568;/* jmp 0x1011a568 */
        l_0x1011_a548:
            ii(0x1011_a548, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a54b, 6);  mov(memw[ds, eax + 22], 0);           /* mov word [eax+0x16], 0x0 */
            ii(0x1011_a551, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a554, 3);  add(eax, 0x18);                       /* add eax, 0x18 */
            ii(0x1011_a557, 5);  call(0x1012_0b8c, 0x6630);            /* call 0x10120b8c */
            ii(0x1011_a55c, 2);  xor(ebx, ebx);                        /* xor ebx, ebx */
            ii(0x1011_a55e, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x1011_a560, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_a563, 5);  call(0x1011_aca3, 0x73b);             /* call 0x1011aca3 */
        l_0x1011_a568:
            ii(0x1011_a568, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_a56a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_a56b, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_a56c, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_a56d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_a56e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_a56f, 1);  ret();                                /* ret */
        }
    }
}
