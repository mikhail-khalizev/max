using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_1698-54f889b1")]
        public void Method_1014_1698()
        {
            ii(0x1014_1698, 5);  push(0x24);                           /* push 0x24 */
            ii(0x1014_169d, 5);  call(Definitions.sys_check_available_stack_size, 0x2_46b0);/* call 0x10165d52 */
            ii(0x1014_16a2, 1);  push(ebx);                            /* push ebx */
            ii(0x1014_16a3, 1);  push(ecx);                            /* push ecx */
            ii(0x1014_16a4, 1);  push(edx);                            /* push edx */
            ii(0x1014_16a5, 1);  push(esi);                            /* push esi */
            ii(0x1014_16a6, 1);  push(edi);                            /* push edi */
            ii(0x1014_16a7, 1);  push(ebp);                            /* push ebp */
            ii(0x1014_16a8, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1014_16aa, 6);  sub(esp, 8);                          /* sub esp, 0x8 */
            ii(0x1014_16b0, 3);  mov(memd[ss, ebp - 4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_16b3, 3);  mov(eax, memd[ss, ebp - 4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_16b6, 5);  call(0x1007_623c, -0xc_b47f);         /* call 0x1007623c */
            ii(0x1014_16bb, 3);  mov(memd[ss, ebp - 8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_16be, 3);  mov(eax, memd[ss, ebp - 8]);          /* mov eax, [ebp-0x8] */
            ii(0x1014_16c1, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1014_16c3, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1014_16c4, 1);  pop(edi);                             /* pop edi */
            ii(0x1014_16c5, 1);  pop(esi);                             /* pop esi */
            ii(0x1014_16c6, 1);  pop(edx);                             /* pop edx */
            ii(0x1014_16c7, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1014_16c8, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1014_16c9, 1);  ret();                                /* ret */
        }
    }
}
