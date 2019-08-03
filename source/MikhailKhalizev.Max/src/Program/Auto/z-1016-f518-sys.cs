using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("5b896ebd-bba4-4430-83ae-3d2691b9039e")]
        public void /* sys */ Method_1016_f518()
        {
            ii(0x1016_f518, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_f51a, 2); if(jzd(0x1016_f52a, 0xe)) goto l_0x1016_f52a; /* jz 0x1016f52a */
            ii(0x1016_f51c, 4); test(memb_a32[ds, edx + 0x4], 0x4);     /* test byte [edx+0x4], 0x4 */
            ii(0x1016_f520, 2); if(jzd(0x1016_f52a, 0x8)) goto l_0x1016_f52a; /* jz 0x1016f52a */
            ii(0x1016_f522, 3); mov(edx, memd_a32[ds, edx + 0xc]);      /* mov edx, [edx+0xc] */
            ii(0x1016_f525, 5); jmpd_func(0x1017_29f1, 0x34c7); return; /* jmp 0x101729f1 */
        l_0x1016_f52a:
            ii(0x1016_f52a, 5); mov(eax, 0xffff_ffff);                  /* mov eax, 0xffffffff */
            ii(0x1016_f52f, 1); retd(); return;                         /* ret */
        }
    }
}