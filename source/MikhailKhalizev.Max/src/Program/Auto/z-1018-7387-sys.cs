using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_7387-acd5eb21")]
        public void /* sys */ Method_1018_7387()
        {
            ii(0x1018_7387, 3);  sub(esp, 0x2c);                       /* sub esp, 0x2c */
            ii(0x1018_738a, 7);  jmp_abs(memd[ds, eax * 4 + 0x101c_3080]);/* jmp dword [eax*4+0x101c3080] */
        }
    }
}
