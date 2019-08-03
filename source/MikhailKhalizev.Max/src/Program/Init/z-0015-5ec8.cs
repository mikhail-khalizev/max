using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("f9064976-d04a-4907-bfb7-5d3d293b33cc")]
        public void Method_0015_5ec8()
        {
            ii(0x15_5ec8, 4); enterw(0xa, 0);                           /* enter 0xa, 0x0 */
            ii(0x15_5ecc, 1); pushw(di);                                /* push di */
            ii(0x15_5ecd, 1); pushw(si);                                /* push si */
            ii(0x15_5ece, 1); pushw(ds);                                /* push ds */
            ii(0x15_5ecf, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x15_5ed2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x15_5ed4, 5); cmp(memw_a16[ds, 0x1208], 0);             /* cmp word [0x1208], 0x0 */
            ii(0x15_5ed9, 2); if(jnzw(0x15_5ede, 0x3)) goto l_0x15_5ede; /* jnz 0x5ede */
            ii(0x15_5edb, 3); jmpw(0x15_5eee, 0x10); goto l_0x15_5eee;  /* jmp 0x5eee */
        l_0x15_5ede:
            ii(0x15_5ede, 1); pushw(ds);                                /* push ds */
            ii(0x15_5edf, 3); pushw(0x1175);                            /* push 0x1175 */
            ii(0x15_5ee2, 3); pushw(0x7d0);                             /* push 0x7d0 */
            ii(0x15_5ee5, 3); callw(0x15_104e, -0x4e9a);                /* call 0x104e */
            ii(0x15_5ee8, 3); add(sp, 0x6);                             /* add sp, 0x6 */
            ii(0x15_5eeb, 3); jmpw(0x15_5f76, 0x88); goto l_0x15_5f76;  /* jmp 0x5f76 */
        l_0x15_5eee:
            ii(0x15_5eee, 4); inc(memw_a16[ds, 0x1208]);                /* inc word [0x1208] */
            ii(0x15_5ef2, 1); pushw(ds);                                /* push ds */
            ii(0x15_5ef3, 3); pushw(0x118b);                            /* push 0x118b */
            ii(0x15_5ef6, 3); callw(0x15_1066, -0x4e93);                /* call 0x1066 */
            ii(0x15_5ef9, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_5efc, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_5efe, 1); nop();                                    /* nop */
            ii(0x15_5eff, 1); pushw(cs);                                /* push cs */
            ii(0x15_5f00, 3); callw(0x14_f57c, -0x6987);                /* call 0xf57c */
            ii(0x15_5f03, 3); add(sp, 0x2);                             /* add sp, 0x2 */
            ii(0x15_5f06, 5); mov(memw_a16[ss, bp - 0xa], 0);           /* mov word [bp-0xa], 0x0 */
            ii(0x15_5f0b, 3); jmpw(0x15_5f11, 0x3); goto l_0x15_5f11;   /* jmp 0x5f11 */
        l_0x15_5f0e:
            ii(0x15_5f0e, 3); inc(memw_a16[ss, bp - 0xa]);              /* inc word [bp-0xa] */
        l_0x15_5f11:
            ii(0x15_5f11, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x15_5f14, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_5f17, 4); mov(ax, memw_a16[ds, bx + 0x11f2]);       /* mov ax, [bx+0x11f2] */
            ii(0x15_5f1b, 4); or(ax, memw_a16[ds, bx + 0x11f0]);        /* or ax, [bx+0x11f0] */
            ii(0x15_5f1f, 2); if(jnzw(0x15_5f24, 0x3)) goto l_0x15_5f24; /* jnz 0x5f24 */
            ii(0x15_5f21, 3); jmpw(0x15_5f69, 0x45); goto l_0x15_5f69;  /* jmp 0x5f69 */
        l_0x15_5f24:
            ii(0x15_5f24, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x15_5f27, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_5f2a, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x15_5f2e, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x15_5f32, 1); pushw(ds);                                /* push ds */
            ii(0x15_5f33, 3); pushw(0x11b0);                            /* push 0x11b0 */
            ii(0x15_5f36, 3); callw(0x14_fcad, -0x628c);                /* call 0xfcad */
            ii(0x15_5f39, 3); mov(memw_a16[ss, bp - 0x8], ax);          /* mov [bp-0x8], ax */
            ii(0x15_5f3c, 3); mov(memw_a16[ss, bp - 0x6], dx);          /* mov [bp-0x6], dx */
            ii(0x15_5f3f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x15_5f41, 2); if(jnzw(0x15_5f46, 0x3)) goto l_0x15_5f46; /* jnz 0x5f46 */
            ii(0x15_5f43, 3); jmpw(0x15_5f66, 0x20); goto l_0x15_5f66;  /* jmp 0x5f66 */
        l_0x15_5f46:
            ii(0x15_5f46, 3); mov(bx, memw_a16[ss, bp - 0xa]);          /* mov bx, [bp-0xa] */
            ii(0x15_5f49, 3); shl(bx, 0x2);                             /* shl bx, 0x2 */
            ii(0x15_5f4c, 4); pushw(memw_a16[ds, bx + 0x11f2]);         /* push word [bx+0x11f2] */
            ii(0x15_5f50, 4); pushw(memw_a16[ds, bx + 0x11f0]);         /* push word [bx+0x11f0] */
            ii(0x15_5f54, 1); pushw(ds);                                /* push ds */
            ii(0x15_5f55, 3); pushw(0x11b7);                            /* push 0x11b7 */
            ii(0x15_5f58, 3); callw(0x15_1066, -0x4ef5);                /* call 0x1066 */
            ii(0x15_5f5b, 3); add(sp, 0x8);                             /* add sp, 0x8 */
            ii(0x15_5f5e, 2); pushw(0);                                 /* push 0x0 */
            ii(0x15_5f60, 3); callw_a16_far_ind(ss, bp - 0x8);          /* call far word [bp-0x8] */
            ii(0x15_5f63, 3); add(sp, 0x2);                             /* add sp, 0x2 */
        l_0x15_5f66:
            ii(0x15_5f66, 3); jmpw(0x15_5f0e, -0x5b); goto l_0x15_5f0e; /* jmp 0x5f0e */
        l_0x15_5f69:
            ii(0x15_5f69, 1); pushw(ds);                                /* push ds */
            ii(0x15_5f6a, 3); pushw(0x11ce);                            /* push 0x11ce */
            ii(0x15_5f6d, 3); callw(0x15_1066, -0x4f0a);                /* call 0x1066 */
            ii(0x15_5f70, 3); add(sp, 0x4);                             /* add sp, 0x4 */
            ii(0x15_5f73, 3); callw(0x15_55db, -0x99b);                 /* call 0x55db */
        l_0x15_5f76:
            ii(0x15_5f76, 1); popw(ds);                                 /* pop ds */
            ii(0x15_5f77, 1); popw(si);                                 /* pop si */
            ii(0x15_5f78, 1); popw(di);                                 /* pop di */
            ii(0x15_5f79, 1); leavew();                                 /* leave */
            ii(0x15_5f7a, 1); retfw(); return;                          /* retf */
        }
    }
}
