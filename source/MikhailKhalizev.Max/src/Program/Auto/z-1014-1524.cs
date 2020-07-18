using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1524-1e57caf4")]
        public void Method_1014_1524()
        {
            ii(0x1014_1524, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_1529, 5);  call(Definitions.sys_check_available_stack_size, 0x2_4824);/* call 0x10165d52 */
            ii(0x1014_152e, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_152f, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_1530, 1);  push(esi);                            /* push esi */
            ii(0x1014_1531, 1);  push(edi);                            /* push edi */
            ii(0x1014_1532, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_1533, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_1535, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_153b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_153e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_1541, 5);  mov(edx, 1);                          /* mov edx, 0x1 */
            ii(0x1014_1546, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1549, 5);  call(0x1013_b0a5, -0x64a9);           /* call 0x1013b0a5 */
            ii(0x1014_154e, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_1551, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_1554, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_1557, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_155a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_155c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_155d, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_155e, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_155f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_1560, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_1561, 1);  ret();                                /* ret */
        }
    }
}
