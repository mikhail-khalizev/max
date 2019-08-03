using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("72099c28-4be8-424e-ac2c-90d315d0c883")]
        public void /* sys */ Method_1019_393a()
        {
            ii(0x1019_393a, 1); pushd(ecx);                             /* push ecx */
            ii(0x1019_393b, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_393d, 3); add(eax, memd_a32[ss, ebp - 0x24]);     /* add eax, [ebp-0x24] */
            ii(0x1019_3940, 6); sub(eax, memd_a32[ds, Definitions.video_win_end]); /* sub eax, [0x10209cac] */
            ii(0x1019_3946, 2); jbd_func(0x1019_396d, 0x25);            /* jb 0x10193dc0 */
            ii(0x1019_3948, 5); jmpd_func(0x1019_3a13, 0xc6); return;   /* jmp 0x10193e66 */
        }
    }
}