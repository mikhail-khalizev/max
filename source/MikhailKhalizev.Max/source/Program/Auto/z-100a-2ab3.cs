using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2ab3-109ad73e")]
        public void Method_100a_2ab3()
        {
            ii(0x100a_2ab3, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_2ab8, 5);  call(Definitions.sys_check_available_stack_size, 0xc_3295);/* call 0x10165d52 */
            ii(0x100a_2abd, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_2abe, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_2abf, 1);  push(edx);                            /* push edx */
            ii(0x100a_2ac0, 1);  push(esi);                            /* push esi */
            ii(0x100a_2ac1, 1);  push(edi);                            /* push edi */
            ii(0x100a_2ac2, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_2ac3, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_2ac5, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_2acb, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_2ace, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100a_2ad1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100a_2ad4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2ad7, 3);  mov(edx, memd[ds, eax + 2]);          /* mov edx, [eax+0x2] */
            ii(0x100a_2ada, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_2add, 3);  call_abs(memd[ds, edx + 60]);         /* call dword [edx+0x3c] */
            ii(0x100a_2ae0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_2ae2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_2ae3, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_2ae4, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_2ae5, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_2ae6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_2ae7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_2ae8, 1);  ret();                                /* ret */
        }
    }
}
