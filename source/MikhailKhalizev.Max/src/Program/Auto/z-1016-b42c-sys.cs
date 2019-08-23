using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_b42c-4e970071")]
        public void /* sys */ Method_1016_b42c()
        {
            ii(0x1016_b42c, 1); push(edx);                              /* push edx */
            ii(0x1016_b42d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_b42f, 5); mov(eax, memd[ds, 0x101c_fb54]);        /* mov eax, [0x101cfb54] */
            ii(0x1016_b434, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b436, 2); if(jz(0x1016_b449, 0x11)) goto l_0x1016_b449; /* jz 0x1016b449 */
        l_0x1016_b438:
            ii(0x1016_b438, 3); cmp(edx, memd[ds, eax + 0x4]);          /* cmp edx, [eax+0x4] */
            ii(0x1016_b43b, 2); if(jnz(0x1016_b442, 0x5)) goto l_0x1016_b442; /* jnz 0x1016b442 */
            ii(0x1016_b43d, 3); or(memb[ds, eax], 0x1);                 /* or byte [eax], 0x1 */
            ii(0x1016_b440, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b441, 1); ret(); return;                          /* ret */
        l_0x1016_b442:
            ii(0x1016_b442, 3); mov(eax, memd[ds, eax + 0x8]);          /* mov eax, [eax+0x8] */
            ii(0x1016_b445, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_b447, 2); if(jnz(0x1016_b438, -0x11)) goto l_0x1016_b438; /* jnz 0x1016b438 */
        l_0x1016_b449:
            ii(0x1016_b449, 1); pop(edx);                               /* pop edx */
            ii(0x1016_b44a, 1); ret();                                  /* ret */
        }
    }
}
