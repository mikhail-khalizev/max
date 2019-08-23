using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x17_911c-ec46d81f")]
        public void Method_0017_911c()
        {
            ii(0x17_911c, 1); push(bp);                                 /* push bp */
            ii(0x17_911d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x17_911f, 1); push(ds);                                 /* push ds */
            ii(0x17_9120, 1); push(si);                                 /* push si */
            ii(0x17_9121, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x17_9124, 3); lds(dx, memw[ss, bp + 0x6]);              /* lds dx, [bp+0x6] */
            ii(0x17_9127, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x17_9129, 1); lodsb();                                  /* lodsb */
            ii(0x17_912a, 2); or(al, al);                               /* or al, al */
            ii(0x17_912c, 4); if(jz(0x17_914b, 0x1b)) goto l_0x17_914b; /* jz 0x914b */
            ii(0x17_9130, 1); lodsb();                                  /* lodsb */
            ii(0x17_9131, 2); cmp(al, 0x3a);                            /* cmp al, 0x3a */
            ii(0x17_9133, 4); if(jnz(0x17_913e, 0x7)) goto l_0x17_913e; /* jnz 0x913e */
            ii(0x17_9137, 1); lodsb();                                  /* lodsb */
            ii(0x17_9138, 2); or(al, al);                               /* or al, al */
            ii(0x17_913a, 4); if(jz(0x17_914b, 0xd)) goto l_0x17_914b;  /* jz 0x914b */
        l_0x17_913e:
            ii(0x17_913e, 3); mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0x17_9141, 4); call_far_ind(ds, 0x1fe0);                 /* call far word [0x1fe0] */
            ii(0x17_9145, 4); if(jae(0x17_914b, 0x2)) goto l_0x17_914b; /* jae 0x914b */
            ii(0x17_9149, 2); sub(cl, cl);                              /* sub cl, cl */
        l_0x17_914b:
            ii(0x17_914b, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x17_914d, 2); and(al, 0x10);                            /* and al, 0x10 */
            ii(0x17_914f, 1); pop(si);                                  /* pop si */
            ii(0x17_9150, 1); pop(ds);                                  /* pop ds */
            ii(0x17_9151, 1); pop(bp);                                  /* pop bp */
            ii(0x17_9152, 1); retf();                                   /* retf */
        }
    }
}
