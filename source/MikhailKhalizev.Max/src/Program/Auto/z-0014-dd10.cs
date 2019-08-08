using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("ce270439-2d0c-4182-bcc7-77f3ae269adb")]
        public void Method_0014_dd10()
        {
            ii(0x14_dd10, 2); mov(di, ss);                              /* mov di, ss */
            ii(0x14_dd12, 4); lar(edi, di);                             /* lar edi, di */
            ii(0x14_dd16, 5); bt(edi, 0x16);                            /* bt edi, 0x16 */
            ii(0x14_dd1b, 1); popw(di);                                 /* pop di */
            ii(0x14_dd1c, 5); pushd(memd_a16[ds, 0xc18]);               /* push dword [0xc18] */
            ii(0x14_dd21, 4); pushw(memw_a16[ds, 0xc1c]);               /* push word [0xc1c] */
            ii(0x14_dd25, 5); mov(memd_a16[ds, 0xc18], esp);            /* mov [0xc18], esp */
            ii(0x14_dd2a, 2); if(jbw(0x14_dd32, 0x6)) goto l_0x14_dd32; /* jb 0xdd32 */
            ii(0x14_dd2c, 6); mov(memw_a16[ds, 0xc1a], 0);              /* mov word [0xc1a], 0x0 */
        l_0x14_dd32:
            ii(0x14_dd32, 4); mov(memw_a16[ds, 0xc1c], ss);             /* mov [0xc1c], ss */
            ii(0x14_dd36, 6); sub(memw_a16[ds, 0x996], 0x180);          /* sub word [0x996], 0x180 */
            ii(0x14_dd3c, 1); pushw(ds);                                /* push ds */
            ii(0x14_dd3d, 1); popw(ss);                                 /* pop ss */
            ii(0x14_dd3e, 6); movzx(esp, memw_a16[ds, 0x996]);          /* movzx esp, word [0x996] */
            ii(0x14_dd44, 3); sub(sp, 0x10);                            /* sub sp, 0x10 */
            ii(0x14_dd47, 2); if(jmpw_abs(di)) return;                  /* jmp di */
        }
    }
}