using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1018_20c6-4b364719")]
        public void /* sys */ Method_1018_20c6()
        {
            ii(0x1018_20c6, 2); mov(cl, 0x7);                           /* mov cl, 0x7 */
            ii(0x1018_20c8, 4); mov(ax, 0x2502);                        /* mov ax, 0x2502 */
            ii(0x1018_20cc, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_20ce, 6); mov(memd[ds, 0x101b_e80c], ebx);        /* mov [0x101be80c], ebx */
            ii(0x1018_20d4, 7); mov(memw[ds, 0x101b_e810], es);         /* mov [0x101be810], es */
            ii(0x1018_20db, 7); cmp(memb[ds, 0x101b_e58e], 0x3);        /* cmp byte [0x101be58e], 0x3 */
            ii(0x1018_20e2, 2); mov(cl, 0x7);                           /* mov cl, 0x7 */
            ii(0x1018_20e4, 4); mov(ax, 0x2504);                        /* mov ax, 0x2504 */
            ii(0x1018_20e8, 1); push(ds);                               /* push ds */
            ii(0x1018_20e9, 1); push(cs);                               /* push cs */
            ii(0x1018_20ea, 1); pop(ds);                                /* pop ds */
            ii(0x1018_20eb, 2); if(jl(0x1018_20fd, 0x10)) goto l_0x1018_20fd; /* jl 0x101820fd */
            ii(0x1018_20ed, 6); lea(edx, /* sys */ 0x1019_6bdc);        /* lea edx, [0x10196bdc] */
            ii(0x1018_20f3, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_20f5, 1); pop(ds);                                /* pop ds */
            ii(0x1018_20f6, 5); call(/* sys */ 0x1018_2113, 0x18);      /* call 0x10182113 */
            ii(0x1018_20fb, 2); jmp(0x1018_2112, 0x15); goto l_0x1018_2112; /* jmp 0x10182112 */
        l_0x1018_20fd:
            ii(0x1018_20fd, 6); lea(edx, /* sys */ 0x1019_6c4c);        /* lea edx, [0x10196c4c] */
            ii(0x1018_2103, 2); @int(0x21);                             /* int 0x21 */
            ii(0x1018_2105, 1); pop(ds);                                /* pop ds */
            ii(0x1018_2106, 3); mov(ecx, cr0);                          /* mov ecx, cr0 */
            ii(0x1018_2109, 3); or(ecx, 0x4);                           /* or ecx, 0x4 */
            ii(0x1018_210c, 3); and(ecx, -0x3 /* 0xfd */);              /* and ecx, 0xfffffffd */
            ii(0x1018_210f, 3); mov(cr0, ecx);                          /* mov cr0, ecx */
        l_0x1018_2112:
            ii(0x1018_2112, 1); ret();                                  /* ret */
        }
    }
}
