using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_87dc-6a9ca1dc")]
        public void Method_100e_87dc()
        {
            ii(0x100e_87dc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x100e_87e1, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d56c);/* call 0x10165d52 */
            ii(0x100e_87e6, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_87e7, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_87e8, 1);  push(edx);                            /* push edx */
            ii(0x100e_87e9, 1);  push(esi);                            /* push esi */
            ii(0x100e_87ea, 1);  push(edi);                            /* push edi */
            ii(0x100e_87eb, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_87ec, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_87ee, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100e_87f4, 5);  mov(eax, 0x101b_7f50);                /* mov eax, 0x101b7f50 */
            ii(0x100e_87f9, 5);  call(/* sys */ 0x1016_611f, 0x7_d921);/* call 0x1016611f */
            ii(0x100e_87fe, 5);  mov(eax, 0x101c_3664);                /* mov eax, 0x101c3664 */
            ii(0x100e_8803, 5);  call(0x100e_acb0, 0x24a8);            /* call 0x100eacb0 */
            ii(0x100e_8808, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_880b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_880e, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100e_8811, 10);  mov(memd[ds, 0x101b_7f58], 1);       /* mov dword [0x101b7f58], 0x1 */
            ii(0x100e_881b, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x100e_8820, 5);  mov(ebx, 0xaf);                       /* mov ebx, 0xaf */
            ii(0x100e_8825, 5);  mov(edx, 0xa5);                       /* mov edx, 0xa5 */
            ii(0x100e_882a, 5);  mov(eax, 0x101c_3678);                /* mov eax, 0x101c3678 */
            ii(0x100e_882f, 5);  call(0x100d_53a4, -0x1_3490);         /* call 0x100d53a4 */
            ii(0x100e_8834, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_8836, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_8837, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_8838, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_8839, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_883a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_883b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_883c, 1);  ret();                                /* ret */
        }
    }
}
