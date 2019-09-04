using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_433c-292453dd")]
        public void Method_100e_433c()
        {
            ii(0x100e_433c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_4341, 5);  call(Definitions.sys_check_available_stack_size, 0x8_1a0c);/* call 0x10165d52 */
            ii(0x100e_4346, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_4347, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_4348, 1);  push(edx);                            /* push edx */
            ii(0x100e_4349, 1);  push(esi);                            /* push esi */
            ii(0x100e_434a, 1);  push(edi);                            /* push edi */
            ii(0x100e_434b, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_434c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_434e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_4354, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_4357, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_435a, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x100e_435e, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x100e_4361, 3);  sub(ax, memw[ds, edx]);               /* sub ax, [edx] */
            ii(0x100e_4364, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_4367, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_436a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_436c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_436d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_436e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_436f, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_4370, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_4371, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_4372, 1);  ret();                                /* ret */
        }
    }
}
