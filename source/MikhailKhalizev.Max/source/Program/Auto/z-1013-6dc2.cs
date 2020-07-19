using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_6dc2-e91675b5")]
        public void Method_1013_6dc2()
        {
            ii(0x1013_6dc2, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_6dc7, 5);  call(Definitions.sys_check_available_stack_size, 0x2_ef86);/* call 0x10165d52 */
            ii(0x1013_6dcc, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_6dcd, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_6dce, 1);  push(edx);                            /* push edx */
            ii(0x1013_6dcf, 1);  push(esi);                            /* push esi */
            ii(0x1013_6dd0, 1);  push(edi);                            /* push edi */
            ii(0x1013_6dd1, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_6dd2, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_6dd4, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1013_6dda, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1013_6ddd, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6de0, 3);  mov(edx, memd[ds, eax + 20]);         /* mov edx, [eax+0x14] */
            ii(0x1013_6de3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1013_6de6, 5);  call(0x1013_6d00, -0xeb);             /* call 0x10136d00 */
            ii(0x1013_6deb, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_6ded, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_6dee, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_6def, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_6df0, 1);  pop(edx);                             /* pop edx */
            ii(0x1013_6df1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_6df2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_6df3, 1);  ret();                                /* ret */
        }
    }
}
