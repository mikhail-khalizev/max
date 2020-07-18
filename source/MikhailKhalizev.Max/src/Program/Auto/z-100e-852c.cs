using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_852c-664b395a")]
        public void Method_100e_852c()
        {
            ii(0x100e_852c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_8531, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d81c);/* call 0x10165d52 */
            ii(0x100e_8536, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8537, 1);  push(esi);                            /* push esi */
            ii(0x100e_8538, 1);  push(edi);                            /* push edi */
            ii(0x100e_8539, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_853a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_853c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_8542, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_8545, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_8548, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_854b, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_854f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_8552, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_8555, 5);  call(0x100c_d990, -0x1_abca);         /* call 0x100cd990 */
            ii(0x100e_855a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_855c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_855d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_855e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_855f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_8560, 1);  ret();                                /* ret */
        }
    }
}
