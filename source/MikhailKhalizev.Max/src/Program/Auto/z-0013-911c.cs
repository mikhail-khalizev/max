using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("8ddeff83-5bf8-46c8-a671-ae0e3a0130fa")]
        public void Method_0013_911c()
        {
            ii(0x13_911c, 1); pushw(bp);                                /* push bp */
            ii(0x13_911d, 2); mov(bp, sp);                              /* mov bp, sp */
            ii(0x13_911f, 1); pushw(ds);                                /* push ds */
            ii(0x13_9120, 1); pushw(si);                                /* push si */
            ii(0x13_9121, 3); mov(cx, 0x10);                            /* mov cx, 0x10 */
            ii(0x13_9124, 3); lds(dx, ss, bp + 0x6);                    /* lds dx, [bp+0x6] */
            ii(0x13_9127, 2); mov(si, dx);                              /* mov si, dx */
            ii(0x13_9129, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_912a, 2); or(al, al);                               /* or al, al */
            ii(0x13_912c, 4); if(jzw(0x13_914b, 0x1b)) goto l_0x13_914b; /* jz 0x914b */
            ii(0x13_9130, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_9131, 2); cmp(al, 0x3a);                            /* cmp al, 0x3a */
            ii(0x13_9133, 4); if(jnzw(0x13_913e, 0x7)) goto l_0x13_913e; /* jnz 0x913e */
            ii(0x13_9137, 1); lodsb_a16();                              /* lodsb */
            ii(0x13_9138, 2); or(al, al);                               /* or al, al */
            ii(0x13_913a, 4); if(jzw(0x13_914b, 0xd)) goto l_0x13_914b; /* jz 0x914b */
        l_0x13_913e:
            ii(0x13_913e, 3); mov(ax, 0x4300);                          /* mov ax, 0x4300 */
            ii(0x13_9141, 4); callw_a16_far_ind(ds, 0x1fe0);            /* call far word [0x1fe0] */
            ii(0x13_9145, 4); if(jaew(0x13_914b, 0x2)) goto l_0x13_914b; /* jae 0x914b */
            ii(0x13_9149, 2); sub(cl, cl);                              /* sub cl, cl */
        l_0x13_914b:
            ii(0x13_914b, 2); mov(ax, cx);                              /* mov ax, cx */
            ii(0x13_914d, 2); and(al, 0x10);                            /* and al, 0x10 */
            ii(0x13_914f, 1); popw(si);                                 /* pop si */
            ii(0x13_9150, 1); popw(ds);                                 /* pop ds */
            ii(0x13_9151, 1); popw(bp);                                 /* pop bp */
            ii(0x13_9152, 1); retfw(); return;                          /* retf */
        }
    }
}
