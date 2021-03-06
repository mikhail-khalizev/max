using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_47c4-91875819")]
        public void Method_1010_47c4()
        {
            ii(0x1010_47c4, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1010_47c9, 5);  call(Definitions.sys_check_available_stack_size, 0x6_1584);/* call 0x10165d52 */
            ii(0x1010_47ce, 1);  push(ebx);                            /* push ebx */
            ii(0x1010_47cf, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_47d0, 1);  push(edx);                            /* push edx */
            ii(0x1010_47d1, 1);  push(esi);                            /* push esi */
            ii(0x1010_47d2, 1);  push(edi);                            /* push edi */
            ii(0x1010_47d3, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_47d4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_47d6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1010_47dc, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1010_47df, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1010_47e2, 3);  add(eax, 6);                          /* add eax, 0x6 */
            ii(0x1010_47e5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1010_47e8, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_47eb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_47ed, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_47ee, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_47ef, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_47f0, 1);  pop(edx);                             /* pop edx */
            ii(0x1010_47f1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_47f2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1010_47f3, 1);  ret();                                /* ret */
        }
    }
}
