using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0c30-6b2c68a3")]
        public void Method_1012_0c30()
        {
            ii(0x1012_0c30, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_0c35, 5);  call(Definitions.sys_check_available_stack_size, 0x4_5118);/* call 0x10165d52 */
            ii(0x1012_0c3a, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_0c3b, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0c3c, 1);  push(edx);                            /* push edx */
            ii(0x1012_0c3d, 1);  push(esi);                            /* push esi */
            ii(0x1012_0c3e, 1);  push(edi);                            /* push edi */
            ii(0x1012_0c3f, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0c40, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0c42, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1012_0c48, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1012_0c4b, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1012_0c4e, 4);  mov(ax, memw[ds, eax + 8]);           /* mov ax, [eax+0x8] */
            ii(0x1012_0c52, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0c55, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0c58, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_0c5a, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_0c5b, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0c5c, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0c5d, 1);  pop(edx);                             /* pop edx */
            ii(0x1012_0c5e, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0c5f, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0c60, 1);  ret();                                /* ret */
        }
    }
}
