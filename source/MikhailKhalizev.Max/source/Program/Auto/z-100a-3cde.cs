using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_3cde-3bb37ed2")]
        public void Method_100a_3cde()
        {
            ii(0x100a_3cde, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_3ce3, 5);  call(Definitions.sys_check_available_stack_size, 0xc_206a);/* call 0x10165d52 */
            ii(0x100a_3ce8, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_3ce9, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_3cea, 1);  push(edx);                            /* push edx */
            ii(0x100a_3ceb, 1);  push(esi);                            /* push esi */
            ii(0x100a_3cec, 1);  push(edi);                            /* push edi */
            ii(0x100a_3ced, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_3cee, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_3cf0, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_3cf6, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_3cf9, 7);  mov(memd[ss, ebp - 8], 3);            /* mov dword [ebp-0x8], 0x3 */
            ii(0x100a_3d00, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_3d03, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_3d05, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_3d06, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_3d07, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_3d08, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_3d09, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_3d0a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_3d0b, 1);  ret();                                /* ret */
        }
    }
}
