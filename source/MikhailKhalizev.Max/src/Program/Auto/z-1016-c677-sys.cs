using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("4451bd7c-4442-48a5-afa8-dfe1a55182fb")]
        public void /* sys */ Method_1016_c677()
        {
            ii(0x1016_c677, 1); pushd(edx);                             /* push edx */
            ii(0x1016_c678, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_c67a, 6); calld_abs(memd_a32[ds, 0x101b_de84]);   /* call dword [0x101bde84] */ /* Вызов '0x1016_c65e'. */
            ii(0x1016_c680, 6); calld_abs(memd_a32[ds, 0x101b_de88]);   /* call dword [0x101bde88] */ /* Вызов '0x1016_c65e'. */
            ii(0x1016_c686, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_c688, 5); jmpd_func(0x1016_c993, 0x306); return;  /* jmp 0x1016c993 */
        }
    }
}
