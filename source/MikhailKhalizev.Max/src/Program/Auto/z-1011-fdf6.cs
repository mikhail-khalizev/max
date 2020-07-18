using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_fdf6-aef8c7c2")]
        public void Method_1011_fdf6()
        {
            ii(0x1011_fdf6, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_fdfb, 5);  call(Definitions.sys_check_available_stack_size, 0x4_5f52);/* call 0x10165d52 */
            ii(0x1011_fe00, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_fe01, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_fe02, 1);  push(edx);                            /* push edx */
            ii(0x1011_fe03, 1);  push(esi);                            /* push esi */
            ii(0x1011_fe04, 1);  push(edi);                            /* push edi */
            ii(0x1011_fe05, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_fe06, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_fe08, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_fe0e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_fe11, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1011_fe14, 5);  mov(eax, 0x101c_536c);                /* mov eax, 0x101c536c */
            ii(0x1011_fe19, 5);  call(0x1011_e41a, -0x1a04);           /* call 0x1011e41a */
            ii(0x1011_fe1e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_fe20, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_fe21, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_fe22, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_fe23, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_fe24, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_fe25, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_fe26, 1);  ret();                                /* ret */
        }
    }
}
