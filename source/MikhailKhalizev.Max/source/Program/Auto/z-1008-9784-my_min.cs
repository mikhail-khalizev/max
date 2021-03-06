using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9784-943a947c")]
        public void my_min()
        {
            ii(0x1008_9784, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_9789, 5);  call(Definitions.sys_check_available_stack_size, 0xd_c5c4);/* call 0x10165d52 */
            ii(0x1008_978e, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_978f, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_9790, 1);  push(esi);                            /* push esi */
            ii(0x1008_9791, 1);  push(edi);                            /* push edi */
            ii(0x1008_9792, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_9793, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_9795, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x1008_979b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_979e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_97a1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_97a4, 3);  cmp(eax, memd[ss, ebp - 4]);          /* cmp eax, [ebp-0x4] */
            ii(0x1008_97a7, 2);  if(jle(0x1008_97b1, 8)) goto l_0x1008_97b1;/* jle 0x100897b1 */
            ii(0x1008_97a9, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_97ac, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_97af, 2);  jmp(0x1008_97b7, 6); goto l_0x1008_97b7;/* jmp 0x100897b7 */
        l_0x1008_97b1:
            ii(0x1008_97b1, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_97b4, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
        l_0x1008_97b7:
            ii(0x1008_97b7, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_97ba, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_97bd, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_97c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_97c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_97c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_97c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_97c5, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_97c6, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_97c7, 1);  ret();                                /* ret */
        }
    }
}
