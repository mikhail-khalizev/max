using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4259-737b03fb")]
        public void Method_1016_4259()
        {
            ii(0x1016_4259, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1016_425e, 5);  call(Definitions.sys_check_available_stack_size, 0x1aef);/* call 0x10165d52 */
            ii(0x1016_4263, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_4264, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_4265, 1);  push(esi);                            /* push esi */
            ii(0x1016_4266, 1);  push(edi);                            /* push edi */
            ii(0x1016_4267, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_4268, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_426a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1016_4270, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_4273, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1016_4276, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_4279, 4);  inc(memw[ds, eax + 18]);              /* inc word [eax+0x12] */
            ii(0x1016_427d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_427f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_4280, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_4281, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_4282, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_4283, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_4284, 1);  ret();                                /* ret */
        }
    }
}
