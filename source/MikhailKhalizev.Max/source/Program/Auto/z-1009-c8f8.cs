using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c8f8-ff003f2")]
        public void Method_1009_c8f8()
        {
            ii(0x1009_c8f8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_c8fd, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9450);/* call 0x10165d52 */
            ii(0x1009_c902, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c903, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c904, 1);  push(esi);                            /* push esi */
            ii(0x1009_c905, 1);  push(edi);                            /* push edi */
            ii(0x1009_c906, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c907, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c909, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1009_c90f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c912, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c915, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_c918, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c91b, 5);  call(0x1013_ac7d, 0x9_e35d);          /* call 0x1013ac7d */
            ii(0x1009_c920, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1009_c923, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1009_c926, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c928, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c929, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c92a, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c92b, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c92c, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c92d, 1);  ret();                                /* ret */
        }
    }
}
