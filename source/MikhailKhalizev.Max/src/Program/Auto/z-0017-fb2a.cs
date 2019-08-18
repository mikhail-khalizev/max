using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("e4750220-e564-449d-915b-11757884642e")]
        public void Method_0017_fb2a()
        {
            ii(0x17_fb2a, 4); enterw(0x28, 0);                          /* enter 0x28, 0x0 */
            ii(0x17_fb2e, 1); pushw(ds);                                /* push ds */
            ii(0x17_fb2f, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_fb32, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_fb34, 3); mov(ax, memw_a16[ds, 0x154e]);            /* mov ax, [0x154e] */
            ii(0x17_fb37, 4); or(ax, memw_a16[ds, 0x154c]);             /* or ax, [0x154c] */
            ii(0x17_fb3b, 2); if(jnzw(0x17_fb4f, 0x12)) goto l_0x17_fb4f; /* jnz 0xfb4f */
            ii(0x17_fb3d, 1); pushw(ds);                                /* push ds */
            ii(0x17_fb3e, 3); pushw(0x19c1);                            /* push 0x19c1 */
            ii(0x17_fb41, 1); pushw(ds);                                /* push ds */
            ii(0x17_fb42, 3); pushw(0x19b4);                            /* push 0x19b4 */
            ii(0x17_fb45, 3); callw(0x17_f569, -0x5df);                 /* call 0xf569 */
            ii(0x17_fb48, 3); mov(memw_a16[ds, 0x154c], ax);            /* mov [0x154c], ax */
            ii(0x17_fb4b, 4); mov(memw_a16[ds, 0x154e], dx);            /* mov [0x154e], dx */
        l_0x17_fb4f:
            ii(0x17_fb4f, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x17_fb52, 1); pushw(ss);                                /* push ss */
            ii(0x17_fb53, 1); pushw(ax);                                /* push ax */
            ii(0x17_fb54, 3); pushw(memw_a16[ss, bp + 0x8]);            /* push word [bp+0x8] */
            ii(0x17_fb57, 3); pushw(memw_a16[ss, bp + 0x6]);            /* push word [bp+0x6] */
            ii(0x17_fb5a, 3); callw(0x17_f719, -0x444);                 /* call 0xf719 */
            ii(0x17_fb5d, 3); mov(ax, memw_a16[ds, 0x154e]);            /* mov ax, [0x154e] */
            ii(0x17_fb60, 4); or(ax, memw_a16[ds, 0x154c]);             /* or ax, [0x154c] */
            ii(0x17_fb64, 2); if(jzw(0x17_fb73, 0xd)) goto l_0x17_fb73; /* jz 0xfb73 */
            ii(0x17_fb66, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x17_fb69, 1); pushw(ss);                                /* push ss */
            ii(0x17_fb6a, 1); pushw(ax);                                /* push ax */
            ii(0x17_fb6b, 4); callw_a16_far_ind(ds, 0x154c);            /* call far word [0x154c] */
            ii(0x17_fb6f, 1); popw(bx);                                 /* pop bx */
            ii(0x17_fb70, 1); popw(bx);                                 /* pop bx */
            ii(0x17_fb71, 2); jmpw(0x17_fb8b, 0x18); goto l_0x17_fb8b;  /* jmp 0xfb8b */
        l_0x17_fb73:
            ii(0x17_fb73, 3); lea(ax, bp - 0x26);                       /* lea ax, [bp-0x26] */
            ii(0x17_fb76, 1); pushw(ax);                                /* push ax */
            ii(0x17_fb77, 1); nop();                                    /* nop */
            ii(0x17_fb78, 1); pushw(cs);                                /* push cs */
            ii(0x17_fb79, 3); callw(0x17_db32, -0x204a);                /* call 0xdb32 */
            ii(0x17_fb7c, 1); popw(bx);                                 /* pop bx */
            ii(0x17_fb7d, 3); mov(memw_a16[ss, bp - 0x28], ax);         /* mov [bp-0x28], ax */
            ii(0x17_fb80, 2); or(ax, ax);                               /* or ax, ax */
            ii(0x17_fb82, 2); if(jzw(0x17_fb88, 0x4)) goto l_0x17_fb88; /* jz 0xfb88 */
            ii(0x17_fb84, 2); mov(dx, ds);                              /* mov dx, ds */
            ii(0x17_fb86, 2); jmpw(0x17_fb8b, 0x3); goto l_0x17_fb8b;   /* jmp 0xfb8b */
        l_0x17_fb88:
            ii(0x17_fb88, 2); sub(ax, ax);                              /* sub ax, ax */
            ii(0x17_fb8a, 1); cwd();                                    /* cwd */
        l_0x17_fb8b:
            ii(0x17_fb8b, 1); popw(ds);                                 /* pop ds */
            ii(0x17_fb8c, 1); leavew();                                 /* leave */
            ii(0x17_fb8d, 3); retfw(0x4); return;                       /* retf 0x4 */
        }
    }
}
