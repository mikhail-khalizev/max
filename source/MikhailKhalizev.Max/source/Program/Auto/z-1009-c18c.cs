using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c18c-f318643")]
        public void Method_1009_c18c()
        {
            ii(0x1009_c18c, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1009_c191, 5);  call(Definitions.sys_check_available_stack_size, 0xc_9bbc);/* call 0x10165d52 */
            ii(0x1009_c196, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c197, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c198, 1);  push(esi);                            /* push esi */
            ii(0x1009_c199, 1);  push(edi);                            /* push edi */
            ii(0x1009_c19a, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c19b, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c19d, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_c1a3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c1a6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1009_c1a9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c1ac, 2);  mov(ebx, memd[ds, eax]);              /* mov ebx, [eax] */
            ii(0x1009_c1ae, 3);  sar(ebx, 0x10);                       /* sar ebx, 0x10 */
            ii(0x1009_c1b1, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1009_c1b4, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c1b7, 5);  call(0x1009_c1c4, 8);                 /* call 0x1009c1c4 */
            ii(0x1009_c1bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c1be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c1bf, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c1c0, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c1c1, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c1c2, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c1c3, 1);  ret();                                /* ret */
        }
    }
}
