using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1019_3da0-42c01709")]
        public void /* sys */ Method_1019_3da0()
        {
            ii(0x1019_3da0, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_3da1, 3); add(esi, memd[ss, ebp - 24]);           /* add esi, [ebp-0x18] */
            ii(0x1019_3da4, 3); add(edi, memd[ss, ebp - 28]);           /* add edi, [ebp-0x1c] */
            ii(0x1019_3da7, 3); add(edi, memd[ss, ebp - 32]);           /* add edi, [ebp-0x20] */
            ii(0x1019_3daa, 2); if(loop_func(0x1019_3d8d, -0x1f)) return; /* loop 0x10193d8d */
            ii(0x1019_3dac, 1); pop(esi);                               /* pop esi */
            ii(0x1019_3dad, 1); pop(ecx);                               /* pop ecx */
            ii(0x1019_3dae, 6); add(esi, memd[ds, 0x1020_9cd0]);        /* add esi, [0x10209cd0] */
            ii(0x1019_3db4, 3); inc(memd[ss, ebp + 36]);                /* inc dword [ebp+0x24] */
            ii(0x1019_3db7, 2); dec(cl);                                /* dec cl */
            ii(0x1019_3db9, 2); if(jnz_func(0x1019_3d49, -0x72)) return; /* jnz 0x10193d49 */
            ii(0x1019_3dbb, 5); if(jmp_func(0x1019_40fc, 0x33c)) return; /* jmp 0x101940fc */
        }
    }
}
