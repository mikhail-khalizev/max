using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6494-996bfee")]
        public void Method_0019_6494()
        {
            ii(0x19_6494, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_6497, 4); dec(memw_a16[ds, 0x1274]);                /* dec word [0x1274] */
            ii(0x19_649b, 3); mov(ax, memw_a16[ss, bp - 0x58]);         /* mov ax, [bp-0x58] */
            ii(0x19_649e, 3); cmp(memw_a16[ss, bp - 0x68], ax);         /* cmp [bp-0x68], ax */
            ii(0x19_64a1, 2); if(jzw(0x19_64a6, 0x3)) goto l_0x19_64a6; /* jz 0x64a6 */
            ii(0x19_64a3, 3); jmpw(0x19_64ac, 0x6); goto l_0x19_64ac;   /* jmp 0x64ac */
        l_0x19_64a6:
            ii(0x19_64a6, 3); mov(ax, memw_a16[ss, bp - 0x62]);         /* mov ax, [bp-0x62] */
            ii(0x19_64a9, 3); mov(memw_a16[ss, bp - 0x58], ax);         /* mov [bp-0x58], ax */
        l_0x19_64ac:
            ii(0x19_64ac, 3); mov(ax, memw_a16[ss, bp - 0x3c]);         /* mov ax, [bp-0x3c] */
            ii(0x19_64af, 1); cwd();                                    /* cwd */
            ii(0x19_64b0, 3); add(ax, memw_a16[ss, bp - 0x66]);         /* add ax, [bp-0x66] */
            ii(0x19_64b3, 3); adc(dx, memw_a16[ss, bp - 0x64]);         /* adc dx, [bp-0x64] */
            ii(0x19_64b6, 3); mov(memw_a16[ss, bp - 0x3c], ax);         /* mov [bp-0x3c], ax */
            ii(0x19_64b9, 3); mov(memw_a16[ss, bp - 0x3a], dx);         /* mov [bp-0x3a], dx */
            ii(0x19_64bc, 3); if(jmpw_func(0x19_7817, 0x1358)) return;  /* jmp 0x7817 */
        }
    }
}