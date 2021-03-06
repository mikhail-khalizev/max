using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_e488-b6e1ce23")]
        public void Method_1009_e488()
        {
            ii(0x1009_e488, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_e48d, 5);  call(Definitions.sys_check_available_stack_size, 0xc_78c0);/* call 0x10165d52 */
            ii(0x1009_e492, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_e493, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_e494, 1);  push(edx);                            /* push edx */
            ii(0x1009_e495, 1);  push(esi);                            /* push esi */
            ii(0x1009_e496, 1);  push(edi);                            /* push edi */
            ii(0x1009_e497, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_e498, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_e49a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_e4a0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_e4a3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_e4a6, 3);  add(eax, 0x17);                       /* add eax, 0x17 */
            ii(0x1009_e4a9, 5);  call(0x1013_a794, 0x9_c2e6);          /* call 0x1013a794 */
            ii(0x1009_e4ae, 3);  sub(eax, 6);                          /* sub eax, 0x6 */
            ii(0x1009_e4b1, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_e4b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_e4b7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_e4b9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_e4ba, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_e4bb, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_e4bc, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_e4bd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_e4be, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_e4bf, 1);  ret();                                /* ret */
        }
    }
}
