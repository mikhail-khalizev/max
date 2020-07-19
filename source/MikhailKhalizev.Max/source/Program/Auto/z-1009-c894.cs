using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_c894-db0dd9cf")]
        public void Method_1009_c894()
        {
            ii(0x1009_c894, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1009_c899, 5);  call(Definitions.sys_check_available_stack_size, 0xc_94b4);/* call 0x10165d52 */
            ii(0x1009_c89e, 1);  push(ebx);                            /* push ebx */
            ii(0x1009_c89f, 1);  push(ecx);                            /* push ecx */
            ii(0x1009_c8a0, 1);  push(edx);                            /* push edx */
            ii(0x1009_c8a1, 1);  push(esi);                            /* push esi */
            ii(0x1009_c8a2, 1);  push(edi);                            /* push edi */
            ii(0x1009_c8a3, 1);  push(ebp);                            /* push ebp */
            ii(0x1009_c8a4, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1009_c8a6, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1009_c8ac, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_c8af, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_c8b2, 4);  mov(ax, memw[ds, eax + 5]);           /* mov ax, [eax+0x5] */
            ii(0x1009_c8b6, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_c8b9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_c8bc, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1009_c8be, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1009_c8bf, 1);  pop(edi);                             /* pop edi */
            ii(0x1009_c8c0, 1);  pop(esi);                             /* pop esi */
            ii(0x1009_c8c1, 1);  pop(edx);                             /* pop edx */
            ii(0x1009_c8c2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1009_c8c3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1009_c8c4, 1);  ret();                                /* ret */
        }
    }
}