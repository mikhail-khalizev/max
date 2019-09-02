using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x18_e24a-d38c80cc")]
        public void Method_0018_e24a()
        {
            ii(0x18_e24a, 3); call(0x18_e070, -0x1dd);                  /* call 0xe070 */
            ii(0x18_e24d, 2); if(jb_func(0x18_e2b3, 0x64)) return;      /* jb 0xe2b3 */
            ii(0x18_e24f, 2); if(jcxz_func(0x18_e2b3, 0x62)) return;    /* jcxz 0xe2b3 */
            ii(0x18_e251, 4); mov(ax, memw_a32[ss, ebp + 0x18]);        /* mov ax, [ebp+0x18] */
            ii(0x18_e255, 3); mov(memw[ds, bx + 2], ax);                /* mov [bx+0x2], ax */
            ii(0x18_e258, 4); mov(ax, memw_a32[ss, ebp + 0x1c]);        /* mov ax, [ebp+0x1c] */
            ii(0x18_e25c, 3); mov(memb[ds, bx + 4], al);                /* mov [bx+0x4], al */
            ii(0x18_e25f, 3); mov(memb[ds, bx + 7], ah);                /* mov [bx+0x7], ah */
            ii(0x18_e262, 3); if(jmp_func(0x18_e067, -0x1fe)) return;   /* jmp 0xe067 */
        }
    }
}
