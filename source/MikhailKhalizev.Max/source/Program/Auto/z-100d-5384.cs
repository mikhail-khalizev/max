using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_5384-44b9eb0e")]
        public void Method_100d_5384()
        {
            ii(0x100d_5384, 1);  push(ebx);                            /* push ebx */
            ii(0x100d_5385, 1);  push(ecx);                            /* push ecx */
            ii(0x100d_5386, 1);  push(edx);                            /* push edx */
            ii(0x100d_5387, 1);  push(esi);                            /* push esi */
            ii(0x100d_5388, 1);  push(edi);                            /* push edi */
            ii(0x100d_5389, 1);  push(ebp);                            /* push ebp */
            ii(0x100d_538a, 2);  mov(ebp, esp);                        /* mov ebp, esp */
            ii(0x100d_538c, 6);  sub(esp, 4);                          /* sub esp, 0x4 */
            ii(0x100d_5392, 4);  mov(memb[ss, ebp - 4], 1);            /* mov byte [ebp-0x4], 0x1 */
            ii(0x100d_5396, 3);  mov(al, memb[ss, ebp - 4]);           /* mov al, [ebp-0x4] */
            ii(0x100d_5399, 2);  mov(esp, ebp);                        /* mov esp, ebp */
            ii(0x100d_539b, 1);  pop(ebp);                             /* pop ebp */
            ii(0x100d_539c, 1);  pop(edi);                             /* pop edi */
            ii(0x100d_539d, 1);  pop(esi);                             /* pop esi */
            ii(0x100d_539e, 1);  pop(edx);                             /* pop edx */
            ii(0x100d_539f, 1);  pop(ecx);                             /* pop ecx */
            ii(0x100d_53a0, 1);  pop(ebx);                             /* pop ebx */
            ii(0x100d_53a1, 1);  ret();                                /* ret */
        }
    }
}
