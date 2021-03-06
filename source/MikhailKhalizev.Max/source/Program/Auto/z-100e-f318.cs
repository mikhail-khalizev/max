using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_f318-1d0f25d")]
        public void Method_100e_f318()
        {
            ii(0x100e_f318, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_f31d, 5);  call(Definitions.sys_check_available_stack_size, 0x7_6a30);/* call 0x10165d52 */
            ii(0x100e_f322, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_f323, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_f324, 1);  push(esi);                            /* push esi */
            ii(0x100e_f325, 1);  push(edi);                            /* push edi */
            ii(0x100e_f326, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_f327, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_f329, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_f32f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_f332, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_f335, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_f338, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_f33b, 3);  mov(memd[ds, edx + 12], eax);         /* mov [edx+0xc], eax */
            ii(0x100e_f33e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_f340, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_f341, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_f342, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_f343, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_f344, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_f345, 1);  ret();                                /* ret */
        }
    }
}
