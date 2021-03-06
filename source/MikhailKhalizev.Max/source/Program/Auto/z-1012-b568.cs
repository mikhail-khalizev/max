using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_b568-3a3314b6")]
        public void Method_1012_b568()
        {
            ii(0x1012_b568, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_b56d, 5);  call(Definitions.sys_check_available_stack_size, 0x3_a7e0);/* call 0x10165d52 */
            ii(0x1012_b572, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_b573, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_b574, 1);  push(edx);                            /* push edx */
            ii(0x1012_b575, 1);  push(esi);                            /* push esi */
            ii(0x1012_b576, 1);  push(edi);                            /* push edi */
            ii(0x1012_b577, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_b578, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_b57a, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_b580, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_b583, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_b586, 4);  mov(ax, memw[ds, eax + 20]);          /* mov ax, [eax+0x14] */
            ii(0x1012_b58a, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_b58d, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_b590, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_b592, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_b593, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_b594, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_b595, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_b596, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_b597, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_b598, 1);  ret();                                /* ret */
        }
    }
}
