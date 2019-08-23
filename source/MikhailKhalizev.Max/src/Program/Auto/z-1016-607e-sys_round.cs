using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_607e-c766a05a")]
        public void /* sys */ sys_round()
        {
            ii(0x1016_607e, 1); pushd(eax);                             /* push eax */
            ii(0x1016_607f, 1); wait();                                 /* wait */
            ii(0x1016_6080, 3); fnstcw(memw_a32[ss, esp]);              /* fnstcw word [esp] */
            ii(0x1016_6083, 1); wait();                                 /* wait */
            ii(0x1016_6084, 3); pushd(memd_a32[ss, esp]);               /* push dword [esp] */
            ii(0x1016_6087, 5); mov(memb_a32[ss, esp + 0x1], 0x1f);     /* mov byte [esp+0x1], 0x1f */
            ii(0x1016_608c, 3); fldcw(memw_a32[ss, esp]);               /* fldcw word [esp] */
            ii(0x1016_608f, 2); frndint();                              /* frndint */
            ii(0x1016_6091, 4); fldcw(memw_a32[ss, esp + 0x4]);         /* fldcw word [esp+0x4] */
            ii(0x1016_6095, 1); wait();                                 /* wait */
            ii(0x1016_6096, 4); lea(esp, esp + 0x8);                    /* lea esp, [esp+0x8] */
            ii(0x1016_609a, 1); retd();                                 /* ret */
        }
    }
}
