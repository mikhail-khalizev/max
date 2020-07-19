using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6f2d-eec9d013")]
        public void Method_100d_6f2d()
        {
            ii(0x100d_6f2d, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_6f32, 5);  call(Definitions.sys_check_available_stack_size, 0x8_ee1b);/* call 0x10165d52 */
            ii(0x100d_6f37, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_6f38, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_6f39, 1);  push(esi);                            /* push esi */
            ii(0x100d_6f3a, 1);  push(edi);                            /* push edi */
            ii(0x100d_6f3b, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_6f3c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_6f3e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_6f44, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_6f47, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_6f4a, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6f4d, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_6f50, 4);  mov(memw[ds, edx + 4], ax);           /* mov [edx+0x4], ax */
            ii(0x100d_6f54, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_6f56, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_6f57, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_6f58, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_6f59, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_6f5a, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_6f5b, 1);  ret();                                /* ret */
        }
    }
}
