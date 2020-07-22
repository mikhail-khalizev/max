using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_619a-34dc23eb")]
        public void Method_100a_619a()
        {
            ii(0x100a_619a, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_619f, 5);  call(Definitions.sys_check_available_stack_size, 0xb_fbae);/* call 0x10165d52 */
            ii(0x100a_61a4, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_61a5, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_61a6, 1);  push(edx);                            /* push edx */
            ii(0x100a_61a7, 1);  push(esi);                            /* push esi */
            ii(0x100a_61a8, 1);  push(edi);                            /* push edi */
            ii(0x100a_61a9, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_61aa, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_61ac, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_61b2, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_61b5, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_61b8, 3);  add(eax, 0x13);                       /* add eax, 0x13 */
            ii(0x100a_61bb, 5);  call(Definitions.my_2_get_count, -0x1_ae58);/* call 0x1008b368 */
            ii(0x100a_61c0, 1);  cwde();                               /* cwde */
            ii(0x100a_61c1, 2);  add(eax, eax);                        /* add eax, eax */
            ii(0x100a_61c3, 3);  add(eax, 4);                          /* add eax, 0x4 */
            ii(0x100a_61c6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_61c9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_61cc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_61ce, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_61cf, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_61d0, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_61d1, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_61d2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_61d3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_61d4, 1);  ret();                                /* ret */
        }
    }
}
