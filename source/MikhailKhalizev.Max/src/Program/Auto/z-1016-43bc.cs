using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_43bc-f11bb70b")]
        public void Method_1016_43bc()
        {
            ii(0x1016_43bc, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1016_43c1, 5);  call(Definitions.sys_check_available_stack_size, 0x198c);/* call 0x10165d52 */
            ii(0x1016_43c6, 1);  push(ebx);                            /* push ebx */
            ii(0x1016_43c7, 1);  push(ecx);                            /* push ecx */
            ii(0x1016_43c8, 1);  push(edx);                            /* push edx */
            ii(0x1016_43c9, 1);  push(esi);                            /* push esi */
            ii(0x1016_43ca, 1);  push(edi);                            /* push edi */
            ii(0x1016_43cb, 1);  push(ebp);                            /* push ebp */
            ii(0x1016_43cc, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1016_43ce, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1016_43d4, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1016_43d7, 5);  call(0x1016_4980, 0x5a4);             /* call 0x10164980 */
            ii(0x1016_43dc, 3);  movsx(edx, ax);                       /* movsx edx, ax */
            ii(0x1016_43df, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1016_43e2, 5);  call(0x1016_4918, 0x531);             /* call 0x10164918 */
            ii(0x1016_43e7, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1016_43ea, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1016_43ed, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1016_43ef, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1016_43f0, 1);  pop(edi);                             /* pop edi */
            ii(0x1016_43f1, 1);  pop(esi);                             /* pop esi */
            ii(0x1016_43f2, 1);  pop(edx);                             /* pop edx */
            ii(0x1016_43f3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1016_43f4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1016_43f5, 1);  ret();                                /* ret */
        }
    }
}
