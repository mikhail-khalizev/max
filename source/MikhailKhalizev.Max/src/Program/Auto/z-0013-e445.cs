using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("b1beeca1-091c-41ce-8b9e-db8e300729ef")]
        public void Method_0013_e445()
        {
            ii(0x13_e445, 1); pushw(di);                                /* push di */
            ii(0x13_e446, 3); mov(si, memw_a16[ds, bx + 0x8]);          /* mov si, [bx+0x8] */
            ii(0x13_e449, 3); cmp(si, memw_a16[ds, bx + 0xa]);          /* cmp si, [bx+0xa] */
            ii(0x13_e44c, 2); if(jnzw(0x13_e451, 0x3)) goto l_0x13_e451; /* jnz 0xe451 */
            ii(0x13_e44e, 3); mov(si, memw_a16[ds, bx + 0x6]);          /* mov si, [bx+0x6] */
        l_0x13_e451:
            ii(0x13_e451, 1); lodsw_a16();                              /* lodsw */
            ii(0x13_e452, 3); cmp(ax, 0xfffe);                          /* cmp ax, 0xfffe */
            ii(0x13_e455, 2); if(jzw(0x13_e45f, 0x8)) goto l_0x13_e45f; /* jz 0xe45f */
            ii(0x13_e457, 2); mov(di, si);                              /* mov di, si */
            ii(0x13_e459, 2); and(al, 0xfe);                            /* and al, 0xfe */
            ii(0x13_e45b, 2); add(si, ax);                              /* add si, ax */
            ii(0x13_e45d, 2); jmpw(0x13_e451, -0xe); goto l_0x13_e451;  /* jmp 0xe451 */
        l_0x13_e45f:
            ii(0x13_e45f, 1); dec(di);                                  /* dec di */
            ii(0x13_e460, 1); dec(di);                                  /* dec di */
            ii(0x13_e461, 2); mov(si, di);                              /* mov si, di */
            ii(0x13_e463, 1); popw(di);                                 /* pop di */
            ii(0x13_e464, 1); retw(); return;                           /* ret */
        }
    }
}
