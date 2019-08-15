using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c10195db-d7ab-47f2-b427-8d3b4b3c0008")]
        public void /* sys */ Method_1018_1ce1()
        {
            ii(0x1018_1ce1, 4); mov(memb_a32[ds, eax + 0x8], 0);        /* mov byte [eax+0x8], 0x0 */
            ii(0x1018_1ce5, 1); retd(); return;                         /* ret */
        }
    }
}
