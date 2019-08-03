using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1e655276-0a21-44ee-a343-f90b7a807231")]
        public void /* sys */ Method_1018_d7ae()
        {
            ii(0x1018_d7ae, 7); cmp(memd_a32[ds, 0x101b_e580], 0);      /* cmp dword [0x101be580], 0x0 */
            ii(0x1018_d7b5, 2); if(jzd(0x1018_d7bd, 0x6)) goto l_0x1018_d7bd; /* jz 0x1018d7bd */
            ii(0x1018_d7b7, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1018_d7bc, 1); retd(); return;                         /* ret */
        l_0x1018_d7bd:
            ii(0x1018_d7bd, 2); mov(ah, 0xb);                           /* mov ah, 0xb */
            ii(0x1018_d7bf, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_d7c1, 3); movsx(eax, al);                         /* movsx eax, al */
            ii(0x1018_d7c4, 1); retd(); return;                         /* ret */
        }
    }
}
