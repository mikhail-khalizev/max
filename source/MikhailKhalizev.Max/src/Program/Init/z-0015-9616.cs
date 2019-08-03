using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("638fd03f-c757-4f20-bfce-34da44060c8c")]
        public void Method_0015_9616()
        {
            ii(0x15_9616, 4); enterw(0x2, 0);                           /* enter 0x2, 0x0 */
            ii(0x15_961a, 1); pushw(ds);                                /* push ds */
            ii(0x15_961b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_961e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_9620, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_9623, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_9626, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_9629, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_962c, 2); pushw(0x3);                               /* push 0x3 */
            ii(0x15_962e, 1); nop();                                    /* nop */
            ii(0x15_962f, 1); pushw(cs);                                /* push cs */
            ii(0x15_9630, 3); callw(0x16_0140, 0x6b0d);                 /* call 0x140 */
            ii(0x15_9633, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_9635, 2); if(jnzw(0x15_964e, 0x17)) goto l_0x15_964e; /* jnz 0x964e */
            ii(0x15_9637, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x15_963a, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x15_963d, 3); pushw(memw_a16[ss, bp + 0xc]);            /* push word [bp+0xc] */
            ii(0x15_9640, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x15_9643, 2); pushw(0x4);                               /* push 0x4 */
            ii(0x15_9645, 1); nop();                                    /* nop */
            ii(0x15_9646, 1); pushw(cs);                                /* push cs */
            ii(0x15_9647, 3); callw(0x16_0140, 0x6af6);                 /* call 0x140 */
            ii(0x15_964a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x15_964c, 2); if(jzw(0x15_9655, 0x7)) goto l_0x15_9655; /* jz 0x9655 */
        l_0x15_964e:
            ii(0x15_964e, 5); mov(memw_a16[ss, bp - 0x2], 0x1);         /* mov word [bp-0x2], 0x1 */
            ii(0x15_9653, 2); jmpw(0x15_965a, 0x5); goto l_0x15_965a;   /* jmp 0x965a */
        l_0x15_9655:
            ii(0x15_9655, 5); mov(memw_a16[ss, bp - 0x2], 0);           /* mov word [bp-0x2], 0x0 */
        l_0x15_965a:
            ii(0x15_965a, 3); mov(ax, memw_a16[ss, bp - 0x2]);          /* mov ax, [bp-0x2] */
            ii(0x15_965d, 1); cwd();                                    /* cwd */
            ii(0x15_965e, 1); popw(ds);                                 /* pop ds */
            ii(0x15_965f, 1); leavew();                                 /* leave */
            ii(0x15_9660, 1); retfw(); return;                          /* retf */
        }
    }
}
