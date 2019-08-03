using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4b2ee36c-d418-4148-84c6-7e0800aad8f2")]
        public void /* sys */ Method_1018_d3d2()
        {
            ii(0x1018_d3d2, 5); mov(eax, 0x9);                          /* mov eax, 0x9 */
            ii(0x1018_d3d7, 5); calld(/* sys */ 0x1018_d3bf, -0x1d);    /* call 0x1018d3bf */
            ii(0x1018_d3dc, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1018_d3e1, 1); retd(); return;                         /* ret */
        }
    }
}
