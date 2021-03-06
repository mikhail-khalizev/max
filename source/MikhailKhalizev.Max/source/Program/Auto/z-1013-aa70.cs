using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_aa70-db4eb52a")]
        public void Method_1013_aa70()
        {
            ii(0x1013_aa70, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_aa75, 5);  call(Definitions.sys_check_available_stack_size, 0x2_b2d8);/* call 0x10165d52 */
            ii(0x1013_aa7a, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_aa7b, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_aa7c, 1);  push(esi);                            /* push esi */
            ii(0x1013_aa7d, 1);  push(edi);                            /* push edi */
            ii(0x1013_aa7e, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_aa7f, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_aa81, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_aa87, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_aa8a, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_aa8d, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1013_aa90, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_aa93, 5);  call(0x1013_acc5, 0x22d);             /* call 0x1013acc5 */
            ii(0x1013_aa98, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_aa9b, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_aa9e, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_aaa0, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_aaa1, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_aaa2, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_aaa3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_aaa4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_aaa5, 1);  ret();                                /* ret */
        }
    }
}
