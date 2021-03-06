using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_6715-1869adb0")]
        public void Method_1010_6715()
        {
            ii(0x1010_6715, 5);  push(0x30);                           /* push 0x30 */
            ii(0x1010_671a, 5);  call(Definitions.sys_check_available_stack_size, 0x5_f633);/* call 0x10165d52 */
            ii(0x1010_671f, 1);  push(ecx);                            /* push ecx */
            ii(0x1010_6720, 1);  push(esi);                            /* push esi */
            ii(0x1010_6721, 1);  push(edi);                            /* push edi */
            ii(0x1010_6722, 1);  push(ebp);                            /* push ebp */
            ii(0x1010_6723, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1010_6725, 6);  sub(esp, 0xc);                        /* sub esp, 0xc */
            ii(0x1010_672b, 3);  mov(memd[ss, ebp - 12], eax);         /* mov [ebp-0xc], eax */
            ii(0x1010_672e, 3);  mov(memd[ss, ebp - 8], edx);          /* mov [ebp-0x8], edx */
            ii(0x1010_6731, 3);  mov(memd[ss, ebp - 4], ebx);          /* mov [ebp-0x4], ebx */
            ii(0x1010_6734, 2);  push(0);                              /* push 0x0 */
            ii(0x1010_6736, 4);  movsx(eax, memw[ss, ebp - 4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x1010_673a, 1);  push(eax);                            /* push eax */
            ii(0x1010_673b, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1010_673e, 1);  push(eax);                            /* push eax */
            ii(0x1010_673f, 3);  mov(eax, memd[ss, ebp - 12]);         /* mov eax, [ebp-0xc] */
            ii(0x1010_6742, 1);  push(eax);                            /* push eax */
            ii(0x1010_6743, 5);  call(0x1012_3c73, 0x1_d52b);          /* call 0x10123c73 */
            ii(0x1010_6748, 3);  add(esp, 0x10);                       /* add esp, 0x10 */
            ii(0x1010_674b, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1010_674d, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1010_674e, 1);  pop(edi);                             /* pop edi */
            ii(0x1010_674f, 1);  pop(esi);                             /* pop esi */
            ii(0x1010_6750, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1010_6751, 1);  ret();                                /* ret */
        }
    }
}
