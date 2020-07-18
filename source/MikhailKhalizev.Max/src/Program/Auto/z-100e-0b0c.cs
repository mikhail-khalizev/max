using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_0b0c-bf292724")]
        public void Method_100e_0b0c()
        {
            ii(0x100e_0b0c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_0b11, 5);  call(Definitions.sys_check_available_stack_size, 0x8_523c);/* call 0x10165d52 */
            ii(0x100e_0b16, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_0b17, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_0b18, 1);  push(edx);                            /* push edx */
            ii(0x100e_0b19, 1);  push(esi);                            /* push esi */
            ii(0x100e_0b1a, 1);  push(edi);                            /* push edi */
            ii(0x100e_0b1b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_0b1c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_0b1e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_0b24, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_0b27, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_0b2a, 4);  mov(ax, memw[ds, eax + 4]);           /* mov ax, [eax+0x4] */
            ii(0x100e_0b2e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_0b31, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_0b34, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_0b36, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_0b37, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_0b38, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_0b39, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_0b3a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_0b3b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_0b3c, 1);  ret();                                /* ret */
        }
    }
}
