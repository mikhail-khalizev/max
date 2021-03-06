using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_f0df-548db26f")]
        public void Method_1013_f0df()
        {
            ii(0x1013_f0df, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1013_f0e4, 5);  call(Definitions.sys_check_available_stack_size, 0x2_6c69);/* call 0x10165d52 */
            ii(0x1013_f0e9, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_f0ea, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_f0eb, 1);  push(esi);                            /* push esi */
            ii(0x1013_f0ec, 1);  push(edi);                            /* push edi */
            ii(0x1013_f0ed, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_f0ee, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_f0f0, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1013_f0f6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_f0f9, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_f0fc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f0ff, 5);  call(0x1013_f115, 0x11);              /* call 0x1013f115 */
            ii(0x1013_f104, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_f107, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1013_f10a, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1013_f10d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_f10f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_f110, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_f111, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_f112, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_f113, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_f114, 1);  ret();                                /* ret */
        }
    }
}
