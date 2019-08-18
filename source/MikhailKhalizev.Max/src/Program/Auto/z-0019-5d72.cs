using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2898f34b-6663-41fb-8a39-49bb1b2611cc")]
        public void Method_0019_5d72()
        {
            ii(0x19_5d72, 4); enterw(0x14, 0);                          /* enter 0x14, 0x0 */
            ii(0x19_5d76, 1); pushw(di);                                /* push di */
            ii(0x19_5d77, 1); pushw(si);                                /* push si */
            ii(0x19_5d78, 5); mov(memw_a16[ss, bp - 0x2], 0xff00);      /* mov word [bp-0x2], 0xff00 */
            ii(0x19_5d7d, 5); mov(memw_a16[ss, bp - 0x6], 0x11ff);      /* mov word [bp-0x6], 0x11ff */
            ii(0x19_5d82, 3); mov(ax, 0);                               /* mov ax, 0x0 */
            ii(0x19_5d85, 3); mov(memw_a16[ss, bp - 0x14], ax);         /* mov [bp-0x14], ax */
            ii(0x19_5d88, 3); mov(memw_a16[ss, bp - 0x12], ax);         /* mov [bp-0x12], ax */
            ii(0x19_5d8b, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_5d8e, 1); pushw(ss);                                /* push ss */
            ii(0x19_5d8f, 1); pushw(ax);                                /* push ax */
            ii(0x19_5d90, 3); pushw(memw_a16[ss, bp - 0x2]);            /* push word [bp-0x2] */
            ii(0x19_5d93, 5); callw_far_abs(0x80, 0x4c9f);              /* call word 0x80:0x4c9f */
            ii(0x19_5d98, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x19_5d9b, 3); jmpw(0x19_5d9e, 0); goto l_0x19_5d9e;     /* jmp 0x5d9e */
        l_0x19_5d9e:
            ii(0x19_5d9e, 1); popw(si);                                 /* pop si */
            ii(0x19_5d9f, 1); popw(di);                                 /* pop di */
            ii(0x19_5da0, 1); leavew();                                 /* leave */
            ii(0x19_5da1, 1); retfw(); return;                          /* retf */
        }
    }
}
