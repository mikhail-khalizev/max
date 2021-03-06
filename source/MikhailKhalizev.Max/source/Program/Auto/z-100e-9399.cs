using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_9399-af6f9c3d")]
        public void Method_100e_9399()
        {
            ii(0x100e_9399, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_939e, 5);  call(Definitions.sys_check_available_stack_size, 0x7_c9af);/* call 0x10165d52 */
            ii(0x100e_93a3, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_93a4, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_93a5, 1);  push(edx);                            /* push edx */
            ii(0x100e_93a6, 1);  push(esi);                            /* push esi */
            ii(0x100e_93a7, 1);  push(edi);                            /* push edi */
            ii(0x100e_93a8, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_93a9, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_93ab, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100e_93b1, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_93b4, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_93b8, 5);  mov(edx, 0x101b_dec0);                /* mov edx, 0x101bdec0 */
            ii(0x100e_93bd, 5);  mov(eax, memd[ds, 0x101c_365c]);      /* mov eax, [0x101c365c] */
            ii(0x100e_93c2, 5);  call(/* sys */ 0x1016_cb28, 0x8_3761);/* call 0x1016cb28 */
            ii(0x100e_93c7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_93c9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_93ca, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_93cb, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_93cc, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_93cd, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_93ce, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_93cf, 1);  ret();                                /* ret */
        }
    }
}
