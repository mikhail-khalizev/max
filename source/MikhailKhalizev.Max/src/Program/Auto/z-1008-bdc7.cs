using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_bdc7-31e18c60")]
        public void Method_1008_bdc7()
        {
            ii(0x1008_bdc7, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1008_bdcc, 5);  call(Definitions.sys_check_available_stack_size, 0xd_9f81);/* call 0x10165d52 */
            ii(0x1008_bdd1, 1);  push(ebx);                            /* push ebx */
            ii(0x1008_bdd2, 1);  push(ecx);                            /* push ecx */
            ii(0x1008_bdd3, 1);  push(edx);                            /* push edx */
            ii(0x1008_bdd4, 1);  push(esi);                            /* push esi */
            ii(0x1008_bdd5, 1);  push(edi);                            /* push edi */
            ii(0x1008_bdd6, 1);  push(ebp);                            /* push ebp */
            ii(0x1008_bdd7, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1008_bdd9, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1008_bddf, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_bde2, 7);  mov(memd[ss, ebp - 8], 4);            /* mov dword [ebp-0x8], 0x4 */
            ii(0x1008_bde9, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_bdec, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1008_bdee, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1008_bdef, 1);  pop(edi);                             /* pop edi */
            ii(0x1008_bdf0, 1);  pop(esi);                             /* pop esi */
            ii(0x1008_bdf1, 1);  pop(edx);                             /* pop edx */
            ii(0x1008_bdf2, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1008_bdf3, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1008_bdf4, 1);  ret();                                /* ret */
        }
    }
}
