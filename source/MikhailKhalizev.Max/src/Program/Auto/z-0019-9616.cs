using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9616-ac51ab36")]
        public void Method_0019_9616()
        {
            ii(0x19_9616, 4); enter(2, 0);                              /* enter 0x2, 0x0 */
            ii(0x19_961a, 1); push(ds);                                 /* push ds */
            ii(0x19_961b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_961e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_9620, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_9623, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_9626, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_9629, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_962c, 2); push(3);                                  /* push 0x3 */
            ii(0x19_962e, 1); nop();                                    /* nop */
            ii(0x19_962f, 1); push(cs);                                 /* push cs */
            ii(0x19_9630, 3); call(0x1a_0140, 0x6b0d);                  /* call 0x140 */
            ii(0x19_9633, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_9635, 2); if(jnz(0x19_964e, 0x17)) goto l_0x19_964e; /* jnz 0x964e */
            ii(0x19_9637, 3); push(memw[ss, bp + 8]);                   /* push word [bp+0x8] */
            ii(0x19_963a, 3); push(memw[ss, bp + 6]);                   /* push word [bp+0x6] */
            ii(0x19_963d, 3); push(memw[ss, bp + 12]);                  /* push word [bp+0xc] */
            ii(0x19_9640, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x19_9643, 2); push(4);                                  /* push 0x4 */
            ii(0x19_9645, 1); nop();                                    /* nop */
            ii(0x19_9646, 1); push(cs);                                 /* push cs */
            ii(0x19_9647, 3); call(0x1a_0140, 0x6af6);                  /* call 0x140 */
            ii(0x19_964a, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_964c, 2); if(jz(0x19_9655, 7)) goto l_0x19_9655;    /* jz 0x9655 */
        l_0x19_964e:
            ii(0x19_964e, 5); mov(memw[ss, bp - 2], 1);                 /* mov word [bp-0x2], 0x1 */
            ii(0x19_9653, 2); jmp(0x19_965a, 5); goto l_0x19_965a;      /* jmp 0x965a */
        l_0x19_9655:
            ii(0x19_9655, 5); mov(memw[ss, bp - 2], 0);                 /* mov word [bp-0x2], 0x0 */
        l_0x19_965a:
            ii(0x19_965a, 3); mov(ax, memw[ss, bp - 2]);                /* mov ax, [bp-0x2] */
            ii(0x19_965d, 1); cwd();                                    /* cwd */
            ii(0x19_965e, 1); pop(ds);                                  /* pop ds */
            ii(0x19_965f, 1); leave();                                  /* leave */
            ii(0x19_9660, 1); retf();                                   /* retf */
        }
    }
}
