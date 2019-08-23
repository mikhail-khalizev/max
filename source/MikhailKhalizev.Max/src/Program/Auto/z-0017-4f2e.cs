using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_4f2e-23cbcf8c")]
        public void Method_0017_4f2e()
        {
            ii(0x17_4f2e, 4); enter(0x4, 0);                            /* enter 0x4, 0x0 */
            ii(0x17_4f32, 1); push(ds);                                 /* push ds */
            ii(0x17_4f33, 3); mov(ax, 0x3e68);                          /* mov ax, 0x3e68 */
            ii(0x17_4f36, 2); mov(ds, ax);                              /* mov ds, ax */
            ii(0x17_4f38, 5); mov(memw[ss, bp - 0x4], 0x1);             /* mov word [bp-0x4], 0x1 */
            ii(0x17_4f3d, 4); mov(es, memw[ds, 0x1dc8]);                /* mov es, [0x1dc8] */
            ii(0x17_4f41, 6); cmp(memb[es, 0x2f], 0x4);                 /* cmp byte [es:0x2f], 0x4 */
            ii(0x17_4f47, 2); if(jl(0x17_4f4d, 0x4)) goto l_0x17_4f4d;  /* jl 0x4f4d */
            ii(0x17_4f49, 4); inc(memb[ds, 0x9c]);                      /* inc byte [0x9c] */
        l_0x17_4f4d:
            ii(0x17_4f4d, 4); mov(al, memb[es, 0x50]);                  /* mov al, [es:0x50] */
            ii(0x17_4f51, 3); mov(memb[ss, bp - 0x2], al);              /* mov [bp-0x2], al */
            ii(0x17_4f54, 2); cmp(al, 0xe);                             /* cmp al, 0xe */
            ii(0x17_4f56, 2); if(jg(0x17_4f7a, 0x22)) goto l_0x17_4f7a; /* jg 0x4f7a */
            ii(0x17_4f58, 2); cmp(al, 0x7);                             /* cmp al, 0x7 */
            ii(0x17_4f5a, 2); if(jl(0x17_4f7a, 0x1e)) goto l_0x17_4f7a; /* jl 0x4f7a */
            ii(0x17_4f5c, 5); mov(memb[ds, 0xb2], 0x1);                 /* mov byte [0xb2], 0x1 */
            ii(0x17_4f61, 5); mov(cx, memw[es, 0x4a]);                  /* mov cx, [es:0x4a] */
            ii(0x17_4f66, 4); mov(memw[ds, 0xb4], cx);                  /* mov [0xb4], cx */
            ii(0x17_4f6a, 2); mov(cl, 0xe);                             /* mov cl, 0xe */
            ii(0x17_4f6c, 2); sub(cl, al);                              /* sub cl, al */
            ii(0x17_4f6e, 3); mov(al, memb[ss, bp - 0x4]);              /* mov al, [bp-0x4] */
            ii(0x17_4f71, 2); shl(al, cl);                              /* shl al, cl */
            ii(0x17_4f73, 3); mov(memb[ds, 0xb6], al);                  /* mov [0xb6], al */
            ii(0x17_4f76, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4f77, 1); leave();                                  /* leave */
            ii(0x17_4f78, 1); retf(); return;                           /* retf */
        //  ii(0x17_4f79, 1); Недостижимый код.
        l_0x17_4f7a:
            ii(0x17_4f7a, 4); mov(al, memb[es, 0x51]);                  /* mov al, [es:0x51] */
            ii(0x17_4f7e, 3); mov(memb[ss, bp - 0x2], al);              /* mov [bp-0x2], al */
            ii(0x17_4f81, 2); cmp(al, 0xe);                             /* cmp al, 0xe */
            ii(0x17_4f83, 2); if(jg(0x17_4fa6, 0x21)) goto l_0x17_4fa6; /* jg 0x4fa6 */
            ii(0x17_4f85, 2); cmp(al, 0x7);                             /* cmp al, 0x7 */
            ii(0x17_4f87, 2); if(jl(0x17_4fa6, 0x1d)) goto l_0x17_4fa6; /* jl 0x4fa6 */
            ii(0x17_4f89, 5); mov(memb[ds, 0xb2], 0x1);                 /* mov byte [0xb2], 0x1 */
            ii(0x17_4f8e, 5); mov(cx, memw[es, 0x4c]);                  /* mov cx, [es:0x4c] */
            ii(0x17_4f93, 4); mov(memw[ds, 0xb4], cx);                  /* mov [0xb4], cx */
            ii(0x17_4f97, 2); mov(cl, 0xe);                             /* mov cl, 0xe */
            ii(0x17_4f99, 2); sub(cl, al);                              /* sub cl, al */
            ii(0x17_4f9b, 3); mov(al, memb[ss, bp - 0x4]);              /* mov al, [bp-0x4] */
            ii(0x17_4f9e, 2); shl(al, cl);                              /* shl al, cl */
            ii(0x17_4fa0, 3); mov(memb[ds, 0xb6], al);                  /* mov [0xb6], al */
            ii(0x17_4fa3, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4fa4, 1); leave();                                  /* leave */
            ii(0x17_4fa5, 1); retf(); return;                           /* retf */
        l_0x17_4fa6:
            ii(0x17_4fa6, 5); mov(memb[ds, 0xb2], 0);                   /* mov byte [0xb2], 0x0 */
            ii(0x17_4fab, 1); pop(ds);                                  /* pop ds */
            ii(0x17_4fac, 1); leave();                                  /* leave */
            ii(0x17_4fad, 1); retf();                                   /* retf */
        }
    }
}
