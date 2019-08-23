using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1017_99b0-feeeb571")]
        public void /* sys */ Method_1017_99b0()
        {
            ii(0x1017_99b0, 1); push(ebp);                              /* push ebp */
            ii(0x1017_99b1, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1017_99b3, 1); push(edx);                              /* push edx */
            ii(0x1017_99b4, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1017_99b6, 6); mov(ax, memw[ds, 0x1020_9db4]);         /* mov ax, [0x10209db4] */
            ii(0x1017_99bc, 3); add(eax, 0x4);                          /* add eax, 0x4 */
            ii(0x1017_99bf, 5); call(/* sys */ 0x1017_9970, -0x54);     /* call 0x10179970 */
            ii(0x1017_99c4, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1017_99c6, 2); if(jz(0x1017_99da, 0x12)) goto l_0x1017_99da; /* jz 0x101799da */
            ii(0x1017_99c8, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1017_99ca, 7); mov(dx, memw[ds, 0x1020_9db4]);         /* mov dx, [0x10209db4] */
            ii(0x1017_99d1, 3); mov(edx, memd[ds, edx + eax]);          /* mov edx, [edx+eax] */
            ii(0x1017_99d4, 6); mov(memd[ds, 0x1020_9db4], edx);        /* mov [0x10209db4], edx */
        l_0x1017_99da:
            ii(0x1017_99da, 3); lea(esp, ebp - 0x4);                    /* lea esp, [ebp-0x4] */
            ii(0x1017_99dd, 1); pop(edx);                               /* pop edx */
            ii(0x1017_99de, 1); pop(ebp);                               /* pop ebp */
            ii(0x1017_99df, 1); ret();                                  /* ret */
        }
    }
}
