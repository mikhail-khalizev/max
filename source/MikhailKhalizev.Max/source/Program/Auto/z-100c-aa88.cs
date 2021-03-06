using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aa88-f21f9460")]
        public void Method_100c_aa88()
        {
            ii(0x100c_aa88, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100c_aa8d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b2c0);/* call 0x10165d52 */
            ii(0x100c_aa92, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_aa93, 1);  push(esi);                            /* push esi */
            ii(0x100c_aa94, 1);  push(edi);                            /* push edi */
            ii(0x100c_aa95, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_aa96, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_aa98, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100c_aa9e, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_aaa1, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100c_aaa4, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100c_aaa7, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100c_aaab, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100c_aaae, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100c_aab1, 5);  call(0x1008_b410, -0x3_f6a6);         /* call 0x1008b410 */
            ii(0x100c_aab6, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x100c_aab9, 5);  call(0x100c_d990, 0x2ed2);            /* call 0x100cd990 */
            ii(0x100c_aabe, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_aac0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_aac1, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_aac2, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_aac3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_aac4, 1);  ret();                                /* ret */
        }
    }
}
