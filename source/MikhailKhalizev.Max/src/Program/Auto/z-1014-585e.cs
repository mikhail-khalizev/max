using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_585e-ccfd1acf")]
        public void Method_1014_585e()
        {
            ii(0x1014_585e, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_5863, 5);  call(Definitions.sys_check_available_stack_size, 0x2_04ea);/* call 0x10165d52 */
            ii(0x1014_5868, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_5869, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_586a, 1);  push(esi);                            /* push esi */
            ii(0x1014_586b, 1);  push(edi);                            /* push edi */
            ii(0x1014_586c, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_586d, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_586f, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1014_5875, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_5878, 3);  mov(memd[ss, ebp - 4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1014_587b, 3);  mov(edx, memd[ss, ebp - 4]);          /* mov edx, [ebp-0x4] */
            ii(0x1014_587e, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_5881, 5);  call(0x1013_b518, -0xa36e);           /* call 0x1013b518 */
            ii(0x1014_5886, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1014_5889, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1014_588c, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_588e, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_588f, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_5890, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_5891, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_5892, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_5893, 1);  ret();                                /* ret */
        }
    }
}
