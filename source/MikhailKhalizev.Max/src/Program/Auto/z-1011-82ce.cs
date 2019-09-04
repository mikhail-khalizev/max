using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_82ce-195b6377")]
        public void Method_1011_82ce()
        {
            ii(0x1011_82ce, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_82d3, 5);  call(Definitions.sys_check_available_stack_size, 0x4_da7a);/* call 0x10165d52 */
            ii(0x1011_82d8, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_82d9, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_82da, 1);  push(esi);                            /* push esi */
            ii(0x1011_82db, 1);  push(edi);                            /* push edi */
            ii(0x1011_82dc, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_82dd, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_82df, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1011_82e5, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1011_82e8, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1011_82eb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_82ed, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_82ee, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_82ef, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_82f0, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_82f1, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_82f2, 1);  ret();                                /* ret */
        }
    }
}
