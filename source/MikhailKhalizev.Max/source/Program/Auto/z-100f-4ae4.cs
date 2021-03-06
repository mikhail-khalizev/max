using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_4ae4-de43284a")]
        public void Method_100f_4ae4()
        {
            ii(0x100f_4ae4, 5);  push(0x1c);                           /* push 0x1c */
            ii(0x100f_4ae9, 5);  call(Definitions.sys_check_available_stack_size, 0x7_1264);/* call 0x10165d52 */
            ii(0x100f_4aee, 1);  push(ebx);                            /* push ebx */
            ii(0x100f_4aef, 1);  push(ecx);                            /* push ecx */
            ii(0x100f_4af0, 1);  push(edx);                            /* push edx */
            ii(0x100f_4af1, 1);  push(esi);                            /* push esi */
            ii(0x100f_4af2, 1);  push(edi);                            /* push edi */
            ii(0x100f_4af3, 1);  push(ebp);                            /* push ebp */
            ii(0x100f_4af4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100f_4af6, 6);  sub(esp, 0);                          /* sub esp, 0x0 */
            ii(0x100f_4afc, 2);  xor(edx, edx);                        /* xor edx, edx */
            ii(0x100f_4afe, 5);  mov(eax, memd[ds, 0x101b_877d]);      /* mov eax, [0x101b877d] */
            ii(0x100f_4b03, 5);  call(0x100c_fb73, -0x2_4f95);         /* call 0x100cfb73 */
            ii(0x100f_4b08, 7);  mov(memb[ds, 0x101c_3911], 0);        /* mov byte [0x101c3911], 0x0 */
            ii(0x100f_4b0f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100f_4b10, 1);  pop(edi);                             /* pop edi */
            ii(0x100f_4b11, 1);  pop(esi);                             /* pop esi */
            ii(0x100f_4b12, 1);  pop(edx);                             /* pop edx */
            ii(0x100f_4b13, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100f_4b14, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100f_4b15, 1);  ret();                                /* ret */
        }
    }
}
