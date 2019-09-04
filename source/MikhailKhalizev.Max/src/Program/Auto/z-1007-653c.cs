using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_653c-e952e7ba")]
        public void Method_1007_653c()
        {
            ii(0x1007_653c, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1007_6541, 5);  call(Definitions.sys_check_available_stack_size, 0xe_f80c);/* call 0x10165d52 */
            ii(0x1007_6546, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_6547, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_6548, 1);  push(edx);                            /* push edx */
            ii(0x1007_6549, 1);  push(esi);                            /* push esi */
            ii(0x1007_654a, 1);  push(edi);                            /* push edi */
            ii(0x1007_654b, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_654c, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_654e, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_6554, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6557, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_655a, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1007_655d, 5);  call(0x1007_6dd0, 0x86e);             /* call 0x10076dd0 */
            ii(0x1007_6562, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6565, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6568, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_656a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_656b, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_656c, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_656d, 1);  pop(edx);                             /* pop edx */
            ii(0x1007_656e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_656f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_6570, 1);  ret();                                /* ret */
        }
    }
}
