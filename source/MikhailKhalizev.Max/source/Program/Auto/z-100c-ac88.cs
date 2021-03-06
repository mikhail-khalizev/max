using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_ac88-17bd7e39")]
        public void Method_100c_ac88()
        {
            ii(0x100c_ac88, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100c_ac8d, 5);  call(Definitions.sys_check_available_stack_size, 0x9_b0c0);/* call 0x10165d52 */
            ii(0x100c_ac92, 1);  push(ebx);                            /* push ebx */
            ii(0x100c_ac93, 1);  push(ecx);                            /* push ecx */
            ii(0x100c_ac94, 1);  push(edx);                            /* push edx */
            ii(0x100c_ac95, 1);  push(esi);                            /* push esi */
            ii(0x100c_ac96, 1);  push(edi);                            /* push edi */
            ii(0x100c_ac97, 1);  push(ebp);                            /* push ebp */
            ii(0x100c_ac98, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100c_ac9a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100c_aca0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100c_aca3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100c_aca6, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x100c_aca8, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100c_acab, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100c_acae, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100c_acb0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100c_acb1, 1);  pop(edi);                             /* pop edi */
            ii(0x100c_acb2, 1);  pop(esi);                             /* pop esi */
            ii(0x100c_acb3, 1);  pop(edx);                             /* pop edx */
            ii(0x100c_acb4, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100c_acb5, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100c_acb6, 1);  ret();                                /* ret */
        }
    }
}
