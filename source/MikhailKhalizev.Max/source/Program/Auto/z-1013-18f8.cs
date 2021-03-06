using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_18f8-8e2df30e")]
        public void Method_1013_18f8()
        {
            ii(0x1013_18f8, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_18fd, 5);  call(Definitions.sys_check_available_stack_size, 0x3_4450);/* call 0x10165d52 */
            ii(0x1013_1902, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_1903, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_1904, 1);  push(esi);                            /* push esi */
            ii(0x1013_1905, 1);  push(edi);                            /* push edi */
            ii(0x1013_1906, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_1907, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_1909, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_190f, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_1912, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_1915, 4);  movsx(edx, memw[ss, ebp - 4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x1013_1919, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_191c, 5);  call(0x1013_1930, 0xf);               /* call 0x10131930 */
            ii(0x1013_1921, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_1924, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_1927, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_1929, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_192a, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_192b, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_192c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_192d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_192e, 1);  ret();                                /* ret */
        }
    }
}
