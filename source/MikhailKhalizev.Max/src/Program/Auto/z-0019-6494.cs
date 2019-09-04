using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_6494-996bfee")]
        public void Method_0019_6494()
        {
            ii(0x19_6494, 3);  add(sp, 6);                             /* add sp, 0x6 */
            ii(0x19_6497, 4);  dec(memw[ds, 0x1274]);                  /* dec word [0x1274] */
            ii(0x19_649b, 3);  mov(ax, memw[ss, bp - 88]);             /* mov ax, [bp-0x58] */
            ii(0x19_649e, 3);  cmp(memw[ss, bp - 104], ax);            /* cmp [bp-0x68], ax */
            ii(0x19_64a1, 2);  if(jz(0x19_64a6, 3)) goto l_0x19_64a6;  /* jz 0x64a6 */
            ii(0x19_64a3, 3);  jmp(0x19_64ac, 6); goto l_0x19_64ac;    /* jmp 0x64ac */
        l_0x19_64a6:
            ii(0x19_64a6, 3);  mov(ax, memw[ss, bp - 98]);             /* mov ax, [bp-0x62] */
            ii(0x19_64a9, 3);  mov(memw[ss, bp - 88], ax);             /* mov [bp-0x58], ax */
        l_0x19_64ac:
            ii(0x19_64ac, 3);  mov(ax, memw[ss, bp - 60]);             /* mov ax, [bp-0x3c] */
            ii(0x19_64af, 1);  cwd();                                  /* cwd */
            ii(0x19_64b0, 3);  add(ax, memw[ss, bp - 102]);            /* add ax, [bp-0x66] */
            ii(0x19_64b3, 3);  adc(dx, memw[ss, bp - 100]);            /* adc dx, [bp-0x64] */
            ii(0x19_64b6, 3);  mov(memw[ss, bp - 60], ax);             /* mov [bp-0x3c], ax */
            ii(0x19_64b9, 3);  mov(memw[ss, bp - 58], dx);             /* mov [bp-0x3a], dx */
            ii(0x19_64bc, 3);  if(jmp_func(0x19_7817, 0x1358)) return; /* jmp 0x7817 */
        }
    }
}
