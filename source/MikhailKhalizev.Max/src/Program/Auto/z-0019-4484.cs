using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_4484-8df77b96")]
        public void Method_0019_4484()
        {
            ii(0x19_4484, 4); enterw(0x1c, 0);                          /* enter 0x1c, 0x0 */
            ii(0x19_4488, 1); pushw(di);                                /* push di */
            ii(0x19_4489, 1); pushw(si);                                /* push si */
            ii(0x19_448a, 1); pushw(ds);                                /* push ds */
            ii(0x19_448b, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_448e, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_4490, 1); nop();                                    /* nop */
            ii(0x19_4491, 1); pushw(cs);                                /* push cs */
            ii(0x19_4492, 3); callw(0x19_4638, 0x1a3);                  /* call 0x4638 */
            ii(0x19_4495, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x19_4497, 2); if(jzw(0x19_44bc, 0x23)) goto l_0x19_44bc; /* jz 0x44bc */
            ii(0x19_4499, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_449c, 3); mov(memw_a16[ss, bp - 0x10], ax);         /* mov [bp-0x10], ax */
            ii(0x19_449f, 3); pushw(memw_a16[ss, bp + 0xa]);            /* push word [bp+0xa] */
            ii(0x19_44a2, 2); pushw(0);                                 /* push 0x0 */
            ii(0x19_44a4, 3); lea(ax, bp - 0x14);                       /* lea ax, [bp-0x14] */
            ii(0x19_44a7, 1); pushw(ss);                                /* push ss */
            ii(0x19_44a8, 1); pushw(ax);                                /* push ax */
            ii(0x19_44a9, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x19_44ac, 2); pushw(0xc);                               /* push 0xc */
            ii(0x19_44ae, 1); nop();                                    /* nop */
            ii(0x19_44af, 1); pushw(cs);                                /* push cs */
            ii(0x19_44b0, 3); callw(0x19_41fd, -0x2b6);                 /* call 0x41fd */
            ii(0x19_44b3, 3); add(sp, 0xc);                             /* add sp, 0xc */
            ii(0x19_44b6, 3); mov(memw_a16[ss, bp + 0x6], ax);          /* mov [bp+0x6], ax */
            ii(0x19_44b9, 2); jmpw(0x19_44ed, 0x32); goto l_0x19_44ed;  /* jmp 0x44ed */
        //    ii(0x19_44bb, 1); nop();                                    /* nop */
        l_0x19_44bc:
            ii(0x19_44bc, 3); mov(ax, memw_a16[ds, 0x3b72]);            /* mov ax, [0x3b72] */
            ii(0x19_44bf, 3); mov(memw_a16[ss, bp - 0x1a], ax);         /* mov [bp-0x1a], ax */
            ii(0x19_44c2, 5); mov(memw_a16[ss, bp - 0x1c], 0);          /* mov word [bp-0x1c], 0x0 */
            ii(0x19_44c7, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_44ca, 2); and(al, 0xf8);                            /* and al, 0xf8 */
            ii(0x19_44cc, 3); add(ax, memw_a16[ss, bp - 0x1c]);         /* add ax, [bp-0x1c] */
            ii(0x19_44cf, 3); mov(dx, memw_a16[ss, bp - 0x1a]);         /* mov dx, [bp-0x1a] */
            ii(0x19_44d2, 3); mov(memw_a16[ss, bp - 0x18], ax);         /* mov [bp-0x18], ax */
            ii(0x19_44d5, 3); mov(memw_a16[ss, bp - 0x16], dx);         /* mov [bp-0x16], dx */
            ii(0x19_44d8, 3); les(bx, ss, bp - 0x18);                   /* les bx, [bp-0x18] */
            ii(0x19_44db, 3); mov(ax, memw_a16[ss, bp + 0x8]);          /* mov ax, [bp+0x8] */
            ii(0x19_44de, 3); mov(dx, memw_a16[ss, bp + 0xa]);          /* mov dx, [bp+0xa] */
            ii(0x19_44e1, 2); mov(di, bx);                              /* mov di, bx */
            ii(0x19_44e3, 2); mov(si, ax);                              /* mov si, ax */
            ii(0x19_44e5, 1); pushw(ds);                                /* push ds */
            ii(0x19_44e6, 2); mov(ds, dx);                              /* mov ds, dx */
            ii(0x19_44e8, 1); movsw_a16();                              /* movsw */
            ii(0x19_44e9, 1); movsw_a16();                              /* movsw */
            ii(0x19_44ea, 1); movsw_a16();                              /* movsw */
            ii(0x19_44eb, 1); movsw_a16();                              /* movsw */
            ii(0x19_44ec, 1); popw(ds);                                 /* pop ds */
        l_0x19_44ed:
            ii(0x19_44ed, 3); mov(ax, memw_a16[ss, bp + 0x6]);          /* mov ax, [bp+0x6] */
            ii(0x19_44f0, 1); popw(ds);                                 /* pop ds */
            ii(0x19_44f1, 1); popw(si);                                 /* pop si */
            ii(0x19_44f2, 1); popw(di);                                 /* pop di */
            ii(0x19_44f3, 1); leavew();                                 /* leave */
            ii(0x19_44f4, 1); retfw(); return;                          /* retf */
        }
    }
}
