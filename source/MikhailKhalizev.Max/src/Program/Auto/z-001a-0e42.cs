using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1a_0e42-aaa5782d")]
        public void Method_001a_0e42()
        {
            ii(0x1a_0e42, 4); enter(8, 0);                              /* enter 0x8, 0x0 */
            ii(0x1a_0e46, 3); mov(ax, memw[ss, bp + 6]);                /* mov ax, [bp+0x6] */
            ii(0x1a_0e49, 3); mov(dx, memw[ss, bp + 8]);                /* mov dx, [bp+0x8] */
            ii(0x1a_0e4c, 3); mov(memw[ss, bp - 4], ax);                /* mov [bp-0x4], ax */
            ii(0x1a_0e4f, 3); mov(memw[ss, bp - 2], dx);                /* mov [bp-0x2], dx */
            ii(0x1a_0e52, 3); add(ax, memw[ss, bp + 10]);               /* add ax, [bp+0xa] */
            ii(0x1a_0e55, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x1a_0e58, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x1a_0e5b, 2); jmp(0x1a_0e7a, 0x1d); goto l_0x1a_0e7a;   /* jmp 0xe7a */
        l_0x1a_0e5d:
            ii(0x1a_0e5d, 3); push(memw[ss, bp + 10]);                  /* push word [bp+0xa] */
            ii(0x1a_0e60, 3); push(memw[ss, bp - 2]);                   /* push word [bp-0x2] */
            ii(0x1a_0e63, 3); push(memw[ss, bp - 4]);                   /* push word [bp-0x4] */
            ii(0x1a_0e66, 3); push(memw[ss, bp - 6]);                   /* push word [bp-0x6] */
            ii(0x1a_0e69, 3); push(memw[ss, bp - 8]);                   /* push word [bp-0x8] */
            ii(0x1a_0e6c, 1); nop();                                    /* nop */
            ii(0x1a_0e6d, 1); push(cs);                                 /* push cs */
            ii(0x1a_0e6e, 3); call(0x1a_0f5f, 0xee);                    /* call 0xf5f */
            ii(0x1a_0e71, 3); add(sp, 0xa);                             /* add sp, 0xa */
            ii(0x1a_0e74, 3); mov(ax, memw[ss, bp + 10]);               /* mov ax, [bp+0xa] */
            ii(0x1a_0e77, 3); add(memw[ss, bp - 8], ax);                /* add [bp-0x8], ax */
        l_0x1a_0e7a:
            ii(0x1a_0e7a, 3); dec(memw[ss, bp + 12]);                   /* dec word [bp+0xc] */
            ii(0x1a_0e7d, 2); if(jnz(0x1a_0e5d, -0x22)) goto l_0x1a_0e5d; /* jnz 0xe5d */
            ii(0x1a_0e7f, 1); leave();                                  /* leave */
            ii(0x1a_0e80, 1); retf();                                   /* retf */
        }
    }
}
