using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_393a-44c2bdb1")]
        public void /* sys */ Method_1019_393a()
        {
            ii(0x1019_393a, 1); push(ecx);                              /* push ecx */
            ii(0x1019_393b, 2); mov(eax, edi);                          /* mov eax, edi */
            ii(0x1019_393d, 3); add(eax, memd[ss, ebp - 0x24]);         /* add eax, [ebp-0x24] */
            ii(0x1019_3940, 6); sub(eax, memd[ds, Definitions.video_win_end]); /* sub eax, [0x10209cac] */
            ii(0x1019_3946, 2); if(jb_func(0x1019_396d, 0x25)) return;  /* jb 0x1019396d */
            ii(0x1019_3948, 5); if(jmp_func(0x1019_3a13, 0xc6)) return; /* jmp 0x10193a13 */
        }
    }
}
