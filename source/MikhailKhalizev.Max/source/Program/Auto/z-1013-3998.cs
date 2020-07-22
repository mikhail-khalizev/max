using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3998-1fb87e13")]
        public void Method_1013_3998()
        {
            ii(0x1013_3998, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_399d, 5);  call(Definitions.sys_check_available_stack_size, 0x3_23b0);/* call 0x10165d52 */
            ii(0x1013_39a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_39a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_39a4, 1);  push(edx);                            /* push edx */
            ii(0x1013_39a5, 1);  push(esi);                            /* push esi */
            ii(0x1013_39a6, 1);  push(edi);                            /* push edi */
            ii(0x1013_39a7, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_39a8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_39aa, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_39b0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_39b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_39b6, 4);  mov(ax, memw[ds, eax + 5]);           /* mov ax, [eax+0x5] */
            ii(0x1013_39ba, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_39bd, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_39c0, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_39c2, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_39c3, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_39c4, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_39c5, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_39c6, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_39c7, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_39c8, 1);  ret();                                /* ret */
        }
    }
}
