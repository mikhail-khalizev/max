using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_aeac-2be5d269")]
        public void Method_100c_aeac()
        {
            ii(0x100c_aeac, 5);  push(0x28);                           /* push 0x28 */
            ii(0x100c_aeb1, 5);  call(Definitions.sys_check_available_stack_size, 0x9_ae9c);/* call 0x10165d52 */
            ii(0x100c_aeb6, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_aeb7, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_aeb8, 1);  push(esi);                            /* push esi */
            ii(0x100c_aeb9, 1);  push(edi);                            /* push edi */
            ii(0x100c_aeba, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_aebb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_aebd, 6);  sub(esp, 0x10);                       /* sub esp, 0x10 */
            ii(0x100c_aec3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_aec6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100c_aec9, 5);  mov(ebx, 3);                          /* mov ebx, 0x3 */
            ii(0x100c_aece, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100c_aed2, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_aed5, 5);  call(0x1013_af3b, 0x7_0061);          /* call 0x1013af3b */
            ii(0x100c_aeda, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_aedd, 3);  lea(eax, memd[ss, ebp - 8]);          /* lea eax, [ebp-0x8] */
            ii(0x100c_aee0, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100c_aee3, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_aee6, 3);  mov(memd[ss, ebp - 16], eax);         /* mov [ebp-0x10], eax */
            ii(0x100c_aee9, 3);  mov(eax, memd[ss, ebp - 16]);         /* mov eax, [ebp-0x10] */
            ii(0x100c_aeec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_aeee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_aeef, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_aef0, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_aef1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_aef2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_aef3, 1);  ret();                                /* ret */
        }
    }
}
