using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0bfc-fd2158b5")]
        public void Method_1012_0bfc()
        {
            ii(0x1012_0bfc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_0c01, 5);  call(Definitions.sys_check_available_stack_size, 0x4_514c);/* call 0x10165d52 */
            ii(0x1012_0c06, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_0c07, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0c08, 1);  push(edx);                            /* push edx */
            ii(0x1012_0c09, 1);  push(esi);                            /* push esi */
            ii(0x1012_0c0a, 1);  push(edi);                            /* push edi */
            ii(0x1012_0c0b, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0c0c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0c0e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_0c14, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_0c17, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_0c1a, 4);  mov(ax, memw[ds, eax + 10]);          /* mov ax, [eax+0xa] */
            ii(0x1012_0c1e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0c21, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0c24, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_0c26, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_0c27, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0c28, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0c29, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_0c2a, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0c2b, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0c2c, 1);  ret();                                /* ret */
        }
    }
}
