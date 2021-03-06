using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4ab2-92f5253d")]
        public void Method_100f_4ab2()
        {
            ii(0x100f_4ab2, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100f_4ab7, 5);  call(Definitions.sys_check_available_stack_size, 0x7_1296);/* call 0x10165d52 */
            ii(0x100f_4abc, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_4abd, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_4abe, 1);  push(edx);                            /* push edx */
            ii(0x100f_4abf, 1);  push(esi);                            /* push esi */
            ii(0x100f_4ac0, 1);  push(edi);                            /* push edi */
            ii(0x100f_4ac1, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_4ac2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_4ac4, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100f_4aca, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_4acc, 5);  mov(eax, memd[ds, 0x101b_876f]);      /* mov eax, [0x101b876f] */
            ii(0x100f_4ad1, 5);  call(0x100c_fb73, -0x2_4f63);         /* call 0x100cfb73 */
            ii(0x100f_4ad6, 7);  mov(memb[ds, 0x101c_3911], 1);        /* mov byte [0x101c3911], 0x1 */
            ii(0x100f_4add, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_4ade, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_4adf, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_4ae0, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_4ae1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_4ae2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_4ae3, 1);  ret();                                /* ret */
        }
    }
}
