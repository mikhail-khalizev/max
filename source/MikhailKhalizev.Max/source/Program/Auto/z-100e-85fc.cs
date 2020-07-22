using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_85fc-b1869906")]
        public void Method_100e_85fc()
        {
            ii(0x100e_85fc, 5);  push(0x20);                           /* push 0x20 */
            ii(0x100e_8601, 5);  call(Definitions.sys_check_available_stack_size, 0x7_d74c);/* call 0x10165d52 */
            ii(0x100e_8606, 1);  push(ecx);                            /* push ecx */
            ii(0x100e_8607, 1);  push(esi);                            /* push esi */
            ii(0x100e_8608, 1);  push(edi);                            /* push edi */
            ii(0x100e_8609, 1);  push(ebp);                            /* push ebp */
            ii(0x100e_860a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100e_860c, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x100e_8612, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x100e_8615, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x100e_8618, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x100e_861b, 4);  movsx(ebx, memw[ss, ebp - 4]);        /* movsx ebx, word [ebp-0x4] */
            ii(0x100e_861f, 3);  mov(edx, memd[ss, ebp - 8]);          /* mov edx, [ebp-0x8] */
            ii(0x100e_8622, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x100e_8625, 5);  call(0x1013_b0f9, 0x5_2acf);          /* call 0x1013b0f9 */
            ii(0x100e_862a, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100e_862c, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100e_862d, 1);  pop(edi);                             /* pop edi */
            ii(0x100e_862e, 1);  pop(esi);                             /* pop esi */
            ii(0x100e_862f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100e_8630, 1);  ret();                                /* ret */
        }
    }
}
