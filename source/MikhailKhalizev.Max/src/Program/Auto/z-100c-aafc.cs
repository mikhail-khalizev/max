using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aafc-e811498a")]
        public void Method_100c_aafc()
        {
            ii(0x100c_aafc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_ab01, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b24c);/* call 0x10165d52 */
            ii(0x100c_ab06, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_ab07, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ab08, 1);  push(esi);                            /* push esi */
            ii(0x100c_ab09, 1);  push(edi);                            /* push edi */
            ii(0x100c_ab0a, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ab0b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ab0d, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_ab13, 3);  mov(memb[ss, ebp - 4], al);           /* mov [ebp-0x4], al */
            ii(0x100c_ab16, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_ab19, 3);  mov(ebx, memd[ss, ebp - 8]);          /* mov ebx, [ebp-0x8] */
            ii(0x100c_ab1c, 4);  movsx(edx, memb[ss, ebp - 4]);        /* movsx edx, byte [ebp-0x4] */
            ii(0x100c_ab20, 5);  mov(eax, 0x101c_39c8);                /* mov eax, 0x101c39c8 */
            ii(0x100c_ab25, 5);  call(0x1010_610a, 0x3_b5e0);          /* call 0x1010610a */
            ii(0x100c_ab2a, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_ab2d, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_ab30, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_ab32, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_ab33, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_ab34, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_ab35, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_ab36, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_ab37, 1);  ret();                                /* ret */
        }
    }
}
