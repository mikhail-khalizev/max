using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c164-8461ad31")]
        public void Method_1013_c164()
        {
            ii(0x1013_c164, 5);  push(0x20);                           /* push 0x20 */
            ii(0x1013_c169, 5);  call(Definitions.sys_check_available_stack_size, 0x2_9be4);/* call 0x10165d52 */
            ii(0x1013_c16e, 1);  push(ebx);                            /* push ebx */
            ii(0x1013_c16f, 1);  push(ecx);                            /* push ecx */
            ii(0x1013_c170, 1);  push(esi);                            /* push esi */
            ii(0x1013_c171, 1);  push(edi);                            /* push edi */
            ii(0x1013_c172, 1);  push(ebp);                            /* push ebp */
            ii(0x1013_c173, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1013_c175, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1013_c17b, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1013_c17e, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1013_c181, 5);  mov(ebx, 4);                          /* mov ebx, 0x4 */
            ii(0x1013_c186, 3);  lea(edx, memd[ss, ebp - 4]);          /* lea edx, [ebp-0x4] */
            ii(0x1013_c189, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1013_c18c, 5);  call(0x1013_c055, -0x13c);            /* call 0x1013c055 */
            ii(0x1013_c191, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1013_c193, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1013_c194, 1);  pop(edi);                             /* pop edi */
            ii(0x1013_c195, 1);  pop(esi);                             /* pop esi */
            ii(0x1013_c196, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1013_c197, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1013_c198, 1);  ret();                                /* ret */
        }
    }
}
