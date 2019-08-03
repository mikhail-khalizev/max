using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("cb96de00-9a72-4c11-879f-bcfc36cf115c")]
        public void /* sys */ Method_1019_5ce4()
        {
            ii(0x1019_5ce4, 3); mov(ecx, memd_a32[ds, ebx + 0x2]);      /* mov ecx, [ebx+0x2] */
            ii(0x1019_5ce7, 2); jmpd_func(0x1019_5ca0, -0x49); return;  /* jmp 0x10195ca0 */
        }
    }
}
