using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_9407-6ac54810")]
        public void Method_0019_9407()
        {
            ii(0x19_9407, 4); enterw(0x8, 0);                           /* enter 0x8, 0x0 */
            ii(0x19_940b, 1); pushw(si);                                /* push si */
            ii(0x19_940c, 1); pushw(ds);                                /* push ds */
            ii(0x19_940d, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_9410, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_9412, 3); les(bx, ss, bp + 0x8);                    /* les bx, [bp+0x8] */
            ii(0x19_9415, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9417, 4); mov(memw_a16[es, bx + 0x2], ax);          /* mov [es:bx+0x2], ax */
            ii(0x19_941b, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_941e, 3); les(si, ss, bp + 0xc);                    /* les si, [bp+0xc] */
            ii(0x19_9421, 3); mov(memw_a16[es, si], ax);                /* mov [es:si], ax */
            ii(0x19_9424, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_9427, 3); callw(0x19_a14c, 0xd22);                  /* call 0xa14c */
            ii(0x19_942a, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x19_942d, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x19_9430, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_9432, 2); if(jzw(0x19_9462, 0x2e)) goto l_0x19_9462; /* jz 0x9462 */
            ii(0x19_9434, 3); les(bx, ss, bp - 0x8);                    /* les bx, [bp-0x8] */
            ii(0x19_9437, 4); mov(ax, memw_a16[es, bx + 0x3c]);         /* mov ax, [es:bx+0x3c] */
            ii(0x19_943b, 4); mov(dx, memw_a16[es, bx + 0x3e]);         /* mov dx, [es:bx+0x3e] */
            ii(0x19_943f, 3); les(si, ss, bp + 0x8);                    /* les si, [bp+0x8] */
            ii(0x19_9442, 3); mov(memw_a16[es, si], ax);                /* mov [es:si], ax */
            ii(0x19_9445, 4); mov(memw_a16[es, si + 0x2], dx);          /* mov [es:si+0x2], dx */
            ii(0x19_9449, 3); mov(es, memw_a16[ss, bp - 0x6]);          /* mov es, [bp-0x6] */
            ii(0x19_944c, 4); les(si, es, bx + 0x1c);                   /* les si, [es:bx+0x1c] */
            ii(0x19_9450, 4); mov(ax, memw_a16[es, si + 0x44]);         /* mov ax, [es:si+0x44] */
            ii(0x19_9454, 3); les(bx, ss, bp + 0xc);                    /* les bx, [bp+0xc] */
            ii(0x19_9457, 3); mov(memw_a16[es, bx], ax);                /* mov [es:bx], ax */
            ii(0x19_945a, 3); mov(ax, memw_a16[ss, bp - 0x8]);          /* mov ax, [bp-0x8] */
            ii(0x19_945d, 3); mov(dx, memw_a16[ss, bp - 0x6]);          /* mov dx, [bp-0x6] */
            ii(0x19_9460, 2); jmpw(0x19_9465, 0x3); goto l_0x19_9465;   /* jmp 0x9465 */
        l_0x19_9462:
            ii(0x19_9462, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_9464, 1); cwd();                                    /* cwd */
        l_0x19_9465:
            ii(0x19_9465, 1); popw(ds);                                 /* pop ds */
            ii(0x19_9466, 1); popw(si);                                 /* pop si */
            ii(0x19_9467, 1); leavew();                                 /* leave */
            ii(0x19_9468, 1); retfw(); return;                          /* retf */
        }
    }
}
