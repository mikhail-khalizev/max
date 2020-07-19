using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5398-44b9eb0e")]
        public void Method_1011_5398()
        {
            ii(0x1011_5398, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_5399, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_539a, 1);  push(edx);                            /* push edx */
            ii(0x1011_539b, 1);  push(esi);                            /* push esi */
            ii(0x1011_539c, 1);  push(edi);                            /* push edi */
            ii(0x1011_539d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_539e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_53a0, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_53a6, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_53aa, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_53ad, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_53af, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_53b0, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_53b1, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_53b2, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_53b3, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_53b4, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_53b5, 1);  ret();                                /* ret */
        }
    }
}
