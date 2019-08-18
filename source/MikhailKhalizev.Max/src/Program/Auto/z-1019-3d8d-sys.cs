using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0ba5122f-e52f-482c-bdbd-022472b7db8d")]
        public void /* sys */ Method_1019_3d8d()
        {
            ii(0x1019_3d8d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_3d8e, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_3d90, 3); add(eax, memd_a32[ss, ebp - 0x24]);     /* add eax, [ebp-0x24] */
            ii(0x1019_3d93, 6); sub(eax, memd_a32[ds, Definitions.video_win_end]); /* sub eax, [0x10209cac] */
            ii(0x1019_3d99, 2); if(jbd_func(0x1019_3dc0, 0x25)) return; /* jb 0x10193dc0 */
            ii(0x1019_3d9b, 5); if(jmpd_func(0x1019_3e66, 0xc6)) return; /* jmp 0x10193e66 */
        }
    }
}
