using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_82a8-47bf0a81")]
        public void Method_1011_82a8()
        {
            ii(0x1011_82a8, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1011_82ad, 5);  call(Definitions.sys_check_available_stack_size, 0x4_daa0);/* call 0x10165d52 */
            ii(0x1011_82b2, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_82b3, 1);  push(esi);                            /* push esi */
            ii(0x1011_82b4, 1);  push(edi);                            /* push edi */
            ii(0x1011_82b5, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_82b6, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_82b8, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1011_82be, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1011_82c1, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1011_82c4, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1011_82c7, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_82c9, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_82ca, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_82cb, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_82cc, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_82cd, 1);  ret();                                /* ret */
        }
    }
}
