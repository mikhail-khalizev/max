using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x19_5ec8-cbc172dd")]
        public void Method_0019_5ec8()
        {
            ii(0x19_5ec8, 4); enter(0xa, 0);                            /* enter 0xa, 0x0 */
            ii(0x19_5ecc, 1); push(di);                                 /* push di */
            ii(0x19_5ecd, 1); push(si);                                 /* push si */
            ii(0x19_5ece, 1); push(ds);                                 /* push ds */
            ii(0x19_5ecf, 3); mov(ax, 0xa8);                            /* mov ax, 0xa8 */
            ii(0x19_5ed2, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x19_5ed4, 5); cmp(memw[ds, 0x1208], 0);                 /* cmp word [0x1208], 0x0 */
            ii(0x19_5ed9, 2); if(jnz(0x19_5ede, 3)) goto l_0x19_5ede;   /* jnz 0x5ede */
            ii(0x19_5edb, 3); jmp(0x19_5eee, 0x10); goto l_0x19_5eee;   /* jmp 0x5eee */
        l_0x19_5ede:
            ii(0x19_5ede, 1); push(ds);                                 /* push ds */
            ii(0x19_5edf, 3); push(0x1175);                             /* push 0x1175 */
            ii(0x19_5ee2, 3); push(0x7d0);                              /* push 0x7d0 */
            ii(0x19_5ee5, 3); call(0x19_104e, -0x4e9a);                 /* call 0x104e */
            ii(0x19_5ee8, 3); add(sp, 6);                               /* add sp, 0x6 */
            ii(0x19_5eeb, 3); jmp(0x19_5f76, 0x88); goto l_0x19_5f76;   /* jmp 0x5f76 */
        l_0x19_5eee:
            ii(0x19_5eee, 4); inc(memw[ds, 0x1208]);                    /* inc word [0x1208] */
            ii(0x19_5ef2, 1); push(ds);                                 /* push ds */
            ii(0x19_5ef3, 3); push(0x118b);                             /* push 0x118b */
            ii(0x19_5ef6, 3); call(0x19_1066, -0x4e93);                 /* call 0x1066 */
            ii(0x19_5ef9, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_5efc, 2); push(0);                                  /* push 0x0 */
            ii(0x19_5efe, 1); nop();                                    /* nop */
            ii(0x19_5eff, 1); push(cs);                                 /* push cs */
            ii(0x19_5f00, 3); call(0x18_f57c, -0x6987);                 /* call 0xf57c */
            ii(0x19_5f03, 3); add(sp, 2);                               /* add sp, 0x2 */
            ii(0x19_5f06, 5); mov(memw[ss, bp - 10], 0);                /* mov word [bp-0xa], 0x0 */
            ii(0x19_5f0b, 3); jmp(0x19_5f11, 3); goto l_0x19_5f11;      /* jmp 0x5f11 */
        l_0x19_5f0e:
            ii(0x19_5f0e, 3); inc(memw[ss, bp - 10]);                   /* inc word [bp-0xa] */
        l_0x19_5f11:
            ii(0x19_5f11, 3); mov(bx, memw[ss, bp - 10]);               /* mov bx, [bp-0xa] */
            ii(0x19_5f14, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_5f17, 4); mov(ax, memw[ds, bx + 4594]);             /* mov ax, [bx+0x11f2] */
            ii(0x19_5f1b, 4); or(ax, memw[ds, bx + 4592]);              /* or ax, [bx+0x11f0] */
            ii(0x19_5f1f, 2); if(jnz(0x19_5f24, 3)) goto l_0x19_5f24;   /* jnz 0x5f24 */
            ii(0x19_5f21, 3); jmp(0x19_5f69, 0x45); goto l_0x19_5f69;   /* jmp 0x5f69 */
        l_0x19_5f24:
            ii(0x19_5f24, 3); mov(bx, memw[ss, bp - 10]);               /* mov bx, [bp-0xa] */
            ii(0x19_5f27, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_5f2a, 4); push(memw[ds, bx + 4594]);                /* push word [bx+0x11f2] */
            ii(0x19_5f2e, 4); push(memw[ds, bx + 4592]);                /* push word [bx+0x11f0] */
            ii(0x19_5f32, 1); push(ds);                                 /* push ds */
            ii(0x19_5f33, 3); push(0x11b0);                             /* push 0x11b0 */
            ii(0x19_5f36, 3); call(0x18_fcad, -0x628c);                 /* call 0xfcad */
            ii(0x19_5f39, 3); mov(memw[ss, bp - 8], ax);                /* mov [bp-0x8], ax */
            ii(0x19_5f3c, 3); mov(memw[ss, bp - 6], dx);                /* mov [bp-0x6], dx */
            ii(0x19_5f3f, 2); or(dx, ax);                               /* or dx, ax */
            ii(0x19_5f41, 2); if(jnz(0x19_5f46, 3)) goto l_0x19_5f46;   /* jnz 0x5f46 */
            ii(0x19_5f43, 3); jmp(0x19_5f66, 0x20); goto l_0x19_5f66;   /* jmp 0x5f66 */
        l_0x19_5f46:
            ii(0x19_5f46, 3); mov(bx, memw[ss, bp - 10]);               /* mov bx, [bp-0xa] */
            ii(0x19_5f49, 3); shl(bx, 2);                               /* shl bx, 0x2 */
            ii(0x19_5f4c, 4); push(memw[ds, bx + 4594]);                /* push word [bx+0x11f2] */
            ii(0x19_5f50, 4); push(memw[ds, bx + 4592]);                /* push word [bx+0x11f0] */
            ii(0x19_5f54, 1); push(ds);                                 /* push ds */
            ii(0x19_5f55, 3); push(0x11b7);                             /* push 0x11b7 */
            ii(0x19_5f58, 3); call(0x19_1066, -0x4ef5);                 /* call 0x1066 */
            ii(0x19_5f5b, 3); add(sp, 8);                               /* add sp, 0x8 */
            ii(0x19_5f5e, 2); push(0);                                  /* push 0x0 */
            ii(0x19_5f60, 3); call_far_ind(memw[ss, bp - 8]);           /* call far word [bp-0x8] */
            ii(0x19_5f63, 3); add(sp, 2);                               /* add sp, 0x2 */
        l_0x19_5f66:
            ii(0x19_5f66, 3); jmp(0x19_5f0e, -0x5b); goto l_0x19_5f0e;  /* jmp 0x5f0e */
        l_0x19_5f69:
            ii(0x19_5f69, 1); push(ds);                                 /* push ds */
            ii(0x19_5f6a, 3); push(0x11ce);                             /* push 0x11ce */
            ii(0x19_5f6d, 3); call(0x19_1066, -0x4f0a);                 /* call 0x1066 */
            ii(0x19_5f70, 3); add(sp, 4);                               /* add sp, 0x4 */
            ii(0x19_5f73, 3); call(0x19_55db, -0x99b);                  /* call 0x55db */
        l_0x19_5f76:
            ii(0x19_5f76, 1); pop(ds);                                  /* pop ds */
            ii(0x19_5f77, 1); pop(si);                                  /* pop si */
            ii(0x19_5f78, 1); pop(di);                                  /* pop di */
            ii(0x19_5f79, 1); leave();                                  /* leave */
            ii(0x19_5f7a, 1); retf();                                   /* retf */
        }
    }
}
