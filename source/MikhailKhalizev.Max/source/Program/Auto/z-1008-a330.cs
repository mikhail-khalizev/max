using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_a330-2ff6c19c")]
        public void Method_1008_a330()
        {
            ii(0x1008_a330, 5);  push(0x28);                           /* push 0x28 */
            ii(0x1008_a335, 5);  call(Definitions.sys_check_available_stack_size, 0xd_ba18);/* call 0x10165d52 */
            ii(0x1008_a33a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_a33b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_a33c, 1);  push(edx);                            /* push edx */
            ii(0x1008_a33d, 1);  push(esi);                            /* push esi */
            ii(0x1008_a33e, 1);  push(edi);                            /* push edi */
            ii(0x1008_a33f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_a340, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_a342, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1008_a348, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a34b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a34e, 5);  call(Definitions.my_ctor_0x101b_6edc, -0x1_350f);/* call 0x10076e44 */
            ii(0x1008_a353, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_a356, 3);  lea(eax, memd[ss, ebp - 4]);          /* lea eax, [ebp-0x4] */
            ii(0x1008_a359, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_a35c, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_a35f, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1008_a362, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1008_a365, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_a367, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_a368, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_a369, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_a36a, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_a36b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_a36c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_a36d, 1);  ret();                                /* ret */
        }
    }
}
