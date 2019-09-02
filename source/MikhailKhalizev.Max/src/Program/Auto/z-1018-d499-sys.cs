using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_d499-9ded666f")]
        public void /* sys */ Method_1018_d499()
        {
            ii(0x1018_d499, 1); push(edx);                              /* push edx */
            ii(0x1018_d49a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1018_d49c, 5); mov(eax, memd[ds, 0x101b_e580]);        /* mov eax, [0x101be580] */
            ii(0x1018_d4a1, 6); mov(memd[ds, 0x101b_e580], edx);        /* mov [0x101be580], edx */
            ii(0x1018_d4a7, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1018_d4a9, 2); if(jnz(0x1018_d4b4, 9)) goto l_0x1018_d4b4; /* jnz 0x1018d4b4 */
            ii(0x1018_d4ab, 2); mov(ah, 1);                             /* mov ah, 0x1 */
            ii(0x1018_d4ad, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d4af, 5); and(eax, 0xff);                         /* and eax, 0xff */
        l_0x1018_d4b4:
            ii(0x1018_d4b4, 1); pop(edx);                               /* pop edx */
            ii(0x1018_d4b5, 1); ret();                                  /* ret */
        }
    }
}
