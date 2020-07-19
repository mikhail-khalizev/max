using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_bceb-862a5545")]
        public void Method_100a_bceb()
        {
            ii(0x100a_bceb, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100a_bcf0, 5);  call(Definitions.sys_check_available_stack_size, 0xb_a05d);/* call 0x10165d52 */
            ii(0x100a_bcf5, 1);  push(ebx);                            /* push ebx */
            ii(0x100a_bcf6, 1);  push(ecx);                            /* push ecx */
            ii(0x100a_bcf7, 1);  push(edx);                            /* push edx */
            ii(0x100a_bcf8, 1);  push(esi);                            /* push esi */
            ii(0x100a_bcf9, 1);  push(edi);                            /* push edi */
            ii(0x100a_bcfa, 1);  push(ebp);                            /* push ebp */
            ii(0x100a_bcfb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100a_bcfd, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100a_bd03, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100a_bd06, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x100a_bd0d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100a_bd10, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100a_bd12, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100a_bd13, 1);  pop(edi);                             /* pop edi */
            ii(0x100a_bd14, 1);  pop(esi);                             /* pop esi */
            ii(0x100a_bd15, 1);  pop(edx);                             /* pop edx */
            ii(0x100a_bd16, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100a_bd17, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100a_bd18, 1);  ret();                                /* ret */
        }
    }
}
