using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_53e0-feb708c0")]
        public void Method_1015_53e0()
        {
            ii(0x1015_53e0, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1015_53e5, 5);  call(Definitions.sys_check_available_stack_size, 0x1_0968);/* call 0x10165d52 */
            ii(0x1015_53ea, 1);  push(ebx);                            /* push ebx */
            ii(0x1015_53eb, 1);  push(ecx);                            /* push ecx */
            ii(0x1015_53ec, 1);  push(edx);                            /* push edx */
            ii(0x1015_53ed, 1);  push(esi);                            /* push esi */
            ii(0x1015_53ee, 1);  push(edi);                            /* push edi */
            ii(0x1015_53ef, 1);  push(ebp);                            /* push ebp */
            ii(0x1015_53f0, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1015_53f2, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1015_53f8, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1015_53fb, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1015_53fe, 2);  mov(eax, memd[ds, eax]);              /* mov eax, [eax] */
            ii(0x1015_5400, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1015_5403, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1015_5406, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1015_5408, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1015_5409, 1);  pop(edi);                             /* pop edi */
            ii(0x1015_540a, 1);  pop(esi);                             /* pop esi */
            ii(0x1015_540b, 1);  pop(edx);                             /* pop edx */
            ii(0x1015_540c, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1015_540d, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1015_540e, 1);  ret();                                /* ret */
        }
    }
}
