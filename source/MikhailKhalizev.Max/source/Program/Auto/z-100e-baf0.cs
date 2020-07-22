using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_baf0-39ad73de")]
        public void Method_100e_baf0()
        {
            ii(0x100e_baf0, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100e_baf5, 5);  call(Definitions.sys_check_available_stack_size, 0x7_a258);/* call 0x10165d52 */
            ii(0x100e_bafa, 1);  push(ebx);                            /* push ebx */
            ii(0x100e_bafb, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_bafc, 1);  push(edx);                            /* push edx */
            ii(0x100e_bafd, 1);  push(esi);                            /* push esi */
            ii(0x100e_bafe, 1);  push(edi);                            /* push edi */
            ii(0x100e_baff, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_bb00, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_bb02, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100e_bb08, 5);  mov(ecx, 0xc7);                       /* mov ecx, 0xc7 */
            ii(0x100e_bb0d, 5);  mov(ebx, 0xac);                       /* mov ebx, 0xac */
            ii(0x100e_bb12, 5);  mov(edx, 0xa2);                       /* mov edx, 0xa2 */
            ii(0x100e_bb17, 5);  mov(eax, 0x101c_367c);                /* mov eax, 0x101c367c */
            ii(0x100e_bb1c, 5);  call(0x100d_53a4, -0x1_677d);         /* call 0x100d53a4 */
            ii(0x100e_bb21, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_bb22, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_bb23, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_bb24, 1);  pop(edx);                             /* pop edx */
            ii(0x100e_bb25, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_bb26, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100e_bb27, 1);  ret();                                /* ret */
        }
    }
}
