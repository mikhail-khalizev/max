using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f36c-1f146795")]
        public void Method_100e_f36c()
        {
            ii(0x100e_f36c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_f371, 5);  call(Definitions.sys_check_available_stack_size, 0x7_69dc);/* call 0x10165d52 */
            ii(0x100e_f376, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_f377, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_f378, 1);  push(edx);                            /* push edx */
            ii(0x100e_f379, 1);  push(esi);                            /* push esi */
            ii(0x100e_f37a, 1);  push(edi);                            /* push edi */
            ii(0x100e_f37b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_f37c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_f37e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_f384, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_f387, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_f38a, 4);  mov(ax, memw[ds, eax + 33]);          /* mov ax, [eax+0x21] */
            ii(0x100e_f38e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_f391, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_f394, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_f396, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_f397, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_f398, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_f399, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_f39a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_f39b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_f39c, 1);  ret();                                /* ret */
        }
    }
}
