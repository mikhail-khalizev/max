using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e33f-a24b8ab5")]
        public void Method_0017_e33f()
        {
            ii(0x17_e33f, 1); pushw(bp);                                /* push bp */
            ii(0x17_e340, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_e342, 1); pushw(si);                                /* push si */
            ii(0x17_e343, 1); pushw(di);                                /* push di */
            ii(0x17_e344, 3); mov(cx, memw_a16[ss, bp + 0x6]);          /* mov cx, [bp+0x6] */
            ii(0x17_e347, 3); cmp(cx, -0x18 /* 0xe8 */);                /* cmp cx, 0xffe8 */
            ii(0x17_e34a, 2); if(jaw(0x17_e35e, 0x12)) goto l_0x17_e35e; /* ja 0xe35e */
            ii(0x17_e34c, 3); mov(bx, 0x13f6);                          /* mov bx, 0x13f6 */
            ii(0x17_e34f, 3); callw(0x17_e52e, 0x1dc);                  /* call 0xe52e */
            ii(0x17_e352, 2); if(jaew(0x17_e363, 0xf)) goto l_0x17_e363; /* jae 0xe363 */
            ii(0x17_e354, 3); callw(0x17_e368, 0x11);                   /* call 0xe368 */
            ii(0x17_e357, 2); if(jbw(0x17_e35e, 0x5)) goto l_0x17_e35e; /* jb 0xe35e */
            ii(0x17_e359, 3); callw(0x17_e52e, 0x1d2);                  /* call 0xe52e */
            ii(0x17_e35c, 2); if(jaew(0x17_e363, 0x5)) goto l_0x17_e363; /* jae 0xe363 */
        l_0x17_e35e:
            ii(0x17_e35e, 2); xor(ax, ax);                              /* xor ax, ax */
            ii(0x17_e360, 1); cwd();                                    /* cwd */
            ii(0x17_e361, 2); jmpw(0x17_e363, 0); goto l_0x17_e363;     /* jmp 0xe363 */
        l_0x17_e363:
            ii(0x17_e363, 1); popw(di);                                 /* pop di */
            ii(0x17_e364, 1); popw(si);                                 /* pop si */
            ii(0x17_e365, 1); popw(bp);                                 /* pop bp */
            ii(0x17_e366, 1); retfw();                                  /* retf */
        }
    }
}
