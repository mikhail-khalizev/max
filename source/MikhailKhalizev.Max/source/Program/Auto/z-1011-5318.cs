using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_5318-44b9eb0e")]
        public void Method_1011_5318()
        {
            ii(0x1011_5318, 1);  push(ebx);                            /* push ebx */
            ii(0x1011_5319, 1);  push(ecx);                            /* push ecx */
            ii(0x1011_531a, 1);  push(edx);                            /* push edx */
            ii(0x1011_531b, 1);  push(esi);                            /* push esi */
            ii(0x1011_531c, 1);  push(edi);                            /* push edi */
            ii(0x1011_531d, 1);  push(ebp);                            /* push ebp */
            ii(0x1011_531e, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x1011_5320, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x1011_5326, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x1011_532a, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x1011_532d, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x1011_532f, 1);  pop(ebp);                             /* pop ebp */
            ii(0x1011_5330, 1);  pop(edi);                             /* pop edi */
            ii(0x1011_5331, 1);  pop(esi);                             /* pop esi */
            ii(0x1011_5332, 1);  pop(edx);                             /* pop edx */
            ii(0x1011_5333, 1);  pop(ecx);                             /* pop ecx */
            ii(0x1011_5334, 1);  pop(ebx);                             /* pop ebx */
            ii(0x1011_5335, 1);  ret();                                /* ret */
        }
    }
}
