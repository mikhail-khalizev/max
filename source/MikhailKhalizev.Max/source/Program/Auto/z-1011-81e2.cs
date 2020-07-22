using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_81e2-f4f1f34e")]
        public void Method_1011_81e2()
        {
            ii(0x1011_81e2, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1011_81e7, 5);  call(Definitions.sys_check_available_stack_size, 0x4_db66);/* call 0x10165d52 */
            ii(0x1011_81ec, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_81ed, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_81ee, 1);  push(edx);                            /* push edx */
            ii(0x1011_81ef, 1);  push(esi);                            /* push esi */
            ii(0x1011_81f0, 1);  push(edi);                            /* push edi */
            ii(0x1011_81f1, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_81f2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_81f4, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_81fa, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_81fd, 7);  mov(memd[ss, ebp - 8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1011_8204, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_8207, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_8209, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_820a, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_820b, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_820c, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_820d, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_820e, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_820f, 1);  ret();                                /* ret */
        }
    }
}
