using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_e445-8020fe71")]
        public void Method_0017_e445()
        {
            ii(0x17_e445, 1); push(di);                                 /* push di */
            ii(0x17_e446, 3); mov(si, memw[ds, bx + 8]);                /* mov si, [bx+0x8] */
            ii(0x17_e449, 3); cmp(si, memw[ds, bx + 0xa]);              /* cmp si, [bx+0xa] */
            ii(0x17_e44c, 2); if(jnz(0x17_e451, 3)) goto l_0x17_e451;   /* jnz 0xe451 */
            ii(0x17_e44e, 3); mov(si, memw[ds, bx + 6]);                /* mov si, [bx+0x6] */
        l_0x17_e451:
            ii(0x17_e451, 1); lodsw();                                  /* lodsw */
            ii(0x17_e452, 3); cmp(ax, 0xfffe);                          /* cmp ax, 0xfffe */
            ii(0x17_e455, 2); if(jz(0x17_e45f, 8)) goto l_0x17_e45f;    /* jz 0xe45f */
            ii(0x17_e457, 2); mov(di, si);                              /* mov di, si */
            ii(0x17_e459, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x17_e45b, 2); add(si, ax);                              /* add si, ax */
            ii(0x17_e45d, 2); jmp(0x17_e451, -0xe); goto l_0x17_e451;   /* jmp 0xe451 */
        l_0x17_e45f:
            ii(0x17_e45f, 1); dec(di);                                  /* dec di */
            ii(0x17_e460, 1); dec(di);                                  /* dec di */
            ii(0x17_e461, 2); mov(si, di);                              /* mov si, di */
            ii(0x17_e463, 1); pop(di);                                  /* pop di */
            ii(0x17_e464, 1); ret();                                    /* ret */
        }
    }
}
