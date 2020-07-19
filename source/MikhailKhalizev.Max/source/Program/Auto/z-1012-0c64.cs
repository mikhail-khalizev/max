using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_0c64-8b03aae5")]
        public void Method_1012_0c64()
        {
            ii(0x1012_0c64, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1012_0c69, 5);  call(Definitions.sys_check_available_stack_size, 0x4_50e4);/* call 0x10165d52 */
            ii(0x1012_0c6e, 1);  push(ebx);                            /* push ebx */
            ii(0x1012_0c6f, 1);  push(ecx);                            /* push ecx */
            ii(0x1012_0c70, 1);  push(esi);                            /* push esi */
            ii(0x1012_0c71, 1);  push(edi);                            /* push edi */
            ii(0x1012_0c72, 1);  push(ebp);                            /* push ebp */
            ii(0x1012_0c73, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1012_0c75, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1012_0c7b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1012_0c7e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1012_0c81, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1012_0c84, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1012_0c87, 5);  call(0x1013_acc5, 0x1_a039);          /* call 0x1013acc5 */
            ii(0x1012_0c8c, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1012_0c8f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1012_0c92, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1012_0c94, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1012_0c95, 1);  pop(edi);                             /* pop edi */
            ii(0x1012_0c96, 1);  pop(esi);                             /* pop esi */
            ii(0x1012_0c97, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1012_0c98, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1012_0c99, 1);  ret();                                /* ret */
        }
    }
}