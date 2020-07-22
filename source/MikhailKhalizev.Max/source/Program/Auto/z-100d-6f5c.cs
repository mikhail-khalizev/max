using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_6f5c-bc496c01")]
        public void Method_100d_6f5c()
        {
            ii(0x100d_6f5c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100d_6f61, 5);  call(Definitions.sys_check_available_stack_size, 0x8_edec);/* call 0x10165d52 */
            ii(0x100d_6f66, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_6f67, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_6f68, 1);  push(esi);                            /* push esi */
            ii(0x100d_6f69, 1);  push(edi);                            /* push edi */
            ii(0x100d_6f6a, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_6f6b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_6f6d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x100d_6f73, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100d_6f76, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100d_6f79, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x100d_6f7c, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100d_6f7f, 4);  mov(memw[ds, edx + 2], ax);           /* mov [edx+0x2], ax */
            ii(0x100d_6f83, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_6f85, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_6f86, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_6f87, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_6f88, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_6f89, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_6f8a, 1);  ret();                                /* ret */
        }
    }
}
