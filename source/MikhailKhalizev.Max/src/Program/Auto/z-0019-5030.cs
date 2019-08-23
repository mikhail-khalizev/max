using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5030-45fbf8d5")]
        public void Method_0019_5030()
        {
            ii(0x19_5030, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x19_5034, 1); push(ds);                                 /* push ds */
            ii(0x19_5035, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_5038, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_503a, 4); mov(es, memw[ds, 0x3fe8]);                /* mov es, [0x3fe8] */
            ii(0x19_503e, 4); mov(ax, memw[es, 0x3b78]);                /* mov ax, [es:0x3b78] */
            ii(0x19_5042, 2); sub(bx, bx);                              /* sub bx, bx */
            ii(0x19_5044, 2); mov(es, ax);                              /* mov es, ax */
            ii(0x19_5046, 4); mov(ax, memw[es, bx + 0x42]);             /* mov ax, [es:bx+0x42] */
            ii(0x19_504a, 4); mov(dx, memw[es, bx + 0x44]);             /* mov dx, [es:bx+0x44] */
        l_0x19_504e:
            ii(0x19_504e, 3); mov(memw[ss, bp - 0x4], ax);              /* mov [bp-0x4], ax */
            ii(0x19_5051, 3); mov(memw[ss, bp - 0x2], dx);              /* mov [bp-0x2], dx */
            ii(0x19_5054, 2); mov(ax, dx);                              /* mov ax, dx */
            ii(0x19_5056, 3); or(ax, memw[ss, bp - 0x4]);               /* or ax, [bp-0x4] */
            ii(0x19_5059, 2); if(jz(0x19_508c, 0x31)) goto l_0x19_508c; /* jz 0x508c */
            ii(0x19_505b, 3); les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0x19_505e, 4); push(memw[es, bx + 0x6]);                 /* push word [es:bx+0x6] */
            ii(0x19_5062, 4); push(memw[es, bx + 0x4]);                 /* push word [es:bx+0x4] */
            ii(0x19_5066, 3); push(memw[ss, bp + 0x8]);                 /* push word [bp+0x8] */
            ii(0x19_5069, 3); push(memw[ss, bp + 0x6]);                 /* push word [bp+0x6] */
            ii(0x19_506c, 1); push(cs);                                 /* push cs */
            ii(0x19_506d, 3); call(0x19_4e68, -0x208);                  /* call 0x4e68 */
            ii(0x19_5070, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x19_5073, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_5075, 2); if(jz(0x19_5080, 0x9)) goto l_0x19_5080;  /* jz 0x5080 */
            ii(0x19_5077, 3); mov(ax, memw[ss, bp - 0x4]);              /* mov ax, [bp-0x4] */
            ii(0x19_507a, 3); mov(dx, memw[ss, bp - 0x2]);              /* mov dx, [bp-0x2] */
            ii(0x19_507d, 1); pop(ds);                                  /* pop ds */
            ii(0x19_507e, 1); leave();                                  /* leave */
            ii(0x19_507f, 1); retf(); return;                           /* retf */
        l_0x19_5080:
            ii(0x19_5080, 3); les(bx, memw[ss, bp - 0x4]);              /* les bx, [bp-0x4] */
            ii(0x19_5083, 3); mov(ax, memw[es, bx]);                    /* mov ax, [es:bx] */
            ii(0x19_5086, 4); mov(dx, memw[es, bx + 0x2]);              /* mov dx, [es:bx+0x2] */
            ii(0x19_508a, 2); jmp(0x19_504e, -0x3e); goto l_0x19_504e;  /* jmp 0x504e */
        l_0x19_508c:
            ii(0x19_508c, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x19_508e, 1); cwd();                                    /* cwd */
            ii(0x19_508f, 1); pop(ds);                                  /* pop ds */
            ii(0x19_5090, 1); leave();                                  /* leave */
            ii(0x19_5091, 1); retf();                                   /* retf */
        }
    }
}
