using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_5fac-c2ffb2d9")]
        public void Method_1007_5fac()
        {
            ii(0x1007_5fac, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1007_5fb1, 5);  call(Definitions.sys_check_available_stack_size, 0xe_fd9c);/* call 0x10165d52 */
            ii(0x1007_5fb6, 1);  push(ebx);                            /* push ebx */
            ii(0x1007_5fb7, 1);  push(ecx);                            /* push ecx */
            ii(0x1007_5fb8, 1);  push(esi);                            /* push esi */
            ii(0x1007_5fb9, 1);  push(edi);                            /* push edi */
            ii(0x1007_5fba, 1);  push(ebp);                            /* push ebp */
            ii(0x1007_5fbb, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1007_5fbd, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1007_5fc3, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_5fc6, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_5fc9, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_5fcc, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_5fcf, 5);  call(0x1013_a2ab, 0xc_42d7);          /* call 0x1013a2ab */
            ii(0x1007_5fd4, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1007_5fd6, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1007_5fd7, 1);  pop(edi);                             /* pop edi */
            ii(0x1007_5fd8, 1);  pop(esi);                             /* pop esi */
            ii(0x1007_5fd9, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1007_5fda, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1007_5fdb, 1);  ret();                                /* ret */
        }
    }
}
