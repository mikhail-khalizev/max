using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_51e4-44b9eb0e")]
        public void Method_100d_51e4()
        {
            ii(0x100d_51e4, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_51e5, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_51e6, 1);  push(edx);                            /* push edx */
            ii(0x100d_51e7, 1);  push(esi);                            /* push esi */
            ii(0x100d_51e8, 1);  push(edi);                            /* push edi */
            ii(0x100d_51e9, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_51ea, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_51ec, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_51f2, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_51f6, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_51f9, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_51fb, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_51fc, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_51fd, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_51fe, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_51ff, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_5200, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_5201, 1);  ret();                                /* ret */
        }
    }
}
