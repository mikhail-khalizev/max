using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1f5115b3-7e98-4fef-8838-8fc8885c3053")]
        public void Method_0019_9616()
        {
            ii(0x19_9616, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x19_961a, 1); pushw(ds);                                /* push ds */
            ii(0x19_961b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_961e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_9620, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_9623, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_9626, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_9629, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_962c, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x19_962e, 1); nop();                                    /* nop */
            ii(0x19_962f, 1); pushw(cs);                                /* push cs */
            ii(0x19_9630, 3); callw(0x1a_0140, 0x6b0d);                 /* call 0x140 */
            ii(0x19_9633, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9635, 2); if(jnzw(0x19_964e, 0x17)) goto l_0x19_964e; /* jnz 0x964e */
            ii(0x19_9637, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x19_963a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_963d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x19_9640, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_9643, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x19_9645, 1); nop();                                    /* nop */
            ii(0x19_9646, 1); pushw(cs);                                /* push cs */
            ii(0x19_9647, 3); callw(0x1a_0140, 0x6af6);                 /* call 0x140 */
            ii(0x19_964a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_964c, 2); if(jzw(0x19_9655, 0x7)) goto l_0x19_9655; /* jz 0x9655 */
        l_0x19_964e:
            ii(0x19_964e, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x19_9653, 2); jmpw(0x19_965a, 0x5); goto l_0x19_965a;   /* jmp 0x965a */
        l_0x19_9655:
            ii(0x19_9655, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
        l_0x19_965a:
            ii(0x19_965a, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x19_965d, 1); cwd();                                    /* cwd */
            ii(0x19_965e, 1); popw(ds);                                 /* pop ds */
            ii(0x19_965f, 1); leavew();                                 /* leave */
            ii(0x19_9660, 1); retfw(); return;                          /* retf */
        }
    }
}
