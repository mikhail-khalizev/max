using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_b410-3ca4c83c")]
        public void Method_1008_b410()
        {
            ii(0x1008_b410, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_b415, 5);  call(Definitions.sys_check_available_stack_size, 0xd_a938);/* call 0x10165d52 */
            ii(0x1008_b41a, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_b41b, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_b41c, 1);  push(edx);                            /* push edx */
            ii(0x1008_b41d, 1);  push(esi);                            /* push esi */
            ii(0x1008_b41e, 1);  push(edi);                            /* push edi */
            ii(0x1008_b41f, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_b420, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_b422, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_b428, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_b42b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_b42e, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1008_b430, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_b433, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_b436, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_b438, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_b439, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_b43a, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_b43b, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_b43c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_b43d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_b43e, 1);  ret();                                /* ret */
        }
    }
}
