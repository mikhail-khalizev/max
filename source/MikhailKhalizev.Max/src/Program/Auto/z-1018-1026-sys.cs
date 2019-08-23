using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_1026-1811f9a4")]
        public void /* sys */ Method_1018_1026()
        {
            ii(0x1018_1026, 1); push(edx);                              /* push edx */
            ii(0x1018_1027, 5); mov(edx, 0xff);                         /* mov edx, 0xff */
            ii(0x1018_102c, 5); mov(eax, StringDefinitions.AbnormalTermination); /* mov eax, 0x101b32d0 */
            ii(0x1018_1031, 5); call(/* sys */ 0x1018_1002, -0x34);     /* call 0x10181002 */
            ii(0x1018_1036, 1); pop(edx);                               /* pop edx */
            ii(0x1018_1037, 1); ret();                                  /* ret */
        }
    }
}
