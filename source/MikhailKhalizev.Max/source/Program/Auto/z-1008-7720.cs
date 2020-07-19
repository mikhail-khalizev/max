using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_7720-42d3cf5f")]
        public void Method_1008_7720()
        {
            ii(0x1008_7720, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1008_7725, 5);  call(Definitions.sys_check_available_stack_size, 0xd_e628);/* call 0x10165d52 */
            ii(0x1008_772a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_772b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_772c, 1);  push(edx);                            /* push edx */
            ii(0x1008_772d, 1);  push(esi);                            /* push esi */
            ii(0x1008_772e, 1);  push(edi);                            /* push edi */
            ii(0x1008_772f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_7730, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_7732, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1008_7738, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_773b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_773e, 5);  call(0x1008_764d, -0xf6);             /* call 0x1008764d */
            ii(0x1008_7743, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_7745, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_7746, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_7747, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_7748, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_7749, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_774a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_774b, 1);  ret();                                /* ret */
        }
    }
}
