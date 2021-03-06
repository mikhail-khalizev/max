using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5378-44b9eb0e")]
        public void Method_1011_5378()
        {
            ii(0x1011_5378, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_5379, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_537a, 1);  push(edx);                            /* push edx */
            ii(0x1011_537b, 1);  push(esi);                            /* push esi */
            ii(0x1011_537c, 1);  push(edi);                            /* push edi */
            ii(0x1011_537d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_537e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_5380, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_5386, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_538a, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_538d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_538f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_5390, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_5391, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_5392, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_5393, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_5394, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_5395, 1);  ret();                                /* ret */
        }
    }
}
